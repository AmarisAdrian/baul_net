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
    public class Usuario
    {
        Validacion validacion = new Validacion();
        public string _Id { get; set; }
        public string _Documento { get; set; }
        public string _Nombre { get; set; }
        public string _Apellido { get; set; }
        public string _Telefono { get; set; }
        public string _Email { get; set; }
        public string _IdTipoUsuario { get; set; }
        public string _IdEstadoUsuario { get; set; }
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();

        public bool GuardarUsuario(TextBox TxtNumeroDocumento, TextBox TxtNombre, TextBox TxtApellido, TextBox TxtTelefono, TextBox TxtEmail, ComboBox CmbTipoUsuario, ComboBox CmbEstadoUsuario)
        {
            bool Guardar = false;
            try
            {
                string pass = validacion.EncriptarPassword(TxtNumeroDocumento);

                bd.Connect();
                bd.CreateCommand("INSERT INTO USUARIO (DOCUMENTO, PASSWORD, NOMBRE, APELLIDO, TELEFONO, EMAIL, ID_TIPO_USUARIO, ID_ESTADO_USUARIO) VALUES (@DOCUMENTO, @PASSWORD, @NOMBRE, @APELLIDO, @TELEFONO, @EMAIL, @ID_TIPO_USUARIO, @ID_ESTADO_USUARIO)", System.Data.CommandType.Text);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, TxtNumeroDocumento.Text);
                bd.AddParameters("@PASSWORD", SqlDbType.NVarChar, pass);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.AddParameters("@APELLIDO", SqlDbType.VarChar, TxtApellido.Text);
                bd.AddParameters("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.AddParameters("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.AddParameters("@ID_TIPO_USUARIO", SqlDbType.Int, CmbTipoUsuario.SelectedValue);
                bd.AddParameters("@ID_ESTADO_USUARIO", SqlDbType.Int, CmbEstadoUsuario.SelectedValue);

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
        public bool EditarUsuario(int id, TextBox TxtNumeroDocumento, TextBox TxtNombre, TextBox TxtApellido, TextBox TxtTelefono, TextBox TxtEmail, ComboBox CmbTipoUsuario, ComboBox CmbEstadoUsuario)
        {
            bool Editar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE USUARIO SET [DOCUMENTO]=@DOCUMENTO, [NOMBRE]=@NOMBRE , [APELLIDO]=@APELLIDO , [TELEFONO]=@TELEFONO, [EMAIL]=@EMAIL, [ID_TIPO_USUARIO]=@ID_TIPO_USUARIO, [ID_ESTADO_USUARIO]=@ID_ESTADO_USUARIO WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, TxtNumeroDocumento.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.AddParameters("@APELLIDO", SqlDbType.VarChar, TxtApellido.Text);
                bd.AddParameters("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.AddParameters("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.AddParameters("@ID_TIPO_USUARIO", SqlDbType.Int, CmbTipoUsuario.SelectedValue);
                bd.AddParameters("@ID_ESTADO_USUARIO", SqlDbType.Int, CmbEstadoUsuario.SelectedValue);
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
        public void ConsultarListaUsuario(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("lista_ususario");
            Dg.Load(DgDatos);
        }
        public void BuscarUsuario(DataGridView DgDatos, TextBox TxtBuscarUsuario)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("buscar_usuario'" + TxtBuscarUsuario.Text + "'");
            Dg.Load(DgDatos);
        }
        public bool BuscarUsuario(int id)
        {
            bool Consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT * FROM USUARIO WHERE ID = '" + id + "';", CommandType.Text);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, id);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                if (dr.Read())
                {
                    _Documento = Convert.ToString(dr["DOCUMENTO"]);
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    _Apellido = Convert.ToString(dr["APELLIDO"]);
                    _Telefono = Convert.ToString(dr["TELEFONO"]);
                    _Email = Convert.ToString(dr["EMAIL"]);
                    _IdTipoUsuario = Convert.ToString(dr["ID_TIPO_USUARIO"]);
                    _IdEstadoUsuario = Convert.ToString(dr["ID_ESTADO_USUARIO"]);
                    Consultar = true;
                }
                else
                {
                    Consultar = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.CleanParameters(); bd.Disconnect(); }
            return Consultar;
        }
        public bool CambiarEstado(bool estado, string id)
        {
            bool edit = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE USUARIO SET [ID_ESTADO_USUARIO]=@ID_ESTADO_USUARIO WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@ID_ESTADO_USUARIO", SqlDbType.Bit, estado);
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
        public bool CambiarTipo(bool estado, string id)
        {
            bool edit = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE USUARIO SET [ID_TIPO_USUARIO]=@ID_TIPO_USUARIO WHERE [ID]=@ID", System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@ID_TIPO_USUARIO", SqlDbType.Int, estado);
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
