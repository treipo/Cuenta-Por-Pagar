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
    public partial class FMenupri : Form
    {
        public FMenupri()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProveedores FPR = new FProveedores();
            FPR.Show();
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEstado_De_Cuenta FEC = new FEstado_De_Cuenta();
            FEC.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FFacturas FF = new FFacturas();
            FF.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCheques FC = new FCheques();
            FC.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
