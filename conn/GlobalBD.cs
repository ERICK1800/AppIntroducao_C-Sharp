using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppIntroducao.conn
{
    class GlobalBD
    {
        MySqlConnection conn;

        public MySqlConnection conectar()
        {
            //xampp (password=)
            string conexao = "datasource=localhost;username=root;password=usbw;database=appcrud";
            this.conn = new MySqlConnection(conexao);
            this.conn.Open();
            return this.conn;
        }

        public void fecharConn()
        {
            this.conn.Close();
        }
    }
}
