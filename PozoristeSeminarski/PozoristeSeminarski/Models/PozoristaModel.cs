using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeSeminarski.Models
{
    public class PozoristaModel
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int GodinaOsnivanja { get; set; }
    }
}
