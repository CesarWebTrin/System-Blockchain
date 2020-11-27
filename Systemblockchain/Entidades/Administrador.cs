using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemblockchain.Entidades
{
    public class Administrador
    {
        int id_adm;
        String nome;
        DateTime data_nasc;
        String cpf;
        String estado;
        String cidade;
        String bairro;
        String cep;
        String rua;
        String numero;
        String email;
        String senha;

        public int Id_adm { get => id_adm; set => id_adm = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
