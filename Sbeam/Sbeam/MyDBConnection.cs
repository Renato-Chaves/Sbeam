using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbeam
{
    internal class MyDBConnection
    {
        public void Querry(String _cmd)
        {
            string connectionString = "Data Source=sql10.freesqldatabase.com; username=sql10647862; password=35ASdvQdUI; database=sql10647862";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
