using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bereschi_Gabriel_Depozit.Models
{
    public class Produs
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public int Greutate { get; set; }
        public string Vanzator { get; set; }
        public string Depozit { get; set; }
    }
}
