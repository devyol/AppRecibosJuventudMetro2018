using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET01.UI.Clases
{
    public static class Global
    {
        public static string usuario { get; set; }
        public static decimal evento { get; set; }
        public static string eventoNombre { get; set; }
        public static decimal? correlativoActual { get; set; }

        public static void NumeroDecimal(KeyPressEventArgs e, TextBox te)
        {
            char tecla = e.KeyChar;
            if (te.Text.Contains("."))
            {
                if (Char.IsDigit(tecla) || tecla == 8)
                {
                    e.Handled = false;//No se bloque el evento
                }
                else
                {
                    e.Handled = true;//Se bloquea el evento
                }
            }
            else
            {
                if (Char.IsDigit(tecla) || tecla == 8 || tecla == 46)
                {
                    e.Handled = false;//No se bloque el evento
                }
                else
                {
                    e.Handled = true;//Se bloquea el evento
                }
            }

        }

        public static void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
