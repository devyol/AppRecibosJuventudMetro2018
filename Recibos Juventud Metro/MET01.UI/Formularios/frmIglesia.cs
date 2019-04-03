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
    public partial class frmIglesia : Form
    {

        #region Metodos Publicos

        public void comboRegiones()
        {
            Modelo.Region lista = new Modelo.Region();
            Mensaje<List<Modelo.Region>> resp = lista.listaRegiones();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                cbxregion.DisplayMember = "nombre";
                cbxregion.ValueMember = "region";
                cbxregion.DataSource = resp.data;
                if (cbxregion.Items.Count > 0)
                {
                    cbxregion.SelectedIndex = -1;
                }
            }

        }

        public void salir()
        {
            this.Hide();
            frmListadoIglesias regresar = new frmListadoIglesias();
            regresar.ShowDialog();
            this.Close();
        }

        public void nuevaIglesia()
        {
            if (string.IsNullOrWhiteSpace(txtpastor.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Pastor");
            }
            else if (string.IsNullOrWhiteSpace(txtencargado.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Encargado");
            }
            else if (string.IsNullOrWhiteSpace(txttelefonoencargado.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Telefono de Encargado");
            }
            else if (cbxregion.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una Region para la iglesia");
            }
            else if (string.IsNullOrWhiteSpace(txtiglesia.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Nombre de la Iglesia");
            }
            else
            {
                Iglesia nueva = new Iglesia();
                nueva.nombre_pastor = txtpastor.Text;
                nueva.nombre_encargado = txtencargado.Text;
                nueva.telefono_encargado = txttelefonoencargado.Text;
                nueva.region = Convert.ToDecimal(cbxregion.SelectedValue);
                nueva.nombre = txtiglesia.Text;

                Mensaje<Iglesia> resultado = nueva.agregarNuevaIglesia();

                if (resultado.codigo != 0)
                {
                    MessageBox.Show(resultado.mensaje);
                }
                else
                {
                    MessageBox.Show(resultado.mensaje);
                    this.Hide();
                    frmListadoIglesias regresarListado = new frmListadoIglesias();
                    regresarListado.ShowDialog();
                    this.Close();
                }
            }
        }

        #endregion

        public frmIglesia()
        {
            InitializeComponent();
        }

        private void frmIglesia_Load(object sender, EventArgs e)
        {
            comboRegiones();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            nuevaIglesia();
        }
    }
}
