using System.ComponentModel.DataAnnotations;

namespace ProductsManagementApp.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
