using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using System.Data;

namespace BusinessLayer
{
    public  class CargarCombo
    {
        DataBase bd = new DataBase();
        public void Ready(string vComando)
        {
            bd.Connect();
            bd.CreateCommand(vComando, CommandType.Text);
        }
        public void AddParameters(string vNombre, SqlDbType vTipo, object vValor)
        {
            bd.AddParameters(vNombre, vTipo, vValor);
        }
        public void Load(ComboBox vCombo, string vValueMember, string vDisplayMember)
        {
            DataTable dt = new DataTable();
            dt = bd.ExecuteQuery();
            vCombo.DataSource = dt;
            vCombo.ValueMember = vValueMember;
            vCombo.DisplayMember = vDisplayMember;
        }
        public void Load(ComboBox vCombo, string vComando, string vValueMember, string vDisplayMember)
        {
            Ready(vComando);
            Load(vCombo, vValueMember, vDisplayMember);

        }
    }
}
