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
    public partial class FEstado_De_Cuenta : Form
    {
        public FEstado_De_Cuenta()

        {
            InitializeComponent();
        }

        private void FEstado_De_Cuenta_Load(object sender, EventArgs e)
        {
            DGVEstadoCuenta.DataSource = DatosEstadoDeCuenta.MostarEstado();
        }

        private void TBCodigoP_TextChanged(object sender, EventArgs e)
        {
            DGVEstadoCuenta.DataSource = DatosEstadoDeCuenta.BuscarCodigo(TBCodigoP.Text);
        }

        private void TBNumeroF_TextChanged(object sender, EventArgs e)
        {
            DGVEstadoCuenta.DataSource = DatosEstadoDeCuenta.BuscarNumeroFactura(int.Parse(TBNumeroF.Text));
        }

        private void BVTodo_Click(object sender, EventArgs e)
        {
            DGVEstadoCuenta.DataSource = DatosEstadoDeCuenta.MostarEstado();
        }

        private void TBCodigoP_KeyPress(object sender, KeyPressEventArgs e)
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
                BVTodo.Focus();
            }
        }
    }
}
