using KnowledgeHubPortalWebApp.Models.Entities;

namespace KnowledgeHubPortalWebApp.Models.DataAccess
{
    public class CatagoriesRepository : ICatagoriesRepository
    {
        private KHDbContext db = new KHDbContext();
        public void Edit(Catagory catagoryToEdit)
        {
            db.Catagories.Update(catagoryToEdit);
            //db.Entry(catagoryToEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public Catagory GetCatagory(int id)
        {
            return db.Catagories.Find(id);
        }

        public void Save(Catagory catagoryToSave)
        {
            db.Catagories.Add(catagoryToSave);
            db.SaveChanges();
        }

        public List<Catagory> SearchCatagories(string searchText)
        {
            var catagories = from c in db.Catagories
                             where c.Name.Contains(searchText) ||
                             c.Description.Contains(searchText)
                             select c;
            return catagories.ToList();
        }
    }
}
