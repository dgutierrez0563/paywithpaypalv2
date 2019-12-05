using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace paywithpaypalv2.Models
{
    public class SubCategoria
    {
        [Key]
        public int IDSubCategoria { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("Nombre Sub-Categoria")]
        public string NombreSubCategoria { get; set; }

        //[Required]
        [DisplayName("Nombre Categoria")]
        public int IDCategoria { get; set; }
        [ForeignKey("IDCategoria")]
        public virtual Categoria Categorias { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Detalle de Sub-Categoria")]
        public string Detalle { get; set; }

        //For Status
        public int Status { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaCreado { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaActualizado { get; set; }

        //For audit user
        public string Createby { get; set; }
        //For audit user
        public string Updatedby { get; set; }

        public ICollection<Producto> Productoes { get; set; }

    }
}