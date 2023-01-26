using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class Empleado
    {
        [Key]
        public int DNI { get; set; }
        [MaxLength(150)]
        [Display(Name = "Nombre: ")]
        public string Nombre { get; set; }
        [MaxLength(150)]
        [Display(Name = "Apellido: ")]
        public string Apellido { get; set; }
        [MaxLength(150)]
        [Display(Name = "Email: ")]
        public string Mail { get; set; }
    }
}
