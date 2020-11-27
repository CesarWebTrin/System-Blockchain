using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemblockchain.Entidades
{
    public class Alarme
    {
        int id_alerta;
        string titulo;
        DateTime data_alerta;
        string texto;

        public int Id_alerta { get => id_alerta; set => id_alerta = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Data_alerta { get => data_alerta; set => data_alerta = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
