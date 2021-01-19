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

namespace Retenu_Fournisseur.Forms
{
    public partial class FrmBaseDonnee : DevExpress.XtraEditors.XtraForm
    {
        private static FrmBaseDonnee _FrmBaseDonnee;
        Retenu_Fournisseur.Model.ContextApplication db { get; set; }
        public static FrmBaseDonnee InstanceFrmBaseDonnee
        {
            get
            {
                if (_FrmBaseDonnee == null)
                    _FrmBaseDonnee = new FrmBaseDonnee();
                return _FrmBaseDonnee;
            }
        }
        public FrmBaseDonnee()
        {
            InitializeComponent();
            db = new Model.ContextApplication();
        }

        private void FrmBaseDonnee_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmBaseDonnee = null;
        }

        private void FrmBaseDonnee_Load(object sender, EventArgs e)
        {
            BaseDonee DataBase  = new BaseDonee();

             DataBase= db.BaseDonees.First();
            TxtPassword.Text = DataBase.Password;
            TxtSa.Text = DataBase.UserName;
            TxtBaseDonnee.Text = DataBase.NameDataBase;
            TxtServer.Text = DataBase.ServerName;
        }
    }
}