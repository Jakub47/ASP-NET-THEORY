using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modele.Models
{
    public class Pracownik
    {
        public int PracownikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
    }
}