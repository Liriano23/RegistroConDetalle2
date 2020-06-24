using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegistroConDetalle2.Pages;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroConDetalle2.Models
{
    public class Ordenes
    {
        [Key]
        public int OrdenId { get; set; }

        [Required (ErrorMessage ="Debe ingresar la fecha de ingreso de la orden al sistema")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:MM/dd/yyyy", ApplyFormatInEditMode =true)]
        public DateTime Fecha { get; set; }

        [Required (ErrorMessage = "Debe ingresar el suplidor")]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el monto")]
        public decimal Monto { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> OrdenesDetalle { get; set; }

        public Ordenes()
        {
            OrdenId = 0;
            Fecha = DateTime.Now;
            SuplidorId = 0;
            Monto = 0;
            OrdenesDetalle = new List<OrdenesDetalle>();
        }
    }
}
