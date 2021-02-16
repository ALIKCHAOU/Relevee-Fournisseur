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
using DevExpress.XtraGrid.Views.Grid;
using Retenu_Fournisseur.Repport;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Threading;

namespace Retenu_Fournisseur.Forms
{
    public partial class FrmReleveeFournisseur : DevExpress.XtraEditors.XtraForm
    {
        public Retenu_Fournisseur.Model.ContextApplication db { get; set; }
        private static FrmReleveeFournisseur _FrmReleveeFournisseur;
        string sqlFounissuer = @"SELECT  *
  FROM [dbo].[vEcritureFournisseur] 
  where  TiersNumero=";
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
	AND EX.ANNEE  IN( SELECT TOP 1 L.ANNEE FROM vExercice AS L  ORDER BY L.ANNEE asc )  
	 where  E.[TiersNumero] = @Fournisseur 
  -- first exercice 
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
  WHERE  MV.DomaineReglement = 1 AND MV.ComptaReglement = 0 and T.Numero = cast(@Fournisseur as varchar)";

        string QuerrySociete = @"
SELECT  [D_RaisonSoc] as RaisonSociale
      ,[D_Profession] as  Profession
      ,[D_Adresse] as Adresse
	  ,[D_Telephone] as Tel 
      ,[D_Telecopie]   as Fax    
  FROM [dbo].[P_DOSSIER]";

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
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            string decimalSeparator = culture.NumberFormat.NumberDecimalSeparator;
            decimal Debit;
            decimal Credit;
            decimal Solde;
            decimal Montant;

            List<Factures> ListFacture = new List<Factures>();
            var Sage = db.BaseDonees.Where(x => x.Name == "Sage").SingleOrDefault();
            var CHAABANECORPORATE = db.BaseDonees.Where(x => x.Name == "CHAABANECORPORATE").SingleOrDefault();

            string con = Sage.StringConnection(Sage);


            /// getselectRowColumn from comboboxdevis
            GridView view = SbFounisseur.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = "CT_Num"; // or other field name  
            object FournisseurSelected = view.GetRowCellValue(rowHandle, fieldName);
            /// getselectRowColumn from comboboxdevis

            ///Condition existance Fournisseur
            if (FournisseurSelected == null)
            {
                XtraMessageBox.Show("Choisir un Fournisseur ", "Fournisseur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                SbFounisseur.Focus();

                BtnImpression.Enabled = false;

            } ///Condition existance devis

            //Recherche
            else
            {

                //  var parameters = new { Fournisseur = "F4000"};
                //using (IDbConnection dbConnection = new SqlConnection(CHAABANECORPORATE.StringConnection(CHAABANECORPORATE)))
                //{
                //    if (dbConnection.State == System.Data.ConnectionState.Closed)
                //        dbConnection.Open();



                //    var Resulat = dbConnection.Query<Factures>(sqlFounissuer,0, commandType: CommandType.Text);

                //}

                using (var cn = new SqlConnection(CHAABANECORPORATE.StringConnection(CHAABANECORPORATE)))
                {
                    cn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =@"SELECT E.TiersNo
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
	AND EX.ANNEE  IN( SELECT TOP 1 L.ANNEE FROM vExercice AS L  ORDER BY L.ANNEE asc )  
	 where  E.[TiersNumero] ='"+ FournisseurSelected+"'"+@"
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
  WHERE  MV.DomaineReglement = 1 AND MV.ComptaReglement = 0 and T.Numero ='"+FournisseurSelected+"'";
                    var rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        
                        Console.WriteLine(rdr.GetValue(0).ToString());
                        Factures FA = new Factures();
                       // DateTime startDate = DateTime.ParseExact("01/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                       // FA.Date =  DateTime.ParseExact(rdr["Date"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        FA.Date = Convert.ToDateTime(rdr["Date"]);
                        FA.Echeance = Convert.ToDateTime(rdr["Echeance"]);                        
                        FA.IsLettre = rdr["IsLettre"].ToString();
                        FA.Journal = rdr["Journal"].ToString();
                        FA.Libelle = rdr["Libelle"].ToString();
                        FA.Mode = rdr["Mode"].ToString();
                        string MontantStr = rdr["Montant"].ToString().Replace(",", decimalSeparator).Replace(".", decimalSeparator);
                        decimal.TryParse(MontantStr, out Montant);
                        FA.Montant = Montant;
                        if(Montant<0)
                        {
                            FA.Credit = Montant;
                        }
                        else
                        {
                            FA.Debit = Montant;
                        }
                        FA.Solde = Montant;
                        FA.Numero= rdr["Numero"].ToString();
                        FA.Sens = Convert.ToInt32(rdr["Sens"].ToString());
                        FA.SocieteNo= rdr["SocieteNo"].ToString();
                        FA.TiersIntitule= rdr["TiersIntitule"].ToString();
                        FA.TiersNo = rdr["TiersNo"].ToString();

                     //   bool isParsable = Int32.TryParse(rdr["TiersNumero"].ToString(), out number);
                        FA.TiersNumero = rdr["TiersNumero"].ToString();
                        FA.TypeCode = rdr["TypeCode"].ToString();
                        ListFacture.Add(FA);
                        //rdr.GetValue(0).ToString() pour avoir la valeur de la premiére colonne en format de chaine de caractére
                    }
                    var resultat = ListFacture.ToList();
                    facturesBindingSource.DataSource= ListFacture.ToList().OrderByDescending(x=>x.Date);

                }         




                // var d = cbDevis.Properties.DisplayMember = "D_Mode";

                //    F_Ecriture_BindingSource.DataSource = dbConnection.Query<Models.F_ECRITUREC>(Query, commandType: CommandType.Text);
                XtraMessageBox.Show("Recherche Terminer", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnImpression.Enabled = true;
                BtnRecherche.Enabled = true;




            }
            //Recherche



        }

