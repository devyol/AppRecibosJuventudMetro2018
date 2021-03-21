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
    public partial class frmEventos : Form
    {

        #region Metodos Privados

        private void limpiar()
        {
            txtnombre.Text = "";
            if (cbxestado.Items.Count > 0)
            {
                cbxestado.SelectedIndex = -1;
            }

        }

        private void cargarGridEventos()
        {
            Evento list = new Evento();
            Mensaje<List<MET01_EVENTO>> resp = list.listarTodoseEventos();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                bindingSource1.DataSource = resp.data;
            }
        }

        private void obtenerUnEvento(MET01_EVENTO ev)
        {
            Evento obj = new Evento();
            Mensaje<MET01_EVENTO> resp = obj.obtenerEvento(ev);

            descripcionEstado();
            txtnombre.Text = resp.data.NOMBRE;
            cbxestado.SelectedValue = resp.data.ESTADO_REGISTRO.ToString();
        }

        private void descripcionEstado()
        {
            Evento lis = new Evento();
            Mensaje<List<MET01_ESTADO>> resp = lis.listaDescripcionEstado();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                cbxestado.DisplayMember = "descripcion";
                cbxestado.ValueMember = "estado";
                cbxestado.DataSource = resp.data;
                if (cbxestado.Items.Count > 0)
                {
                    cbxestado.SelectedIndex = -1;
                }
            }
        }

        private void registrarEvento()
        {
            if (txtnombre.Text.Trim() == "" || txtnombre.Text.Trim() == null)
            {
                MessageBox.Show("El dato del Nombre del Evento esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL EVENTO que requiere registrar esta vacio, favor de seleccionar un estado para registrar");
            }
            else
            {
                MET01_EVENTO obj = new MET01_EVENTO();
                obj.NOMBRE = txtnombre.Text.ToString();
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Evento reg = new Evento();
                Mensaje<Evento> resp = reg.RegistrarEvento(obj);
                MessageBox.Show(resp.mensaje);
                limpiar();
            }
        }

        private void actualizarRegistroEvento()
        {
            if (txtnombre.Text.Trim() == "" || txtnombre.Text.Trim() == null)
            {
                MessageBox.Show("El dato del Nombre del Evento esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL EVENTO que requiere actualizar esta vacio, favor de seleccionar un estado para modificar");
            }
            else
            {
                MET01_EVENTO obj = new MET01_EVENTO();
                obj.EVENTO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obj.NOMBRE = txtnombre.Text.ToString();
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Evento reg = new Evento();
                Mensaje<Evento> resp = reg.ActualizarRegistroEvento(obj);
                MessageBox.Show(resp.mensaje);
            }
        }

        #endregion

        #region Metodos Publicos

        public void salir()
        {
            this.Hide();
            frmPrincipal p = new frmPrincipal();
            p.ShowDialog();
            this.Close();
        }

        #endregion

        public frmEventos()
        {
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarGridEventos();
            descripcionEstado();
            btnmodificar.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            btnagregar.Visible = true;
            txtnombre.Focus();
            btnlimpiar.Text = "Limpiar";
            limpiar();
        }

        private void dtglistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                MET01_EVENTO obj = new MET01_EVENTO();
                obj.EVENTO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obtenerUnEvento(obj);
                btnagregar.Visible = false;
                btnmodificar.Enabled = true;
                btnlimpiar.Text = "Registrar Nuevo";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            registrarEvento();
            cargarGridEventos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            actualizarRegistroEvento();
            cargarGridEventos();
        }


    }
}
