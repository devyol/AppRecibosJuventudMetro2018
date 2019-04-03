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
    public partial class frmRecibo : Form
    {

        public decimal id { get; set; }
        public decimal tipoRecibo { get; set; }       

        private void obtenerCorrelativoVPImpresion()
        {
            Recibo obtner = new Recibo();
            Mensaje<Recibo> resp = obtner.obtenerCorrelativoVistaPrevia();
            Global.correlativoActual = resp.data.recibo;
        }

        private void llenarCamposIglesia()
        {
            if (this.tipoRecibo == 1)
            {
                this.lblrecibooficina.Visible = false;
                this.txtReciboOficina.Visible = false;
            }
            Iglesia llenar = new Iglesia();
            llenar.idIglesia = this.id;
            Mensaje<Iglesia> datos = llenar.datosiglesia();

            if (datos.data.region == 0)
            {
                lbladvertencia.Visible = true;
            }
            else
            {
                lbladvertencia.Visible = false;
            }

            this.txtregion.Text = datos.data.region.ToString();
            this.txtpastor.Text = datos.data.nombre_pastor;
            this.txtencargado.Text = datos.data.nombre_encargado;
            this.txttelefono.Text = datos.data.telefono_encargado;
            this.txtnombreiglesia.Text = datos.data.nombre;
            this.txtiglesia.Text = datos.data.idIglesia.ToString();
            this.txtnombre.Text = datos.data.nombre;
            this.txtconcepto.Text = Global.eventoNombre;
        }

        private void actualizarDatosIglesia()
        {
            if (string.IsNullOrWhiteSpace(txtregion.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Region");
            }
            else if (string.IsNullOrWhiteSpace(txtpastor.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Pastor");
            }
            else if (string.IsNullOrWhiteSpace(txtencargado.Text))
	        {
                MessageBox.Show("Colocar un Dato en el campo de: Encargado");
            }
            else if (string.IsNullOrWhiteSpace(txttelefono.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Telefono de Encargado");
            }
            else if (string.IsNullOrWhiteSpace(txtnombreiglesia.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Nombre de la Iglesia");
            }
            else
            {
                Iglesia actualizar = new Iglesia();
                actualizar.idIglesia = Convert.ToDecimal(txtiglesia.Text);
                actualizar.region = Convert.ToDecimal(txtregion.Text);
                actualizar.nombre_pastor = txtpastor.Text;
                actualizar.nombre_encargado = txtencargado.Text;
                actualizar.telefono_encargado = txttelefono.Text;
                actualizar.nombre = txtnombreiglesia.Text;

                Mensaje<Iglesia> respuesta = actualizar.actualizarDatosIglesia();

                if (respuesta.codigo != 0)
                {
                    MessageBox.Show(respuesta.mensaje);
                }
                else if (respuesta.codigo == 0)
                {
                    MessageBox.Show(respuesta.mensaje);
                    llenarCamposIglesia();
                }
            }
        }

        private void mostrarVistaPrevia()
        {
            frmVistaPrevia nfvp = new frmVistaPrevia();
            nfvp.recibo = Global.correlativoActual;
            this.Hide();
            nfvp.ShowDialog();
            this.Close();
        }

        private void guardarRecibo()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Recibimos de");
            }
            else if (string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Cantidad");
            }
            else if (string.IsNullOrWhiteSpace(txtconcepto.Text))
            {
                MessageBox.Show("Colocar un Dato en el campo de: Concepto");
            }
            else
            {
                if (this.tipoRecibo == 1)
                {
                    Recibo guardar = new Recibo();
                    guardar.idEvento = Convert.ToDecimal(txtiglesia.Text);
                    guardar.idIglesia = Convert.ToDecimal(this.id);
                    guardar.nombre = txtnombre.Text;
                    guardar.cantidad = Convert.ToDecimal(txtcantidad.Text);
                    guardar.conceptoRecibo = txtconcepto.Text;
                    Mensaje<Recibo> resultado = guardar.registrarRecibo();

                    if (resultado.codigo != 0)
                    {
                        MessageBox.Show(resultado.mensaje);
                    }
                    else
                    {
                        mostrarVistaPrevia();
                    }
                }
                else if (this.tipoRecibo == 2)
                {
                    if (string.IsNullOrWhiteSpace(txtReciboOficina.Text))
                    {
                        MessageBox.Show("Colocar un Dato en el campo de: Recibo de Oficina");
                    }
                    else
                    {
                        ReciboOficina guardar = new ReciboOficina();
                        guardar.idEvento = Convert.ToDecimal(txtiglesia.Text);
                        guardar.idIglesia = Convert.ToDecimal(this.id);
                        guardar.nombre = txtnombre.Text;
                        guardar.cantidad = Convert.ToDecimal(txtcantidad.Text);
                        guardar.conceptoRecibo = txtconcepto.Text;
                        guardar.reciboOficina = txtReciboOficina.Text;
                        Mensaje<ReciboOficina> resultado = guardar.registrarReciboOficina();

                        if (resultado.codigo != 0)
                        {
                            MessageBox.Show(resultado.mensaje);
                        }
                        else
                        {
                            mostrarVistaPrevia();
                        }
                    }
                }
            }
        }
        
        public frmRecibo()
        {
            InitializeComponent();
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {
            llenarCamposIglesia();
            txtcantidad.Focus();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmListadoIglesias p = new frmListadoIglesias();
            p.ShowDialog();
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            obtenerCorrelativoVPImpresion();
            guardarRecibo();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizarDatosIglesia();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtcantidad);
        }

        private void txtregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.soloNumeros(e);
        }
        
    }
}
