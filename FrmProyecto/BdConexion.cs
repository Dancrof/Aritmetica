using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrmProyecto
{
    class BdConexion
    {
        public static SqlConnection Conexion()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-Q42RQ5V;DATABASE=Credenciales;Integrated security=true;");

            cn.Open();
            return cn;
        }  
    }
}
