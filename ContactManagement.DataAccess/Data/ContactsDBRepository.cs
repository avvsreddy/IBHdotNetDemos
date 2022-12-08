using ContactManagement.DataAccess.Entities;

namespace ContactManagement.DataAccess.Data
{
    public class ContactsDBRepository : IContactsRepository
    {
        public void Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetByLocation(string loc)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
