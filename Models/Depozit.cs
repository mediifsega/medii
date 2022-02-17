using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bereschi_Gabriel_Depozit.Models
{
    public class Depozit
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public int Capacitate { get; set; }
        public int IDProprietar { get; set; }
        public Proprietar Proprietar { get; set; }
    }
}
