using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using MySql.Data.MySqlClient;
using AppIntroducao.conn;
using System.Data;

namespace AppIntroducao.Class
{
    class Fornecedor
    {
        private int id;
        private string razaoSocial;
        private string email;
        private GlobalBD db = new GlobalBD();

        public int Id { get => id; set => id = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return (String.Format("ID: {0} - Razao Social: {1} - Email: {2}", id, razaoSocial, email));
        }

        public string cadastrar()
        {
            try
            {
                string sql = "INSERT INTO forncecedor VALUES (null,'" + this.razaoSocial + "','" + this.email + "')";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                comando.ExecuteReader();
                return "Ok";
            }
            catch (MySqlException ex)
            {
                return "erro" + ex.Message;
            }
        }

        public string excluir(string var_id)
        {
            try
            {
                string sql = "DELETE FROM forncecedor WHERE id = " + var_id + ";";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                comando.ExecuteNonQuery();
                return "Excluído com sucesso";
            }
            catch (MySqlException ex)
            {
                return "erro" + ex.Message;
            }
        }

        public string listar()
        {
            try
            {
                string sql = "SELECT * FROM forncecedor;";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                MySqlDataReader res = comando.ExecuteReader();

                //retorno
                string listagem = "Lista de Forncecedor \n\n";

                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        this.id = Convert.ToInt32(res["id"].ToString());
                        this.razaoSocial = res["razaoSocial"].ToString();
                        this.email = res["email"].ToString();

                        listagem += this.ToString() + '\n';
                    }
                }
                else
                {
                    listagem += "\nNenhum registro encontrado!";
                }

                return listagem;
            }
            catch (MySqlException ex)
            {
                return "erro" + ex.Message;
            }
        }//fim listar

        public Boolean pesquisarPorID(string var_id)
        {
            try
            {
                string sql = "SELECT * FROM forncecedor WHERE id = " + var_id + ";";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                MySqlDataReader res = comando.ExecuteReader();

                Boolean retorno = true;

                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        this.razaoSocial = res["razaoSocial"].ToString();
                        this.email = res["email"].ToString();
                    }
                }
                else
                {
                    retorno = false;
                }

                return retorno;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }//fim listar
    }
}
