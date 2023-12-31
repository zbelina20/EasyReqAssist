﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyReqAssist.Entities
{
    public class Zahtjev
    {
        public int RedniBroj { get; set; }
        public string Identifikator { get; set; }
        public string NazivZahtjeva { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string Vrsta { get; set; }
        public string Obrazlozenje { get; set; }
        public string Prioritet { get; set; }
        public string Izvor { get; set; }
        public string Status { get; set; }
        public string NacinProvjere { get; set; }
    }
}
