using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MET01.UI.Modelo;
using MET01.UI.Clases;
using Microsoft.Reporting.WinForms;
using MET01.DO.DATA;

namespace MET01.UI.Formularios
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            Reporte objServicio = new Reporte();
            List<Reporte> servicio = objServicio.infoReporte();            

            try
            {
                this.rpvreportegeneral.LocalReport.ReportPath = @"..\..\Reportes\RptReporteGeneral.rdlc";
                this.rpvreportegeneral.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("dts_reporte", servicio);                
                this.rpvreportegeneral.LocalReport.DataSources.Add(ds);                
                this.rpvreportegeneral.LocalReport.Refresh();
                this.rpvreportegeneral.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Referencia: " + ex.ToString());
            }
            
        }


    }
}
