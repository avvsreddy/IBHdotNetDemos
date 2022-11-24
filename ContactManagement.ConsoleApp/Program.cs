using ContactManagement.DataAccess.Data;
using ContactManagement.DataAccess.Entities;

namespace ContactManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage Contacts - CRUD (Create-Read-Update-Delete)

            // name, email, mobile, location
            Contact c = new Contact { ContactID = 111, Name = "Sachin", Email = "sachin@bcci.org", Location = "Mumbai", Mobile = "234234234" };
            IContactsRepository repo = new ContactsFileRepository();
            try
            {
                repo.Save(c);
                Console.WriteLine("Contact save....");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}