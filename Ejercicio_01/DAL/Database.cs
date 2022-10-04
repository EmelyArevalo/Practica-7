using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_01.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace Ejercicio_01.DAL
{
    public class Database
    {
        public static string getStrConnecction()
        {
            return Settings.Default.empleadosConnection;
        }

        public SqlConnection geetConnectionn()
        {
            SqlConnection Con = new SqlConnection(getStrConnecction());
            return Con;
        }


    }
}
