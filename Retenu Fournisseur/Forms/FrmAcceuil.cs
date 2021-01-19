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
    public partial class FrmAcceuil : DevExpress.XtraEditors.XtraForm
    {

        private static FrmAcceuil _FrmAcceuil;
        public static FrmAcceuil InstanceFrmAcceuil
        {
            get
            {
                if (_FrmAcceuil == null)
                    _FrmAcceuil = new FrmAcceuil();
                return _FrmAcceuil;
            }
        }
        public FrmAcceuil()
        {
            InitializeComponent();
        }

        private void FrmAcceuil_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmAcceuil = null;
        }
    }
}