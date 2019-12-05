using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace paywithpaypalv2.Models
{
    public class Categoria
    {
        [Key]
        public int IDCategoria { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("Nombre Categoria")]
        public string NombreCategoria { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Detalle de Categoria")]
        public string DetalleCategoria { get; set; }

        //For Status
        public int Status { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaCreado { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaActualizado { get; set; }

        //For audit user
        public string Createdby { get; set; }
        //For audit user
        public string Updatedby { get; set; }

        public ICollection<Producto> Productoes { get; set; }
        public ICollection<SubCategoria> SubCategorias { get; set; }

        //[RegularExpression(@"^\$?\d+(\.(\d{2}))?$")] for validate number decimal
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]  for validate email
    }
}