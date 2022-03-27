using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class Actions
    {
        DataBase bd = new DataBase();
        public void CargarTalla(ComboBox CmbTalla)
        {
            CargarCombo talla = new CargarCombo();
            talla.Load(CmbTalla, "SELECT ID, NOMBRE FROM TALLA","ID","NOMBRE");
        }
        public void CargarMotivo(ComboBox CmbMotivo)
        {
            CargarCombo motivo = new CargarCombo();
            motivo.Load(CmbMotivo, "SELECT ID, NOMBRE FROM MOTIVO_PRODUCTO", "ID", "NOMBRE");
        }

        public void CargarTallaEditar(ComboBox CmbTalla, int  Referencia)
        {
            CargarCombo talla = new CargarCombo();
            talla.Load(CmbTalla, "SELECT ID, NOMBRE FROM TALLA where id not in (select id_talla as talla from producto where referencia = "+Referencia+");", "ID", "NOMBRE");
        }
    }
}
