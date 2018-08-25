using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rodzial4.Models
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [Range(0,100,ErrorMessage = "Wstaw poprawną date balwanie!")]
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime DataZatrudnienia { get; set; }
    }
}