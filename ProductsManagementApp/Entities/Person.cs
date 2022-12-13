namespace ProductsManagementApp.Entities
{
    abstract public class Person
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Location { get; set; }
    }
}
