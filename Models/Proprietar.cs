using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bereschi_Gabriel_Depozit.Models
{
    public class Proprietar
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public ICollection<Depozit> Depozite { get; set; }
    }
}
