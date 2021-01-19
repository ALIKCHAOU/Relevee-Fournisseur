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
    public partial class FrmReleveeFournisseur : DevExpress.XtraEditors.XtraForm
    {
        private static FrmReleveeFournisseur _FrmReleveeFournisseur;
        //  public SAP_XRT_Models.DTS.Context.SAPXRTDbContext db { get; set; }

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
        }

        private void FrmReleveeFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmReleveeFournisseur = null;
        }
    }
}