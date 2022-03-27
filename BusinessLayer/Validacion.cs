using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public class Validacion
    {
        public bool ValidarTextbox(GroupBox parent, ErrorProvider ErrorNumeric)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    if (c.Text.Equals(string.Empty))
                    {
                        ErrorNumeric.SetError(c, "Este campo no puede ir vacio");
                        return false;
                    }
                }
                else
                {
                    ErrorNumeric.Clear();
                }
            }
            return true;
        }
        public void LimpiarCampos(Control control, GroupBox gb)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = -1;
                }
                else if (txt is RichTextBox)
                {
                    ((RichTextBox)txt).Clear();

                }
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = -1;
                }
                else if (combo is RichTextBox)
                {
                    ((RichTextBox)combo).Clear();

                }
            }
        }
        public void SoloLetra(KeyPressEventArgs e)
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
        public void SoloNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                   if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                       if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public bool ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool ValidarLetraYnumero(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        public bool ValidarCombo(GroupBox parent, ErrorProvider ErrorNumeric)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType().Equals(typeof(ComboBox)))
                {
                    if (c.Text.Equals(string.Empty))
                    {
                        ErrorNumeric.SetError(c, "Este campo no puede ir vacio");
                        return false;
                    }
                }
                else
                {
                    ErrorNumeric.Clear();
                }
            }
            return true;
        }
        public void ValidarProducto(DataGridView DgCrearProducto,TextBox TxtCodigo, TextBox TxtReferencia, RichTextBox RTxtDescripcion, RichTextBox RTxtDetalleProducto,ComboBox CmbTalla,TextBox TxtCantidad, ComboBox CmbMotivo ,TextBox TxtPieza, ErrorProvider ErrorNumeric)
        {
            int i = 0;
            double Cantidad = 0;
            bool permitir = false;
            while (DgCrearProducto[0,i].Value != null)
            {
                if (Convert.ToString(DgCrearProducto[0, i].Value) == Convert.ToString(TxtCodigo.Text))
                {
                    if (Convert.ToString(DgCrearProducto[4, i].Value) == Convert.ToString("(" + CmbTalla.SelectedValue + ") " + CmbTalla.Text))
                    {
                        if (Convert.ToString(DgCrearProducto[1, i].Value) == Convert.ToString(TxtReferencia.Text) )
                        {
                            if (Convert.ToString(DgCrearProducto[6, i].Value) == Convert.ToString("(" + CmbMotivo.SelectedValue + ") " + CmbMotivo.Text))
                            {
                                if (Convert.ToString(DgCrearProducto[7, i].Value) == Convert.ToString(TxtPieza.Text))
                                {
                                    Cantidad = Convert.ToDouble(DgCrearProducto[5, i].Value) + Convert.ToDouble(TxtCantidad.Text);
                                    DgCrearProducto[5, i].Value = Convert.ToString(Cantidad);
                                    ErrorNumeric.Clear();
                                }
                                else
                                {
                                    ErrorNumeric.SetError(TxtPieza, "No puede agregar el producto, cambió el número de piezas");
                                }
                            }
                            else
                            {
                                ErrorNumeric.SetError(CmbMotivo, "No puede agregar el producto, cambió el motivo");
                            }
                        }
                        else if(Convert.ToString(DgCrearProducto[1, i].Value) != Convert.ToString(TxtReferencia.Text) && Convert.ToString(DgCrearProducto[0, i].Value) == Convert.ToString(TxtCodigo.Text))
                        {
                            ErrorNumeric.SetError(TxtCodigo, "No puede agregar el producto,  el código de barra ya existe");
                        }
                    }
                    else
                    {
                        ErrorNumeric.SetError(TxtCodigo, "No puede agregar el producto, el código de barra ya existe");
                    }
                    permitir = true;
                }
                else
                {
                    permitir = false;
                }
                i++;
            }
            if (permitir == false)
            {
                ErrorNumeric.Clear();
                DgCrearProducto.Rows.Add(TxtCodigo.Text, TxtReferencia.Text, RTxtDescripcion.Text,RTxtDetalleProducto.Text,"("+CmbTalla.SelectedValue +") "+CmbTalla.Text, TxtCantidad.Text, "(" + CmbMotivo.SelectedValue + ") " +CmbMotivo.Text, TxtPieza.Text);
            }
        }
        public void EliminarFilasVacias(DataGridView DgDatos)
        {
            DgDatos.AllowUserToAddRows = false;
            List<DataGridViewRow> rowsDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in DgDatos.Rows)
            {
                bool hascontent = false;
                foreach (DataGridViewColumn col in DgDatos.Columns)
                {
                    if (Convert.ToString(fila.Cells[col.Index].Value) != "")
                    {
                        hascontent = true;
                        break;
                    }
                }
                if (!hascontent)
                {
                    rowsDelete.Add(fila);
                }
            }
            foreach (var item in rowsDelete)
            {
                DgDatos.Rows.Remove(item);
            }
        }
    }
}
