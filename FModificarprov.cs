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
    public partial class FModificarprov : Form
    {
        private string Codigo;
        public FModificarprov(string CodigoProveedor)
        {
            InitializeComponent();
            Codigo = CodigoProveedor;
        }

        

        private void FModificarprov_Load(object sender, EventArgs e)
        {
            PROVEEDORESvictorP Prov = DatosProveedores.Cargar(Codigo);
            TBCodido.Text = Prov.CODIGO;
            TBCodido.Enabled = false;
            TBNombre.Text = Prov.NOMBRES;
            TBApellido.Text = Prov.APELLIDOS;
            TBDireccion.Text = Prov.DIRECCION;
            TBCiudad.Text = Prov.CIUDAD;
            TBTelefono.Text = Prov.TELEFONO;
        }

        private void FModificarprov_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosProveedores.MostrarDatos();
        }
        private void BAtualizar_Click(object sender, EventArgs e)
        {
          DatosProveedores.ModificarProveedor(TBCodido.Text,TBNombre.Text,TBApellido.Text,TBDireccion.Text, TBCiudad.Text, TBTelefono.Text);
            MessageBox.Show("EL REGISTRO SE MODIFICÓ EXITOSAMENTE.", "MODIFICAR");
            Close();
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
                BAtualizar.Focus();
            }
        }
    }
    
}
