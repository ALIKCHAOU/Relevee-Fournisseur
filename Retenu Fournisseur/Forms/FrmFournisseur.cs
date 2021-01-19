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
    }
}