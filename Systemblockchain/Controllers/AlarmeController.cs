using Systemblockchain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Systemblockchain.Controllers
{
    public class AlarmeController
    {
        public int Inserir(Alarme obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO alarme ([titulo], [data_alerta], [texto]) VALUES (@titulo, @data_alerta, @texto)";
                cn.Parameters.Add("titulo", SqlDbType.VarChar).Value = obj.Titulo;
                cn.Parameters.Add("data_alerta", SqlDbType.DateTime).Value = obj.Data_alerta;
                cn.Parameters.Add("texto", SqlDbType.VarChar).Value = obj.Texto;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }    
    }
}
