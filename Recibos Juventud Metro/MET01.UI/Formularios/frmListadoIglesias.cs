using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MET01.UI.Clases;
using MET01.UI.Modelo;

namespace MET01.UI.Formularios
{
    public partial class frmListadoIglesias : Form
    {

        #region Metodos Publicos

        private void llenarlistadoIglesias()
        {
            Iglesia listar = new Iglesia();
            Mensaje<List<Iglesia>> respuesta = listar.llenarGridIglesias();

            if (respuesta.codigo != 0)
            {
                MessageBox.Show(respuesta.mensaje);
            }
            else
            {
                bsiglesias.DataSource = respuesta.data;
            }

        }

        private void buscarIglesia()
        {
            if (string.IsNullOrWhiteSpace(txtiglesia.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Iglesia");
            }
            else
            {
                Iglesia busqueda = new Iglesia();
                Mensaje<List<Iglesia>> respuesta = busqueda.busquedaIglesia(txtiglesia.Text.ToString());

                bsiglesias.DataSource = respuesta.data;
            }
        }

        private void llenarlistadoRecibos()
        {
            Recibo listar = new Recibo();
            Mensaje<List<Recibo>> respuesta = listar.listarRecibos();

            bsRecibos.DataSource = respuesta.data;
        }

        private void nuevaIglesia()
        {
            this.Hide();
            frmIglesia irPantalIglesia = new frmIglesia();
            irPantalIglesia.ShowDialog();
            this.Close();
        }

        private void irGlobales()
        {
            this.Hide();
            frmGlobales iraGloables = new frmGlobales();
            iraGloables.ShowDialog();
            this.Close();
        }

        private void irMenu() 
        {
            this.Hide();
            frmPrincipal iraMenu = new frmPrincipal();
            iraMenu.ShowDialog();
            this.Close();
        }

        private void clickDataGridIglesias(DataGridViewCellEventArgs arg) 
        {
            if (arg.ColumnIndex == 3)//OFRENDA PRESENTADA EL DIA DEL EVENTO
            {
                this.Hide();
                frmRecibo ir = new frmRecibo();
                ir.id = Convert.ToDecimal(dtgIglesias.CurrentRow.Cells[0].Value);//IDENTIFICADOR DE LA IGLESIA
                ir.tipoRecibo = 1;
                ir.ShowDialog();
                this.Close();
            }
            else if (arg.ColumnIndex == 4)//OFRENDA PRESENTADA EN LA OFICINA CENTRAL
            {
                this.Hide();
                frmRecibo ir = new frmRecibo();
                ir.id = Convert.ToDecimal(dtgIglesias.CurrentRow.Cells[0].Value);//IDENTIFICADOR DE LA IGLESIA
                ir.tipoRecibo = 2;
                ir.ShowDialog();
                this.Close();
            }
        }

        private void clickDataGridRecibos(DataGridViewCellEventArgs arg)
        {
            if (arg.ColumnIndex == 6)
            {
                frmVistaPrevia nfvp = new frmVistaPrevia();
                nfvp.recibo = Convert.ToDecimal(dtgRecibos.CurrentRow.Cells[0].Value);
                this.Hide();
                nfvp.ShowDialog();
                this.Close();                
            }
        }

        #endregion

        public frmListadoIglesias()
        {
            InitializeComponent();
        }

        private void frmListadoIglesias_Load(object sender, EventArgs e)
        {
            llenarlistadoIglesias();
            llenarlistadoRecibos();
        }
        
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevaIglesia();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irGlobales();
        }

        private void irAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irMenu();
        }
        
        private void dtgIglesias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDataGridIglesias(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDataGridRecibos(e);
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes rptventana = new frmReportes();
            rptventana.ShowDialog();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarIglesia();
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            llenarlistadoIglesias();
        }
    }
}
