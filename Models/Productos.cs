using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RegistroConDetalle2.Pages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroConDetalle2.Models
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }

        [Required (ErrorMessage ="Debe ingresar una descripcion para el producto")]
        [MinLength(3, ErrorMessage = "Debe de agregar una descripcion valida")]
        public string Descripcion { get; set; }

        [Required (ErrorMessage = "Debe ingresar el costo del producto")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "Debe ingresar la cantidad del producto en inventario")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el id del suplidor")]
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual Suplidores Suplidores { get; set; }

        public Productos()
        {
            ProductosId = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Inventario = 0;
            //SuplidorId = 0;
        }
    }

}
