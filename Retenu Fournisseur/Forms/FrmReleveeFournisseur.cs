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

        string QuerrySociete = @"
SELECT [D_RaisonSoc] as RaisonSociale   ,[D_Profession]
      ,[D_Adresse]
      ,[D_Complement]
      ,[D_CodePostal]
      ,[D_Ville]
      ,[D_CodeRegion]
      ,[D_Pays]
      ,[D_Commentaire]
      ,[D_Siret]
      ,[D_Ape]
      ,[D_Identifiant]
      ,[D_DebutExo01]
      ,[D_DebutExo02]
      ,[D_DebutExo03]
      ,[D_DebutExo04]
      ,[D_DebutExo05]
      ,[D_FinExo01]
      ,[D_FinExo02]
      ,[D_FinExo03]
      ,[D_FinExo04]
      ,[D_FinExo05]
      ,[D_LgCg]
      ,[D_LgAn]
      ,[D_FormatQtes]
      ,[D_CodeTrait]
      ,[D_ConfSupp]
      ,[D_AnalyseGL01]
      ,[D_AnalyseGL02]
      ,[D_AnalyseGL03]
      ,[D_Delai]
      ,[D_OuvCompte]
      ,[D_Budget]
      ,[D_SuppEc]
      ,[D_RegTaxe]
      ,[D_Ventil]
      ,[D_Edi]
      ,[D_Archivage01]
      ,[D_Archivage02]
      ,[D_Archivage03]
      ,[D_Archivage04]
      ,[D_Archivage05]
      ,[D_RBSupp]
      ,[D_MajImport]
      ,[D_SaisCab]
      ,[D_TypeValid]
      ,[D_ImpressZero]
      ,[N_DeviseCompte]
      ,[N_DeviseEquival]
      ,[D_ANSais]
      ,[JO_NumAN]
      ,[CG_NumANOuv]
      ,[CG_NumANBenef]
      ,[CG_NumANPerte]
      ,[D_TVAEncReg]
      ,[D_TVAEncAffect]
      ,[D_DeviseEq]
      ,[D_AnAffect]
      ,[D_ReglPiece]
      ,[D_ExtNeg]
      ,[D_RapproDevise]
      ,[D_ImportEqJo]
      ,[D_ImportEqAn]
      ,[CG_NumImportDebit]
      ,[CG_NumImportCredit]
      ,[N_Analytique]
      ,[D_NumDoss]
      ,[D_EMail]
      ,[D_EMailExpert]
      ,[D_Expert]
      ,[D_Telephone]
      ,[D_Telecopie]
      ,[D_EMailSoc]
      ,[D_Site]
      ,[D_AppelTiers]
      ,[D_AppelSection]
      ,[D_ProtPiece]
      ,[D_NumCont]
      ,[D_DateClot]
      ,[D_CompteGTotal]
      ,[D_RapproRecherche]
      ,[D_RapproEcart]
      ,[CG_NumRappro]
      ,[D_RapproContrepartie]
      ,[D_ComSens]
      ,[D_ComType]
      ,[D_ComMoyen]
      ,[D_ComSoft]
      ,[D_ComCodeExpert]
      ,[D_ComDateSynchro]
      ,[D_ComGUID]
      ,[D_RapproTypeEcart]
      ,[D_RapproReport]
      ,[JO_NumRapproEscCl]
      ,[PI_NoRapproEscCl]
      ,[JO_NumRapproEscFr]
      ,[PI_NoRapproEscFr]
      ,[D_GestionIFRS]
      ,[D_SaisieIFRS]
      ,[N_AnalytiqueIFRS]
      ,[JA_NumAN]
      ,[JO_NumANIFRS]
      ,[JA_NumANIFRS]
      ,[D_RappelSoldeMin]
      ,[D_ImportVentil]
      ,[D_PenalTaux]
      ,[D_PenalImputation]
      ,[JO_NumPenal]
      ,[PI_NoPenal]
      ,[D_Impayes]
      ,[JO_NumImpayes]
      ,[PI_NoImpayes]
      ,[D_ImpressFactRef]
      ,[D_SeuilTVA]
      ,[D_NotSaisieSommeil]
      ,[D_NormeDGI]
      ,[D_ArchivePeriod]
      ,[D_ECNoCloture01]
      ,[D_ECNoCloture02]
      ,[D_ECNoCloture03]
      ,[D_ECNoCloture04]
      ,[D_ECNoCloture05]
      ,[D_CloturePeriod]
      ,[cbMarq]
        FROM[CHAABANE].[dbo].[P_DOSSIER]";

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
                BtnRecherche.Enabled = false;
            } ///Condition existance devis

            //Recherche
            else
            {
                using (IDbConnection dbConnection = new SqlConnection(Sage.StringConnection(Sage)))
                {
                    if (dbConnection.State == System.Data.ConnectionState.Closed)
                        dbConnection.Open();

                    var Societe = dbConnection.Query(QuerrySociete, commandType: CommandType.Text);
                    var Resulat = dbConnection.Query<Factures>(sqlrequest, commandType: CommandType.Text);

                }

              

                // var d = cbDevis.Properties.DisplayMember = "D_Mode";
               
                    //    F_Ecriture_BindingSource.DataSource = dbConnection.Query<Models.F_ECRITUREC>(Query, commandType: CommandType.Text);
  XtraMessageBox.Show("Recherche Terminer", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                BtnImpression.Enabled = true; 
                BtnRecherche.Enabled = true;




            }
            //Recherche

          

        }
    }
}