using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class Producto
    {
        public string _Id { get; set; }
        public string _Codigo { get; set; }
        public string _Descripcion { get; set; }
        public string _DetalleProducto { get; set; }
        public string _IdTalla { get; set; }
        public string _Cantidad { get; set; }
        public string _IdMotivo { get; set; }
        public string _Referencia { get; set; }
        public string _Pieza { get; set; }

        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();

        public void ConsultarListaProducto(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("cargar_lista_producto");
            Dg.Load(DgDatos);
        }
        public void BuscarProducto(DataGridView DgDatos, TextBox TxtBuscarProducto)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("buscar_lista_producto'"+ TxtBuscarProducto.Text + "'");
            Dg.Load(DgDatos);
        }
        public bool BuscarProducto(int id)
        {
            bool consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT * FROM PRODUCTO WHERE CODIGO='" + id + "';", CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                if (dr.Read())
                {
                    _Codigo = Convert.ToString(dr["CODIGO"]);
                    _Descripcion = Convert.ToString(dr["DESCRIPCION"]);
                    _DetalleProducto = Convert.ToString(dr["DETALLE_PRODUCTO"]);
                    _IdTalla = Convert.ToString(dr["ID_TALLA"]);
                    _Cantidad = Convert.ToString(dr["CANTIDAD"]);
                    _IdMotivo = Convert.ToString(dr["ID_MOTIVO"]);
                    _Referencia = Convert.ToString(dr["REFERENCIA"]);
                    _Pieza = Convert.ToString(dr["PIEZA"]);
                    consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return consultar;
        }
        public bool GuardarProducto(DataGridView DgCrearProducto)
        {
            bool save = false;
            int i = 0;
            try
            {
                foreach (DataGridViewRow Rows in DgCrearProducto.Rows)
                {
                    string motivo = DgCrearProducto.Rows[i].Cells[6].Value.ToString();
                    motivo = motivo.Replace("(", "").Replace(")", ",");
                    string[] arrayMotivo  = motivo.Split(',');
                    string talla = DgCrearProducto.Rows[i].Cells[4].Value.ToString();
                    talla = talla.Replace("(", "").Replace(")", ",");
                    string[] arrayTalla = talla.Split(',');

                    bd.Connect();
                    bd.CreateCommand("INSERT INTO PRODUCTO (CODIGO,DESCRIPCION,DETALLE_PRODUCTO,ID_TALLA,CANTIDAD,ID_MOTIVO,REFERENCIA,PIEZA)VALUES(@CODIGO,@DESCRIPCION,@DETALLE_PRODUCTO,@ID_TALLA,@CANTIDAD,@ID_MOTIVO,@REFERENCIA,@PIEZA)", System.Data.CommandType.Text);
                    bd.AddParameters("@CODIGO", SqlDbType.BigInt, DgCrearProducto.Rows[i].Cells[0].Value.ToString());
                    bd.AddParameters("@REFERENCIA", SqlDbType.BigInt, DgCrearProducto.Rows[i].Cells[1].Value.ToString());
                    bd.AddParameters("@DESCRIPCION", SqlDbType.VarChar, DgCrearProducto.Rows[i].Cells[2].Value.ToString());
                    bd.AddParameters("@DETALLE_PRODUCTO", SqlDbType.VarChar, DgCrearProducto.Rows[i].Cells[3].Value.ToString());
                    bd.AddParameters("@ID_TALLA", SqlDbType.Int, arrayTalla[0]);
                    bd.AddParameters("@CANTIDAD", SqlDbType.Int, DgCrearProducto.Rows[i].Cells[5].Value.ToString());
                    bd.AddParameters("@ID_MOTIVO", SqlDbType.Int, arrayMotivo[0]);
                    bd.AddParameters("@PIEZA", SqlDbType.Int, DgCrearProducto.Rows[i].Cells[7].Value.ToString());
                    int reg = 0;
                    reg = bd.ExecuteCommand();
                    if (reg > 0)
                    {
                        save = true;
                        i++;
                    }
                    else
                    {
                        _Mensaje = DataBase.MsgBdError;
                        _CodigoError = DataBase.CodeBdError;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return save;
        }
        public bool EditarProducto(TextBox TxtCodigo, TextBox TxtReferencia, RichTextBox RTxtRTxtDescripcion, RichTextBox RTxtDetalleProducto, ComboBox CmbTalla,TextBox TxtCantidad, ComboBox CmbMotivo, TextBox TxtPieza)
        {
            bool edit = false;
            try
            {

                bd.Connect();
                bd.CreateCommand("UPDATE PRODUCTO SET [DESCRIPCION]=@DESCRIPCION, [DETALLE_PRODUCTO]=@DETALLE_PRODUCTO , [ID_TALLA]=@ID_TALLA , [CANTIDAD]=@CANTIDAD , [ID_MOTIVO]=@ID_MOTIVO, [REFERENCIA]=@REFERENCIA, [PIEZA]=@PIEZA WHERE [CODIGO]=@CODIGO", System.Data.CommandType.Text);
                bd.AddParameters("@CODIGO", SqlDbType.BigInt, TxtCodigo.Text);
                bd.AddParameters("@DESCRIPCION", SqlDbType.VarChar, RTxtRTxtDescripcion.Text);
                bd.AddParameters("@DETALLE_PRODUCTO", SqlDbType.VarChar, RTxtDetalleProducto.Text);
                bd.AddParameters("@ID_TALLA", SqlDbType.BigInt, CmbTalla.SelectedValue);
                bd.AddParameters("@CANTIDAD", SqlDbType.BigInt, TxtCantidad.Text);
                bd.AddParameters("@ID_MOTIVO", SqlDbType.BigInt, CmbMotivo.SelectedValue);
                bd.AddParameters("@PIEZA", SqlDbType.BigInt, TxtPieza.Text);
                bd.AddParameters("@REFERENCIA", SqlDbType.BigInt, TxtReferencia.Text);
                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    edit = true;
                }
                else
                {
                    _Mensaje = DataBase.MsgBdError;
                    _CodigoError = DataBase.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return edit;
        }
        public bool BuscarTalla(TextBox TxtReferencia, ComboBox CmbTalla)
        {
            bool consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT ID, NOMBRE FROM TALLA WHERE ID NOT IN (SELECT ID_TALLA AS TALLA FROM PRODUCTO WHERE REFERENCIA" +
                    " = " + TxtReferencia.Text + ");", CommandType.Text);
                bd.AddParameters("@REFERENCIA", SqlDbType.BigInt, TxtReferencia.Text);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToString(CmbTalla.SelectedValue) == Convert.ToString(dr["ID"]))
                    {
                        consultar = true;
                        break;
                    }
                    else
                    {
                        consultar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return consultar;
        }
        public bool BuscarMotivo(TextBox TxtReferencia)
        {
            bool consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT COUNT(*) AS MOTIVO FROM PRODUCTO WHERE REFERENCIA = " + TxtReferencia.Text + " ;", CommandType.Text);
                bd.AddParameters("@REFERENCIA", SqlDbType.BigInt, TxtReferencia.Text);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                if (dr.Read())
                {
                    if (Convert.ToInt32(dr["MOTIVO"]) <= 1)
                    {
                        consultar = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return consultar;
        }
        public bool CambiarEstado(bool estado, string TxtCodigo)
        {
            bool edit = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE PRODUCTO SET [ESTADO]=@ESTADO WHERE [CODIGO]=@CODIGO", System.Data.CommandType.Text);
                bd.AddParameters("@CODIGO", SqlDbType.BigInt, TxtCodigo);
                bd.AddParameters("@ESTADO", SqlDbType.Bit,estado);
                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    edit = true;
                }
                else
                {
                    _Mensaje = DataBase.MsgBdError;
                    _CodigoError = DataBase.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return edit;
        }
    }
}
