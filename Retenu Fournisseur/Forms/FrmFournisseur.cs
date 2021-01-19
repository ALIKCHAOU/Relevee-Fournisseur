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
using System.Data.SqlClient;
using Dapper;

namespace Retenu_Fournisseur.Forms
{
    public partial class FrmFournisseur : DevExpress.XtraEditors.XtraForm
    {
        private static FrmFournisseur _FrmFournisseur;
      //  public SAP_XRT_Models.DTS.Context.SAPXRTDbContext db { get; set; }

        public static FrmFournisseur InstanceFrmFournisseur
        {
            get
            {
                if (_FrmFournisseur == null)
                    _FrmFournisseur = new FrmFournisseur();
                return _FrmFournisseur;
            }
        }
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void FrmFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmFournisseur = null;
        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {
            //try
            //{
                //FournisseurModel fournisseurModel = new FournisseurModel();
                //var Sage = db.DataBaseSettings.Where(x => x.Name == "Sage").SingleOrDefault();

                //string con = Sage.StringConnection(Sage);
                //using (IDbConnection dbConnection = new SqlConnection(Sage.StringConnection(Sage)))
                //{
                //    if (dbConnection.State == System.Data.ConnectionState.Closed)
                //        dbConnection.Open();

                //    string Query = @"SELECT CT_Num, CT_Intitule, CT_Contact, CT_Adresse, CT_Complement, CT_CodePostal,CT_Qualite, CT_Ville, CT_Pays,CT_Telephone,CT_Identifiant,CT_Telecopie FROM  F_COMPTET WHERE   CT_Type = 1";
                //    fournisseurModelBindingSource.DataSource = dbConnection.Query<FournisseurModel>(Query, commandType: CommandType.Text);

                //}


            //}
            //catch (Exception erreur)
            //{

            //    XtraMessageBox.Show("Configuration Base Sage Invalid", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    erreur.ToString();
            //}
        }
    }
}