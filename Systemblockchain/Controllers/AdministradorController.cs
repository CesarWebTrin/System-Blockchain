using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systemblockchain.Entidades;

namespace Systemblockchain.Controllers
{
    public class AdministradorController
    {
        public int Inserir(Administrador obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO administrador ([nome], [data_nasc], [cpf], [estado], [cidade], [bairro], [cep], [rua], [numero], [email], senha) VALUES (@nome, @data_nasc, @cpf, @estado, @cidade, @bairro, @cep, @rua, @numero, @email, @senha)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                cn.Parameters.Add("data_nasc", SqlDbType.DateTime).Value = obj.Data_nasc;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = obj.Cpf;
                cn.Parameters.Add("estado", SqlDbType.VarChar).Value = obj.Estado;
                cn.Parameters.Add("cidade", SqlDbType.VarChar).Value = obj.Cidade;
                cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = obj.Bairro;
                cn.Parameters.Add("cep", SqlDbType.VarChar).Value = obj.Cep;
                cn.Parameters.Add("rua", SqlDbType.VarChar).Value = obj.Rua;
                cn.Parameters.Add("numero", SqlDbType.VarChar).Value = obj.Numero;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = obj.Email;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }
            
        public bool tem = false;
        public bool Logar(String email, String senha)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM administrador where email=@email and senha= @senha";
                cn.Parameters.AddWithValue("@email", email);
                cn.Parameters.AddWithValue("@senha", senha);

                cn.Connection = con;
                SqlDataReader dr;

                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                return tem;
            }
        }

    }
}
