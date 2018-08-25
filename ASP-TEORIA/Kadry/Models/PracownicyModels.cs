using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kadry.Models
{
    public class PracownicyModels
    {
        [Required]
        [DisplayName("Imię")]
        [StringLength(50,ErrorMessage = "Imie nie moze byc dluzsze niz 50 znakow")]
        public string Imie { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Nazwisko nie moze byc dluzsze niz 50 znakow")]
        public string Nazwisko { get; set; }

        [Required]
        [Range(0,109,ErrorMessage = "Podaj poprawny wiek")]
        public int Wiek { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Stanowisko nie moze byc dlusze niz 50 znakow")]
        public string Stanowisko { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayName("Data Zatrudnienia")]
        [CustomValidationAttribute(typeof(PracownicyModels),
            "SprawdzPoprawnoscDatyZatrudnienia")]
        public System.DateTime DataZatrudnienia { get; set; }


        public static ValidationResult SprawdzPoprawnoscDatyZatrudnienia(System.DateTime data)
        {
            if (data.Date > System.DateTime.Now.Date)
                return new ValidationResult("Data zatrudnienia nie może być późniejsza od ddnia dzisiejszego!");
            else
                return ValidationResult.Success;
        }
    }
}