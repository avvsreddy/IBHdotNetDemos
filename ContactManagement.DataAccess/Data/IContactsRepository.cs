using ContactManagement.DataAccess.Entities;

namespace ContactManagement.DataAccess.Data
{
    public interface IContactsRepository
    {
        void Save(Contact contact);
        void Update(Contact contact);
        void Delete(int contactId);
        Contact GetById(int id);
        List<Contact> GetByLocation(string loc);
        List<Contact> GetByName(string name);
    }
}
