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
   
    public partial class FModificarFacturas : Form
    {
        private int Numerof;
        public FModificarFacturas(int NumeroFactura)
        {
            InitializeComponent();
            Numerof = NumeroFactura;
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
                BAtualizarF.Focus();
            }
        }

        private void FModificarFacturas_Load(object sender, EventArgs e)
        {
            FACTURASvictorP fact = DatosFactura.Cargar(Numerof);
            Numerof = fact.NUMEROFACTURA;
            TBCodigoC.Text = fact.CODIGO;
            TBValorF.Text = Convert.ToString(fact.VALORFACTURA);
            TBFechaF.Text = Convert.ToString(fact.FECHAFACTURA);
            TBFechaV.Text = Convert.ToString(fact.FECHAVENCIMIENTO);
        }

        private void BAtualizarF_Click(object sender, EventArgs e)
        {
            DatosFactura.ModificarFactura( Convert.ToInt16(TBNumeroF.Text), TBCodigoC.Text,Convert.ToDecimal(TBValorF.Text),Convert.ToDateTime(TBFechaF.Text), Convert.ToDateTime(TBFechaV.Text));
            MessageBox.Show("LA FACTURA SE MODIFICÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
            Close();
        }
    }
}
