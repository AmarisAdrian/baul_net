
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
    public class ListaPrecio
    {
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }
        DataBase bd = new DataBase();
        public bool GuardarListaPrecio(RichTextBox RTxtInformacion,DateTimePicker DtFechaInicio, DateTimePicker DtFechaFin,CheckBox ChkEstado)
        {
            bool Guardar = false;
            try
            {
                bd.Connect();
                bd.CreateCommand("INSERT INTO LISTA_PRECIO (INFORMACION, FECHA_INICIO, FECHA_FIN, ESTADO) VALUES (@INFORMACION, @FECHA_INICIO, @FECHA_FIN, @ESTADO)", System.Data.CommandType.Text);
                bd.AddParameters("@INFORMACION", SqlDbType.VarChar, RTxtInformacion.Text);
                bd.AddParameters("@FECHA_INICIO", SqlDbType.DateTime, DtFechaInicio.Value);
                bd.AddParameters("@FECHA_FIN", SqlDbType.DateTime, DtFechaFin.Value);
                bd.AddParameters("@ESTADO", SqlDbType.Bit, ChkEstado.Checked);

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
        public void ConsultarListaPrecio(DataGridView DgDatos)
        {
            CargarDataGrid Dg = new CargarDataGrid();
            DgDatos.DataSource = null;
            Dg.Ready("select * from lista_precio");
            Dg.Load(DgDatos);
        }

        
    }
}
