using KnowledgeHubPortalWebApp.Models.Entities;

namespace KnowledgeHubPortalWebApp.Models.DataAccess
{
    public interface ICatagoriesRepository
    {
        void Save(Catagory catagoryToSave);
        List<Catagory> GetCatagories();
        void Edit(Catagory catagoryToEdit);

        Catagory GetCatagory(int id);

        List<Catagory> SearchCatagories(string searchText);
    }
}
