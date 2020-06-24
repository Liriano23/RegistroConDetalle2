using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RegistroConDetalle2.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el id de la orden")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la cantidad del producto")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el id del producto")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el costo del producto")]
        public decimal Costo { get; set; }

        public OrdenesDetalle()
        {
            Id = 0;
            OrdenId = 0;
            Cantidad = 0;
            ProductoId = 0;
            Costo = 0;
        }
    }
}
