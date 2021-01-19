using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace Retenu_Fournisseur
{
    public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainRibbonForm()
        {
            InitializeComponent();
        }

        private void barReleveFournisseur_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formshow(Forms.FrmReleveeFournisseur.Instance_FrmReleveeFournisseur);
        }
        public void Formshow(Form frm)
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
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }
        public void FormshowNotParent(Form frm)
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
            // frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void MainRibbonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barFrounisseur_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formshow(Forms.FrmFournisseur.InstanceFrmFournisseur);
        }

        private void barAcceuil_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}