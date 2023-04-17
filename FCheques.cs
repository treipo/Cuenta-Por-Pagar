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
    public partial class FCheques : Form
    {
        public FCheques()
        {
            InitializeComponent();
        }

        private void FCheques_Load(object sender, EventArgs e)
        {
            DGVCheque.DataSource = DatosCheques.MostarCheque();
        }

        private void TBNumeroCQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVCheque.DataSource = DatosCheques.BuscarCheque(int.Parse(TBNumeroCQ.Text));
            }
            catch
            {
                MessageBox.Show("LA ENTRADA DEBE SER NUMÉRICA");
                TBNumeroCQ.Focus();
            }
        }

        private void TBNumeroF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVCheque.DataSource = DatosCheques.BuscarNumeroFactura(int.Parse(TBNumeroF.Text));
            }
            catch
            {
                MessageBox.Show("LA ENTRADA DEBE SER NUMÉRICA");
                TBNumeroF.Focus();
            }
        }

        private void FCheques_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVCheque.DataSource = DatosCheques.MostarCheque();
        }

        private void BAgregarCQ_Click(object sender, EventArgs e)
        {
            FAgregarCheques FAC = new FAgregarCheques();
            FAC.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCheques_FormClosed);
            FAC.Show();
        }

        private void BModificarCQ_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVCheque.CurrentRow;
            int Numero = Convert.ToInt16(FILA.Cells[0].Value);
            FModificarCheque FMP = new FModificarCheque(Numero);
            FMP.Show();
            FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCheques_FormClosed);
            DGVCheque.DataSource = DatosProveedores.MostrarDatos();
        }

        private void BEliminarCQ_Click(object sender, EventArgs e)
        {
            DialogResult Repuesta = MessageBox.Show("DESEA ELIMINAR ESTA FACTURA?", "ADVERTENCIA DE ELIMINACION",MessageBoxButtons.YesNo);
            if (Repuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVCheque.CurrentRow;
                int NumeroCheque = Convert.ToUInt16(FILA.Cells[0].Value);
                DatosCheques.ElimunarCheque(NumeroCheque);
                MessageBox.Show("SE HA BORRADO LA FACTURA" + NumeroCheque, "REGISTRO ELIMINADO");
                DGVCheque.DataSource = DatosCheques.Cargar(NumeroCheque);
            }
        }
    }
}
