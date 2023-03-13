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
    class Setor
    {
        private int id;
        private string descricao;
        private int ramal;
        private GlobalBD db = new GlobalBD();

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Ramal { get => ramal; set => ramal = value; }

        public override string ToString()
        {
            return (String.Format("ID: {0} - Descrição: {1} - Ramal: {2}", id, descricao, ramal));
        }

        public string cadastrar()
        {
            try 
            { 
                string sql = "INSERT INTO categoria VALUES (null,'" + this.descricao+"',"+this.ramal+")";
                MySqlCommand comando = new MySqlCommand(sql,this.db.conectar());
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
                string sql = "DELETE FROM categoria WHERE id = " + var_id + ";";
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
                string sql = "SELECT * FROM categoria;";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                MySqlDataReader res = comando.ExecuteReader();

                //retorno
                string listagem = "Lista de Setores \n\n";

            if (res.HasRows) 
            {
                while (res.Read())
                {
                    this.id = Convert.ToInt32(res["id"].ToString());
                    this.descricao = res["descricao"].ToString();
                    this.ramal = Convert.ToInt32(res["ramal"].ToString());

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
        }//fim do listar

        public Boolean pesquisarPorID(string var_id)
        {
            try
            {
                string sql = "SELECT * FROM categoria WHERE id = " + var_id + ";";
                MySqlCommand comando = new MySqlCommand(sql, this.db.conectar());
                MySqlDataReader res = comando.ExecuteReader();

                Boolean retorno = true;

                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        this.descricao = res["descricao"].ToString();
                        this.ramal = Convert.ToInt32(res["ramal"].ToString());
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
        }//fim do listar
    }
}
