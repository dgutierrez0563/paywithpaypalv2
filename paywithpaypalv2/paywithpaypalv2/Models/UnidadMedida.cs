using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paywithpaypalv2.Models
{
    public class UnidadMedida
    {
        [Key]
        public int IDUnidadMedida { get; set; }

        [Required]
        [DisplayName("Unidad de Medida")]
        public string DescUnidadMedida { get; set; }

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

    }
}