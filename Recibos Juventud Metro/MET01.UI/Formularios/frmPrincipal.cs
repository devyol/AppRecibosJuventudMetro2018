using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MET01.UI.Formularios;

namespace MET01.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGlobales g = new frmGlobales();
            g.ShowDialog();
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEventos ev = new frmEventos();
            ev.ShowDialog();
            this.Close();
        }
    }
}
