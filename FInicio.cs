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
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
        }
        private void BEntrada_Click(object sender, EventArgs e)
            
        {
            try
            {
                DataGridViewRow fila = DGVUsuario.CurrentRow;
                string Usuario = Convert.ToString(fila.Cells[0].Value);
                string Clave = Convert.ToString(fila.Cells[1].Value);
                if (TUsuario.Text == Usuario & TClave.Text == Clave)
                {
                    FMenupri FP = new FMenupri();
                    FP.Show();
                }
                else
                {
                    MessageBox.Show("Debes De Ingreasar El Nombre Del Usuario Y Contraseña Que Sea Valida");
                    TUsuario.Focus();
                }
            }
             catch
            {
                 MessageBox.Show("El Nombre Del Usuario O Contraseña Es Incorrectas");
                TUsuario.Focus();
            }
        }
    
        private void TUsuario_TextChanged(object sender, EventArgs e)
        {
            DGVUsuario.DataSource = DatosUsuario.BuscarUsuario(TUsuario.Text);
        }

        private void TClave_TextChanged(object sender, EventArgs e)
        {
            DGVUsuario.DataSource = DatosUsuario.BuscarClave(TClave.Text);
        }

        private void FInicio_Load(object sender, EventArgs e)
        {
            DGVUsuario.DataSource = DatosUsuario.Mostrar();
            DGVUsuario.Columns[1].Visible = false;
            TClave.PasswordChar = '$';
        }

        private void TUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TClave.Focus();
            }
        }
        private void TClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BEntrada.Focus();
            }
        }
    }
}
