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
    public partial class FModificarCheque : Form
    {
        private int Numero;
        public FModificarCheque(int NumeroCheque)
        {
            InitializeComponent();
            Numero = NumeroCheque;
        }

        private void FModificarCheque_Load(object sender, EventArgs e)
        {
            CHEQUESvictorP CHQ = DatosCheques.Cargar(Numero);
            Numero = CHQ.NUMEROCHEQUE;
            TBNumeroCQ.Text = Convert.ToString(Numero);
            TBNumeroF.Text = Convert.ToString(TBNumeroF.Text);
            TBValorCQ.Text = Convert.ToString(CHQ.VALORCHEQUE);
            TBFechaCQ.Text = Convert.ToString(CHQ.FECHACHEQUE);
        }

        private void BAtualizarF_Click(object sender, EventArgs e)
        {
            try
            {
                DatosCheques.ModificarCheque(int.Parse(TBNumeroCQ.Text),int.Parse(TBNumeroF.Text),Convert.ToDecimal(TBValorCQ.Text),Convert.ToDateTime(TBFechaCQ.Text));
                MessageBox.Show("EL CHEUQUE SE MODIFICÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA IVÁLIDA. TRATE DE NUEVO", "ERROR DE ENTRADA");
            }
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
                BAtualizarF.Focus();
            }
        }
    }
    
}
