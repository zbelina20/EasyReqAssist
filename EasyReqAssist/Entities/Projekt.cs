using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyReqAssist.Entities
{
    public class Projekt
    {
        public string Naziv { get; set; }
        public List<Zahtjev> ListaZahtjeva { get; set; }
    }
}
