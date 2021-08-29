using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S4_PC1_Lab.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set;}

        [Column("nombre")]
        public string Nombre { get; set;}

        [Column("categoria")]
        public string Categoria { get; set;}

        [Column("precio")]
        public double Precio { get; set;}

        [Column("descuento")]
        public double Descuento { get; set;}

    }
}