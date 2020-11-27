using Systemblockchain.Controllers;
using Systemblockchain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemblockchain.Models
{
    public class AlarmeModel
    {
        public static int Inserir (Alarme obj)
        {
            return new AlarmeController().Inserir(obj);
        }
    }
}
