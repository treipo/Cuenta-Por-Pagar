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
    public partial class FProveedores : Form
    {
        public FProveedores()
        {
            InitializeComponent();
        }

        private void FAgregarprov_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosProveedores.MostrarDatos();
        }

        private void FModificarprov_FormClosed(object sender,FormClosedEventArgs e)
        {
            DatosProveedores.MostrarDatos();
        }

        private void TBCodido_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarCodigo(TBCodido.Text);
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarNombre(TBNombre.Text);
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarApellido(TBApellido.Text);
        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarDireccion(TBDireccion.Text);
        }

        private void TBCiudad_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarCiudad(TBCiudad.Text);
        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.BuscarTelefono(TBTelefono.Text);
        }

        private void FProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.MostrarDatos();
        }

        private void TBCodido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBNombre.Focus();
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBApellido.Focus();
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBDireccion.Focus();
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBCiudad.Focus();
            }
        }

        private void TBCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TBTelefono.Focus();
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BAgregar.Focus();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            FAgregarprov FAP = new FAgregarprov();
            FAP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FProveedores_FormClosed);
            FAP.Show();

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVProveedores.CurrentRow;
            string codigo = Convert.ToString(FILA.Cells[0].Value);

            FModificarprov FMP = new FModificarprov(codigo);

            FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FProveedores_FormClosed);
            FMP.Show();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Repuesta = MessageBox.Show("Quiere Eliminar El Proveedor?", "Borrar El Proveedor", MessageBoxButtons.YesNo);
            if (Repuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVProveedores.CurrentRow;
                string Codigo = Convert.ToString(FILA.Cells[0].Value);
                DatosProveedores.EliminarProveedor(Codigo);
                MessageBox.Show("SE HA BORRADO EL PROVEEDOR" + TBNombre.Text+ " "+ TBApellido.Text, "REGISTRO ELIMINADO");
                DatosProveedores.MostrarDatos();
            }

        }

        private void FProveedores_Load(object sender, EventArgs e)
        {
            DGVProveedores.DataSource = DatosProveedores.MostrarDatos();
        }
    }
}
