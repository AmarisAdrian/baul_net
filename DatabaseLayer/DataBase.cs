using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DatabaseLayer
{
    public class DataBase
    {
        SqlConnection cn;
        SqlCommand cmd;
        string conex;
        static int codeBdError;

        public static int CodeBdError
        {
            get { return DataBase.codeBdError; }
            set { DataBase.codeBdError = value; }
        }
        static string msgBdError;
        public static string MsgBdError
        {
            get { return DataBase.msgBdError; }
            set { DataBase.msgBdError = value; }
        }
        public void config()
        {
            string provider = "";
            conex = "";
            try
            {
                conex = ConfigurationManager.ConnectionStrings["conexstring"].ConnectionString;
                provider = ConfigurationManager.ConnectionStrings["conexstring"].ProviderName;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataBase()
        {
            config();
        }
        public void Connect()
        {
            codeBdError = 0;
            msgBdError = "";

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = conex;
                cn.Open();
            }
            catch (SqlException ex)
            {
                codeBdError = ex.ErrorCode;
                msgBdError = ex.Message;
                throw ex;
            }
        }
        public void CreateCommand(string vComando, CommandType vTipo)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = vTipo;
                cmd.CommandText = vComando;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddParameters(string vNombre, SqlDbType vTipo, Object vValor)
        {
            cmd.Parameters.Add(vNombre, vTipo).Value = vValor;
        }
        public void CleanParameters()
        {
            cmd.Parameters.Clear();
        }
        public int ExecuteCommand()
        {
            DataBase.codeBdError = 0;
            DataBase.msgBdError = "";
            int numreg = 0;
            try
            {
                numreg = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                DataBase.codeBdError = ex.ErrorCode;
                DataBase.msgBdError = ex.Message;
            }
            finally
            {
                if (codeBdError != 0)
                {
                    cn.Close();
                }
            }
            return numreg;
        }
        public SqlDataReader ExecuteReader()
        {
            return cmd.ExecuteReader();
        }
        public DataTable ExecuteQuery()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public void Disconnect()
        {
            cn.Close();
        }
    }
}