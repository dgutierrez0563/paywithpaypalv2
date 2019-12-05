using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paywithpaypalv2.Models
{
    public class Producto
    {
        [Key]
        public int IDProducto { get; set; }

        [Required]
        [DisplayName("Cod. Referencia")]
        public string CodReferencia { get; set; }

        [Required]
        [DisplayName("Nombre Producto")]
        public string NombreProducto { get; set; }

        //[Required]
        [DisplayName("Cod. Barra 1")]
        public string CodBarra1 { get; set; }
        //[Required]
        [DisplayName("Cod. Barra 2")]
        public string CodBarra2 { get; set; }

        //[Required]
        [DisplayName("Precio Bruto/U")]
        [Column(TypeName = "float")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public double PrecioBruto { get; set; }

        //[Required]
        [DisplayName("Nombre Categoria")]
        public int IDCategoria { get; set; }
        [ForeignKey("IDCategoria")]
        public virtual Categoria Categorias { get; set; }

        //[Required]
        [DisplayName("Nombre Sub-Categoria")]
        public int IDSubCategoria { get; set; }
        [ForeignKey("IDCategoria")]
        public virtual SubCategoria SubCategorias { get; set; }

        //[Required]
        [DisplayName("Impuesto 1")]
        public int Tasa1 { get; set; }
        //[Required]
        [DisplayName("Impuesto 2")]
        public int Tasa2 { get; set; }

        [Required]
        [DisplayName("Unidad de Medida")]
        public int IDUnidadMedida { get; set; }
        [ForeignKey("IDUnidadMedida")]
        public virtual UnidadMedida UnidadMedidas { get; set; }

        [Required]
        [DisplayName("Presentacion")]
        public int Presentacion { get; set; }

        //[Required]
        [DisplayName("Proveedor")]
        public int IDProveedor { get; set; }
        [ForeignKey("IDProveedor")]
        public virtual Proveedor Proveedors { get; set; }
        //[Required]
        //[DisplayName("Proveedor")]
        //public int IDProveedor { get; set; }
        //[ForeignKey("IDProveedor")]
        //public virtual Proveedor Proveedors { get; set; }

        //[Required]
        //[DisplayName("Stock")]
        //public int Stock { get; set; }

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

        //public ICollection<Atributo> Atributos { get; set; }
    }
}