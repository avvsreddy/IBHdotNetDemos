namespace ProductsManagementApp.Entities
{
    public class Customer : Person
    {
        public double Discount { get; set; }
        public string CustomerType { get; set; }
    }
}
