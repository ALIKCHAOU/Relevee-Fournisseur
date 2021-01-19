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
    public partial class FrmApropos : DevExpress.XtraEditors.XtraForm
    {
        private static FrmApropos _FrmApropos;
        public static FrmApropos InstanceFrmApropos
        {
            get
            {
                if (_FrmApropos == null)
                    _FrmApropos = new FrmApropos();
                return _FrmApropos;
            }
        }
        public FrmApropos()
        {
            InitializeComponent();
            //lbSociete.Text = string.Format("Société : {0}", "Amen Conceil");
            //lBTunis.Text = "Golden Estates-9 ème étage App D7-D8 - Centre Urbain Nord-1082 Tunis Tunisie";
            //lbSfax.Text = "Route Gabes, Km3 Immeuble SOTEME 1er étage-3052 Sfax Tunisie";
            //lbTel.Text = " +216 70 033 140 - +216  22 130 046";
            //lbFax1.Text = " +216 71 428 135 - +216 74 452 352";
            //lbEmail.Text = "contact@groupe-ec.com";
        }

        private void FrmApropos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmApropos = null;
        }
    }
}