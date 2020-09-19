using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialJuanGianella.Models
{
    public class Lengua
    {
        [Key]
        [StringLength(2, ErrorMessage = "Nombre no valido")]
        public string iso639_1 { get; set; }
        [StringLength(3, ErrorMessage = "Nombre no valido")]
        public string iso639_2 { get; set; }
        [StringLength(15,MinimumLength =6 ,ErrorMessage = "Nombre no valido")]
        public string name { get; set; }
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Nombre no valido")]
        public string nativeName { get; set; }
    }
    public class Pais
    {
        [Key]
        [Required]
        [StringLength(3,MinimumLength =3,ErrorMessage ="Nombre no valido")]
        public string alpha3Code { get; set; }
        [Required]
        [StringLength(8,MinimumLength =4,ErrorMessage ="Nombre no valido")]
        public string region { get; set; }
        [Required]
        [StringLength(50,MinimumLength =6,ErrorMessage ="Nombre no valido")]
        public string name { get; set; }
        [Required]
        public int area { get; set; }
        [Required]
        public int callingCodes { get; set; }
        [Required]
        public List<Lengua> Languages { get; set; }
        [Required]
        public string flag { get; set; }
    }
}