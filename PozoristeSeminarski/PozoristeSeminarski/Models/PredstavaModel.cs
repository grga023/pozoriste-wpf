using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeSeminarski.Models
{
    public class PredstavaModel
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public float Ocena { get; set; }
        public string Reditelj { get; set; }

    }
}
