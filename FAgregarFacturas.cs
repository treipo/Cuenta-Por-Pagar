using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_Por_Pagar
{
    public partial class FAgregarFacturas : Form
    {
        public FAgregarFacturas()
        {
            InitializeComponent();
        }

        private void TBNumeroF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBCodigoC.Focus();
            }
        }

        private void TBCodigoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBValorF.Focus();
            }
        }

        private void TBValorF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBFechaF.Focus();
            }
        }

        private void TBFechaF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBFechaV.Focus();
            }
        }

        private void TBFechaV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BAgregarf.Focus();
            }
        }

        private void BAgregarf_Click(object sender, EventArgs e)
        {
            DatosFactura.AgregarFactura( Convert.ToInt16(TBNumeroF.Text), TBCodigoC.Text, Convert.ToDecimal(TBValorF.Text), Convert.ToDateTime(TBFechaF.Text),Convert.ToDateTime(TBFechaV.Text));
            MessageBox.Show("LA FACTURA SE AGREGÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
            Close();
        }
    }
}
