using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paywithpaypalv2.Models
{
    public class Proveedor
    {
        [Key]
        public int IDProveedor { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nombre Proveedor")]
        public string NombreProveedor { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nombre Comercial")]
        public string NombreComercialProveedor { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Correo { get; set; }

        //[Required]
        [StringLength(20)]
        [DisplayName("Telefono 1")]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$")]
        public string Telefono1 { get; set; }

        //[Required]
        [StringLength(20)]
        [DisplayName("Telefono 2")]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$")]
        public string Telefono2 { get; set; }

        //[Required]
        [StringLength(20)]
        [DisplayName("Fax")]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$")] //@"^[2-9]\d{2}-\d{3}-\d{4}$"
        public string Fax { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Direccion 1")]
        public string Direccion1 { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Direccion 2")]
        public string Direccion2 { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Detalles")]
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
        public string Createdby { get; set; }
        //For audit user
        public string Updatedby { get; set; }

        public ICollection<Producto> Productoes { get; set; }
    }
}