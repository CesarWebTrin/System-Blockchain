using Systemblockchain.Controllers;
using Systemblockchain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Systemblockchain.Models
{
    public class AdministradorModel
    {
        public static int Inserir(Administrador obj)
        {
            return new AdministradorController().Inserir(obj);
        }

        public static bool Logar(String email, String senha)
        {
            return new AdministradorController().Logar(email, senha);
        }
    }
}
