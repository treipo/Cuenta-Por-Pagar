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
    public partial class FAgregarCheques : Form
    {
        public FAgregarCheques()
        {
            InitializeComponent();
        }

        private void TBNumeroCQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBNumeroF.Focus();
            }
        }

        private void TBNumeroF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBValorCQ.Focus();
            }
        }

        private void TBValorCQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBFechaCQ.Focus();
            }
        }

        private void TBFechaCQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BAgregarCQ.Focus();
            }
        }

        private void BAgregarCQ_Click(object sender, EventArgs e)
        {
            try
            {
                DatosCheques.AgregarCheque(int.Parse(TBNumeroCQ.Text),int.Parse(TBNumeroF.Text), decimal.Parse(TBValorCQ.Text),DateTime.Parse(TBFechaCQ.Text));
                MessageBox.Show("EL CHEQUE SE AGREGÓ SATISFACTORIAMENTE", "AGREGAR CHEQUE");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA INVALIDA. TRATE DE NUEVO");
                TBNumeroCQ.Focus();
            }
        }
    }
}
