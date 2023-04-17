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
    public partial class FFacturas : Form
    {
        public FFacturas()
        {
            InitializeComponent();
        }

        private void FFacturas_Load(object sender, EventArgs e)
        {
            DGVFacturas.DataSource = DatosFactura.MostarFactura();
        }

        private void TBNumeroF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFacturas.DataSource = DatosFactura.BuscarFactura(Convert.ToUInt16(TBNumeroF.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese Un Valor Numerico");
                TBNumeroF.Focus();
            }
        }

        private void TBCodigoF_TextChanged(object sender, EventArgs e)
        {
            DGVFacturas.DataSource = DatosFactura.BuscarCodigoF(TBCodigoF.Text);
        }

        private void FFacturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFacturas.DataSource = DatosFactura.MostarFactura();
        }

        private void BAgregarF_Click(object sender, EventArgs e)
        {
            FAgregarFacturas FAF = new FAgregarFacturas();
            FAF.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFacturas_FormClosed);
            FAF.Show();
        }

        private void TBNumeroF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBCodigoF.Focus();
            }
        }

        private void BModificarF_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVFacturas.CurrentRow;
            int NumeroFactura = Convert.ToInt16(FILA.Cells[0].Value);
            FModificarFacturas FMF = new FModificarFacturas(NumeroFactura);
            FMF.Show();
            FMF.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFacturas_FormClosed);
        }

        private void BEliminarF_Click(object sender, EventArgs e)
        {
            DialogResult Repuesta = MessageBox.Show( "DESEA ELIMINAR ESTA FACTURA?", "ADVERTENCIA DE ELIMINACION",MessageBoxButtons.YesNo);
            if (Repuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVFacturas.CurrentRow;
                int NumeroFactura = Convert.ToUInt16(FILA.Cells[0].Value);
                DatosFactura.ElimunarFactura(NumeroFactura);
                MessageBox.Show("SE HA BORRADO LA FACTURA" + NumeroFactura, "REGISTRO ELIMINADO");
                DGVFacturas.DataSource = DatosFactura.MostarFactura();
            }

        }
    }
}
