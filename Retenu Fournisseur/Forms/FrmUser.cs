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

namespace Retenu_Fournisseur.Forms
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public Retenu_Fournisseur.Model.ContextApplication db { get; set; }
        private static FrmUser _FrmUser;
        public static FrmUser InstanceFrmUser
        {
            get
            {
                if (_FrmUser == null)
                    _FrmUser = new FrmUser();
                return _FrmUser;
            }
        }
        public FrmUser()
        {
            InitializeComponent();
            db = new Retenu_Fournisseur.Model.ContextApplication();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = db.Users.ToList();
        }
        private void refreshForm()
        {

            var User = gridView1.GetFocusedRow() as Retenu_Fournisseur.Model.User;
            TxtLogin.Text = User.Login;
            TxtPernom.Text = User.LastName;
            TxtName.Text = User.FirstName;
            TxtPassword.Text = User.Password;
            TxtEmail.Text = User.EmailAddress;
            if (User.IsAdmin)
            { checkAdmin.Checked = true; }
            else
            { checkAdmin.Checked = false; }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            refreshForm();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            var User = gridView1.GetFocusedRow() as Retenu_Fournisseur.Model.User;
            User.Login = TxtLogin.Text;
            User.LastName = TxtPernom.Text;
            User.FirstName = TxtName.Text;
            User.Password = TxtPassword.Text;
            User.EmailAddress = TxtEmail.Text;
            if (checkAdmin.Checked)
            {

                User.IsAdmin = true;
            }
            else
            {
                User.IsAdmin = false;

            }

            /***************************** Base de donèèss ***********************************/
            var UserBb = db.Users.Find(User.ID);
            UserBb = User;
            db.SaveChanges();


            /***************************** Base de donèèss ***********************************/



            /***************************** reload DataGridView ***********************************/
            userBindingSource.DataSource = db.Users.ToList();
            /***************************** reload DataGridView  ***********************************/

            XtraMessageBox.Show("Enregistrement terminé");
            refreshForm();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("voulez vous supprimer cet élément ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {

                var User = gridView1.GetFocusedRow() as Retenu_Fournisseur.Model.User;
                var UserBb = db.Users.Find(User.ID);
                db.Users.Remove(UserBb);
                db.SaveChanges();
                /***************************** reload DataGridView ***********************************/
                userBindingSource.DataSource = db.Users.ToList();
                /***************************** reload DataGridView  ***********************************/
                XtraMessageBox.Show("l'utilisateur a été supprimé avec Succès");

                refreshForm();



            }
            else
            {
                XtraMessageBox.Show("la suppression été annulé");
            }
        }
    }
}