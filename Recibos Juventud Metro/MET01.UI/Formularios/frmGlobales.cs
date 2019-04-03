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
using MET01.DO.DATA;

namespace MET01.UI.Formularios
{
    public partial class frmGlobales : Form
    {

        private void llenarcomboEvento()
        {
            Evento eventos = new Evento();
            Mensaje<List<MET01_EVENTO>> resp = eventos.listarEventosActivos();

            cbxevento.DisplayMember = "nombre";
            cbxevento.ValueMember = "evento";
            cbxevento.DataSource = resp.data;

            if (cbxevento.Items.Count > 0)
            {
                cbxevento.SelectedIndex = -1;
            }
        }

        private void llenarcomboUsuario()
        {
            Usuario eventos = new Usuario();
            Mensaje<List<MET01_USUARIO>> resp = eventos.listarUsuariosActivos();

            cbxusuario.DisplayMember = "nombre";
            cbxusuario.ValueMember = "usuario";
            cbxusuario.DataSource = resp.data;

            if (cbxusuario.Items.Count > 0)
            {
                cbxusuario.SelectedIndex = -1;
            }
        }

        private void datosGlobales()
        {
            if (this.cbxevento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Evento para iniciar la Gestion de Recibos");
            }
            else if (this.cbxusuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Usuario para iniciar la Gestion de Recibos");
            }
            else
            {
                this.Hide();
                Global.usuario = this.cbxusuario.SelectedValue.ToString().ToUpper();
                Global.evento = Convert.ToDecimal(this.cbxevento.SelectedValue);
                Global.eventoNombre = this.cbxevento.Text;                
                frmListadoIglesias re = new frmListadoIglesias();
                re.ShowDialog();
                this.Close();
            }
        }

        public frmGlobales()
        {
            InitializeComponent();
        }



        private void btnaceptar_Click(object sender, EventArgs e)
        {
            datosGlobales();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal p = new frmPrincipal();
            p.ShowDialog();
            this.Close();
        }

        private void frmGlobales_Load(object sender, EventArgs e)
        {
            llenarcomboEvento();
            llenarcomboUsuario();

        }
    }
}
