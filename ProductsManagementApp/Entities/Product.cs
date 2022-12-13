using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsManagementApp.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public string Brand { get; set; }
        public virtual Catagory Catagory { get; set; }
        public virtual List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }

    [Table("tbl_books")]
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }
        [Column(name: "Rate", TypeName = "varchar(50)")]
        public double Price { get; set; }
        [NotMapped]
        public int Profit { get; set; }
    }
}
