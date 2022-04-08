using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsthmaApp
{
    class MYSQLCONNECTION
    {
        public MySqlConnection con;

        public void Connection()
        {
            con = new MySqlConnection("Server=sql137.main-hosting.eu;Database=u103452466_asthm;Username=u103452466_aprt0;Password=Rabbit06;SSLMode=none");
        }
    }
}
