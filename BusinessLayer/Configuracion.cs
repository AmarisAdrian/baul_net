using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class Configuracion
    {
        public string _Id { get; set; }
        public string _Nombre { get; set; }
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();
        Validacion validacion = new Validacion();

        public void ConsultarListaMotivo(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("SELECT * FROM MOTIVO_PRODUCTO");
            Dg.Load(DgDatos);
        }
        public bool GuardarMotivo(TextBox TxtNombre)
        {
            bool Guardar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("INSERT INTO MOTIVO_PRODUCTO (NOMBRE) VALUES (@NOMBRE)", System.Data.CommandType.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);

                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    Guardar = true;
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
            return Guardar;
        }
        public bool EditarMotivo(int id, TextBox TxtNombre)
        {
            bool Editar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE MOTIVO_PRODUCTO SET [NOMBRE]=@NOMBRE WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    Editar = true;
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
            return Editar;
        }
        public bool CambiarEstado(bool estado, string id)
        {
            bool edit = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE MOTIVO_PRODUCTO SET [ESTADO]=@ESTADO WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@ESTADO", SqlDbType.Bit, estado);
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
        public bool BuscarMotivo(int id)
        {
            bool consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT * FROM MOTIVO_PRODUCTO WHERE ID='" + id + "';", CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                if (dr.Read())
                {
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
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
        public void ConsultarListaTalla(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("SELECT * FROM TALLA");
            Dg.Load(DgDatos);
        }
        public bool GuardarTalla(TextBox TxtNombre)
        {
            bool Guardar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("INSERT INTO TALLA (NOMBRE) VALUES (@NOMBRE)", System.Data.CommandType.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);

                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    Guardar = true;
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
            return Guardar;
        }
        public bool EditarTalla(int id, TextBox TxtNombre)
        {
            bool Editar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE TALLA SET [NOMBRE]=@NOMBRE WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                int reg = 0;
                reg = bd.ExecuteCommand();
                if (reg > 0)
                {
                    Editar = true;
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
            return Editar;
        }
        public bool CambiarEstadoTalla(bool estado, string id)
        {
            bool edit = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE TALLA SET [ESTADO]=@ESTADO WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@ESTADO", SqlDbType.Bit, estado);
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
