using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLayer;
using System.Data;

namespace BusinessLayer
{
    public class CargarDataGrid
    {
        private DataBase bd;
        public void Ready(string vcommand)
        {
            bd = new DataBase();
            bd.Connect();
            bd.CreateCommand(vcommand, System.Data.CommandType.Text);
        }
        public void AddParameters(string vName, SqlDbType vType, Object vValue)
        {
            bd.AddParameters(vName, vType, vValue);
        }
        public void Load(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            dt = bd.ExecuteQuery();
            dataGridView.DataSource = dt;
        }
        public void load(DataGridView vGridView, string vCommand)
        {
            Ready(vCommand);
            Load(vGridView);
        }
    }
}