        private void BtnImpression_Click(object sender, EventArgs e)
        {
            List<ImpressionReleveeFournisseur> IRFS = new List<ImpressionReleveeFournisseur>();
            ImpressionReleveeFournisseur IRF = new ImpressionReleveeFournisseur();
            List<Factures> Factures = new List<Factures>();
            int rowHandle = 0;
            while (gridView1.IsValidRowHandle(rowHandle))
            {
                Factures Facture = gridView1.GetRow(rowHandle) as Factures;
                Factures.Add(Facture);
                bool isSelected = gridView1.IsRowSelected(rowHandle);
                rowHandle++;
            }
            var Sage = db.BaseDonees.Where(x => x.Name == "Sage").SingleOrDefault();
            var CHAABANECORPORATE = db.BaseDonees.Where(x => x.Name == "CHAABANECORPORATE").SingleOrDefault();
            string con = Sage.StringConnection(Sage);       
                
                using (IDbConnection dbConnection = new SqlConnection(Sage.StringConnection(Sage)))
                {
                    if (dbConnection.State == System.Data.ConnectionState.Closed)
                        dbConnection.Open();

                    var Societe = dbConnection.Query<Societe>(QuerrySociete, commandType: CommandType.Text).FirstOrDefault();
                    IRF.Adresse = Societe.Adresse;
                    IRF.Fax = Societe.Fax.Substring(5, 8);
                    IRF.Profession = Societe.Profession;
                    IRF.RaisonSociale = Societe.RaisonSociale;
                    IRF.Tel = Societe.Tel.Substring(5, 8);
                    IRF.Factures = Factures;


                }
               IRFS.Add(IRF);



               ReleveeFournisseurRapport RF = new ReleveeFournisseurRapport();
              
                RF.DataSource = Factures.ToList();

                ReportPrintTool tool = new ReportPrintTool(RF);
                tool.ShowPreview();

                // Etat de Activiè Caisse

                // var d = cbDevis.Properties.DisplayMember = "D_Mode";

                //    F_Ecriture_BindingSource.DataSource = dbConnection.Query<Models.F_ECRITUREC>(Query, commandType: CommandType.Text);
               

                BtnImpression.Enabled = true;
                BtnRecherche.Enabled = true;












        }
    }
}