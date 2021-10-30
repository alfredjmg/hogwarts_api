using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hogwarts.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Nombre no puede tener mas de 20 caracteres")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Nombre solo puede contener letras")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Apellido no puede tener mas de 20 caracteres")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Apellido solo puede contener letras")]
        public string Apellido { get; set; }
        [Required]
        [RegularExpression("^[0-9]{1,10}$", ErrorMessage = "Identificacion solo numeros de hasta 10 digitos")]
        public string Identificacion { get; set; }
        [Required]
        [RegularExpression("^[0-9]{1,2}$", ErrorMessage = "Edad solo numeros de dos digitos")]
        public int Edad { get; set; }
        [Required]
        public string Casa { get; set; }
    }
}
