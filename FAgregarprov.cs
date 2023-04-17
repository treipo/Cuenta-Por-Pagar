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
    public partial class FAgregarprov : Form
    {
        public FAgregarprov()
        {
            InitializeComponent();
        }
        private void FAgregarprov_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosProveedores.MostrarDatos();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            try
            {
              DatosProveedores.InsertarProveedor
               (TBCodido.Text, TBNombre.Text, TBApellido.Text, TBDireccion.Text, TBCiudad.Text, TBTelefono.Text);
                MessageBox.Show("EL Proveedor" + " " + TBNombre.Text + " " + TBApellido.Text + " " + "HASIDO AGREGADO", "AGREGAR PROVEEDOR");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR No Se pudo Agregar Intente De Nuevo");
                BAgregar.Focus();
            }
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
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TBTelefono.Focus();
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BAgregar.Focus();
            }
        }
    }
}
