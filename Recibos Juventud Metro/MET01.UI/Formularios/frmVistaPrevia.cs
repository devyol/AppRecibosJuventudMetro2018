using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MET01.UI.Clases;
using MET01.UI.Modelo;

namespace MET01.UI.Formularios
{
    public partial class frmVistaPrevia : Form
    {
        public decimal? recibo { get; set; }

        public frmVistaPrevia()
        {
            InitializeComponent();
        }

        private void frmVistaPrevia_Load(object sender, EventArgs e)
        {
            Recibo objServicio = new Recibo();
            objServicio.recibo = this.recibo;
            List<Recibo> servicio = objServicio.datosRecibo();

            try
            {
                this.rptdiseno.LocalReport.ReportPath = @"..\..\Reportes\RptImpresionRecibo.rdlc";
                this.rptdiseno.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                this.rptdiseno.LocalReport.DataSources.Add(ds);
                this.rptdiseno.LocalReport.Refresh();
                this.rptdiseno.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Referencia: " + ex.ToString());
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {            
            frmListadoIglesias nre = new frmListadoIglesias();
            this.Hide();
            nre.ShowDialog();
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Recibo objServicio = new Recibo();
            objServicio.recibo = this.recibo;
            List<Recibo> servicio = objServicio.datosRecibo();

            try
            {
                //MUESTRA LA VISTA PREVIA DEL REPORTE
                LocalReport rdlc = new LocalReport();
                rdlc.ReportPath = @"..\..\Reportes\RptImpresionRecibo.rdlc";
                rdlc.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                rdlc.DataSources.Add(ds);
                //ENVIA EL REPORTE A LA IMPRESORA
                impresor imp = new impresor();
                imp.Imprime(rdlc);
                //SE CIERRA VENTANA DE VISTA PREVIA Y SE HABRE LA PANTALLA DEL MENU PRINCIPAL
                frmListadoIglesias nre = new frmListadoIglesias();
                this.Hide();
                nre.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Referencia: " + ex.ToString());
            }
        }
    }
}
