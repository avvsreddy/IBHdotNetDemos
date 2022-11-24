using ContactManagement.DataAccess.Entities;
using ContactManagement.DataAccess.Exceptions;
using NLog;

namespace ContactManagement.DataAccess.Data
{
    public class ContactsFileRepository : IContactsRepository
    {
        private string dataFile = "E:\\sample\\contacts.txt";
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
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(dataFile);
                // convert obj into csv
                string contactCsv = $"{contact.ContactID},{contact.Name},{contact.Email},{contact.Mobile},{contact.Location}";
                sw.WriteLine(contactCsv);

            }
            catch (Exception ex)
            {
                // convert
                ContactManagementException cex = new ContactManagementException("Unable to save the contact", ex);
                // log - nLog
                Logger nLog = LogManager.GetCurrentClassLogger();
                nLog.Error(ex.Message);
                // throw the ex
                throw cex;
            }
            finally
            {
                sw.Close();
            }
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
