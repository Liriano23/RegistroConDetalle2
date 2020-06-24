using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroConDetalle2.Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del suplidor")]
        [MinLength(1,ErrorMessage = "Debe ingresar un nombre valido")]
        public string Nombre { get; set; }

        public Suplidores()
        {
            SuplidorId = 0;
            Nombre = string.Empty;
        }
    }
}
