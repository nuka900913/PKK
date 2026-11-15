using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Warehouse
{

    public static class Koneksi
    {
        public const int StokHabis = 0;
        public const int BatasStok = 10;

        public static string ConnStr
        {
            get { return ConfigurationManager.ConnectionStrings["GudangDB"].ConnectionString; }
        }

        public static SqlConnection Buka()
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();
            return conn;
        }
    }
    public static class Sesi
    {
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
    }
}
