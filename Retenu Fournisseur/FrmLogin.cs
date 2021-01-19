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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Retenu_Fournisseur
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public Model.ContextApplication db { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            db = new Model.ContextApplication();
#if DEBUG
            TxtLogin.EditValue = "Admin";
            TwtPwd.EditValue = "Admin";
#endif
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MainRibbonForm MainRibbon = new MainRibbonForm();
            string Login = TxtLogin.Text.Trim();
            string Motdepass = TwtPwd.Text.Trim();
            if (string.IsNullOrEmpty(Login))
            {
                TxtLogin.ErrorText = "Login  est obligatoire";
                return;
            }
            if (string.IsNullOrEmpty(Motdepass))
            {
                TwtPwd.ErrorText = "Password  est obligatoire";
                return;
            }






            var Utilisateur = ProcessLogin(Login, Motdepass);
            if (Utilisateur != null)
            {
                MainRibbon.Show();
                this.Hide();
                Formshow(Forms.FrmAcceuil.InstanceFrmAcceuil,MainRibbon);
            }

        }
        public void Formshow(Form frm , MainRibbonForm frm1)
        {
            // waiting Form
            SplashScreenManager.ShowForm(this, typeof(Forms.FrmWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Processesing in Data ....");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
            //waiting Form
            frm.MdiParent = frm1;
            frm.Show();
            frm.Activate();
        }

        private User ProcessLogin(string Login, string password)
        {

            var Utilisateur = db.Users.SingleOrDefault(a => a.Login.Equals(Login));
            if (Utilisateur != null)
            {
                if (Utilisateur.Password.Equals(password))
                {
                    return Utilisateur;
                }
                else
                {
                    TwtPwd.ErrorText = "Mot de passe invalide";
                    return null;
                }
            }
            else
            {
                TxtLogin.ErrorText = "Login  est  invalide";
                return null;
            }
        }
    }
}