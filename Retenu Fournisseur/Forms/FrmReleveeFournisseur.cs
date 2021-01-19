using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Retenu_Fournisseur.Model;
using System.Data.SqlClient;
using Dapper;

namespace Retenu_Fournisseur.Forms
{
    public partial class FrmReleveeFournisseur : DevExpress.XtraEditors.XtraForm
    {    public Retenu_Fournisseur.Model.ContextApplication db { get; set; }
        private static FrmReleveeFournisseur _FrmReleveeFournisseur;
        string sqlrequest = @"SELECT E.TiersNo
	  ,E.[TiersNumero]
      ,E.[TiersIntitule]
      ,CASE E.SENS 
		WHEN 0 THEN  E.[Montant] * (-1)
		ELSE E.[Montant] 
	  END      [Montant]
      ,E.[Sens]
      ,E.[Intitule]		'Libelle'
      ,E.[Date]
      ,E.[Journal]
      ,E.[SocieteNo]
	  ,CASE E.SENS 
		WHEN 0 THEN  E.[Montant]
		ELSE 0
	  END 'Debit'
	  ,CASE E.SENS 
		WHEN 1 THEN  E.[Montant]
		ELSE 0
	    END 'Credit'
	  ,CASE ISNULL(EX.ANNEE , 0) WHEN   0 THEN 0 ELSE 1 END 'IsLastExercice'
	  ,'EC'		'TypeCode'
	  ,E.[Journal]		'Mode'
	  ,CASE  E.Reference WHEN  ' ' THEN E.RefPiece ELSE E.Reference END	'Numero'
	,E.IsLettre
	,E.Echeance		
	,E.PieceTreso			'Piece'
	,E.Contact
	,E.Adresse
	,E.Complement
	,E.CodePostal
	,E.Ville
	,E.CodeRegion
	,E.Pays
	,E.Tel
	,E.Fax
  FROM [dbo].[vEcritureFournisseur] AS E
  LEFT JOIN vExercice AS EX ON EX.Debut <= E.Date AND EX.Fin >= E.Date AND E.[SocieteNo] = EX.[SocieteNo] 
	AND EX.ANNEE  IN( SELECT TOP 1 L.ANNEE FROM vExercice AS L  ORDER BY L.ANNEE asc )   -- first exercice 
  
  UNION
  
  SELECT 
      T.No					'TiersNo'
  	  ,T.Numero				'TiersNumero'
	  ,T.Intitule			'TiersIntitule'
	  ,MV.MontantReglement * (-1)		'Montant'
	  ,0					'Sens'
	  ,MV.LibelleReglement		'Libelle'
	  ,Mv.DateReglement			'Date'
	  ,''					'Journal'
	  ,MV.SocieteNo				'SocieteNo'
	  ,MontantReglement			'Debit'
	  ,0					'Credit'
	  ,0					'IsLastExercice'
	  ,					    'TypeCode' =
      CASE MV.[TypeReglement]
         WHEN 0 THEN 'Espece'
         WHEN 1 THEN 'Cheque'
         WHEN 2 THEN 'Traite'
         WHEN 3 THEN 'Virement'
         WHEN 4 THEN 'Retenu'
      END
	  ,M.CodeMode			'Mode'
	  ,MV.NumeroReglement			'Numero'
	  ,0					'IsLettre'
	  ,MV.EchanceReglement		'Echeance'
	  ,MV.PieceReglement			'Piece'
	  ,T.Contact
	 ,T.Adresse
	 ,T.Complement
	 ,T.CodePostal
	 ,T.Ville
	 ,T.CodeRegion
	 ,T.Pays
	 ,T.Tel
	 ,T.Fax
  FROM Reglements AS MV
  INNER JOIN vTiers AS T ON MV.TiersNo = T.No AND MV.SocieteNo = T.SocieteNo AND T.Type = 1
  INNER JOIN ModesReg	AS M ON M.ModeReglementNo	= MV.ModeReglementNo
  WHERE  MV.DomaineReglement = 1 AND MV.ComptaReglement = 0";

        public static FrmReleveeFournisseur Instance_FrmReleveeFournisseur
        {
            get
            {
                if (_FrmReleveeFournisseur == null)
                    _FrmReleveeFournisseur = new FrmReleveeFournisseur();
                return _FrmReleveeFournisseur;
            }
        }
        public FrmReleveeFournisseur()
        {
            InitializeComponent();
            db = new ContextApplication();
        }

        private void FrmReleveeFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmReleveeFournisseur = null;
        }

        private void FrmReleveeFournisseur_Load(object sender, EventArgs e)
        {
            try
            {
                Frounisseur fournisseurModel = new Frounisseur();
                var Sage = db.BaseDonees.Where(x => x.Name == "Sage").SingleOrDefault();

                string con = Sage.StringConnection(Sage);
                using (IDbConnection dbConnection = new SqlConnection(Sage.StringConnection(Sage)))
                {
                    if (dbConnection.State == System.Data.ConnectionState.Closed)
                        dbConnection.Open();

                    string Query = @"SELECT CT_Num, CT_Intitule, CT_Contact, CT_Adresse, CT_Complement, CT_CodePostal,CT_Qualite, CT_Ville, CT_Pays,CT_Telephone,CT_Identifiant,CT_Telecopie FROM  F_COMPTET WHERE   CT_Type = 1";
                    frounisseurBindingSource.DataSource = dbConnection.Query<Frounisseur>(Query, commandType: CommandType.Text);

                }


            }
            catch (Exception erreur)
            {

                XtraMessageBox.Show("Configuration Base Sage Invalid", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erreur.ToString();
            }
        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            var Sage = db.BaseDonees.Where(x => x.Name == "Sage").SingleOrDefault();

            string con = Sage.StringConnection(Sage);
            using (IDbConnection dbConnection = new SqlConnection(Sage.StringConnection(Sage)))
            {
                if (dbConnection.State == System.Data.ConnectionState.Closed)
                    dbConnection.Open();

               
                var Resulat = dbConnection.Query<Factures>(sqlrequest, commandType: CommandType.Text);

            }

        }
    }
}