using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Cliente
    {
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();
        
        public bool Conectar()
        {
            bool sw = false;
            try
            {
                bd.Connect();
                sw = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sw;
        }

        public bool GuardarCliente(TextBox TxtNumeroDocumento, TextBox TxtNombre, TextBox TxtApellido, TextBox TxtDireccion, TextBox TxtTelefono, TextBox TxtEmail)
        {
            bool Guardar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("INSERT INTO CLIENTE (DOCUMENTO, NOMBRE, APELLIDO, DIRECCION, TELEFONO, EMAIL) VALUES (@DOCUMENTO, @NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EMAIL)",System.Data.CommandType.Text);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, TxtNumeroDocumento.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.AddParameters("@APELLIDO", SqlDbType.VarChar, TxtApellido.Text);
                bd.AddParameters("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                bd.AddParameters("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.AddParameters("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                int reg = 0;
                reg = bd.ExecuteCommand();
                if(reg > 0)
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
    }
}
