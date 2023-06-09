﻿using System;
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
        public string _Id { get; set; }
        public string _Documento { get; set; }
        public string _Nombre { get; set; }
        public string _Apellido { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }
        public string _Email { get; set; }
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();

        public bool GuardarCliente(TextBox TxtNumeroDocumento, TextBox TxtNombre, TextBox TxtApellido, TextBox TxtDireccion, TextBox TxtTelefono, TextBox TxtEmail)
        {
            bool Guardar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("INSERT INTO CLIENTE (DOCUMENTO, NOMBRE, APELLIDO, DIRECCION, TELEFONO, EMAIL) VALUES (@DOCUMENTO, @NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EMAIL)", System.Data.CommandType.Text);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, TxtNumeroDocumento.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.AddParameters("@APELLIDO", SqlDbType.VarChar, TxtApellido.Text);
                bd.AddParameters("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                bd.AddParameters("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.AddParameters("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
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
        public bool EditarCliente(int id, TextBox TxtNumeroDocumento, TextBox TxtNombre, TextBox TxtApellido, TextBox TxtDireccion, TextBox TxtTelefono, TextBox TxtEmail)
        {
            bool Editar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("UPDATE CLIENTE SET [DOCUMENTO]=@DOCUMENTO, [NOMBRE]=@NOMBRE , [APELLIDO]=@APELLIDO , [DIRECCION]=@DIRECCION , [TELEFONO]=@TELEFONO, [EMAIL]=@EMAIL WHERE [ID]=@ID",System.Data.CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                bd.AddParameters("@DOCUMENTO", SqlDbType.BigInt, TxtNumeroDocumento.Text);
                bd.AddParameters("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.AddParameters("@APELLIDO", SqlDbType.VarChar, TxtApellido.Text);
                bd.AddParameters("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                bd.AddParameters("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.AddParameters("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
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
        public void ConsultarListaCliente(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("SELECT * FROM CLIENTE WHERE ESTADO = 1 ORDER BY ID DESC");
            Dg.Load(DgDatos);
        }

        public void BuscarCliente(DataGridView DgDatos, TextBox TxtBuscarCliente)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("SELECT * FROM CLIENTE WHERE DOCUMENTO LIKE '%" + TxtBuscarCliente.Text + "%' OR NOMBRE LIKE '%" + TxtBuscarCliente.Text + "%' OR APELLIDO LIKE '%" + TxtBuscarCliente.Text + "%' ORDER BY ID DESC");
            Dg.Load(DgDatos);
        }
        public bool BuscarCliente(int id)
        {
            bool Consultar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("SELECT * FROM CLIENTE WHERE ID = '" + id + "';", CommandType.Text);
                bd.AddParameters("@ID", SqlDbType.BigInt, id);
                SqlDataReader dr;
                dr = bd.ExecuteReader();
                if (dr.Read())
                {
                    _Documento = Convert.ToString(dr["DOCUMENTO"]);
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    _Apellido = Convert.ToString(dr["APELLIDO"]);
                    _Direccion = Convert.ToString(dr["DIRECCION"]);
                    _Telefono = Convert.ToString(dr["TELEFONO"]);
                    _Email = Convert.ToString(dr["EMAIL"]);
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
                bd.CreateCommand("UPDATE CLIENTE SET [ESTADO]=@ESTADO WHERE [ID]=@ID", System.Data.CommandType.Text);
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
