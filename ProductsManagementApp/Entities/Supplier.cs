namespace ProductsManagementApp.Entities
{
    public class Supplier : Person
    {
        public string GST { get; set; }
        public int Rating { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
