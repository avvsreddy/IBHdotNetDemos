using KnowledgeHubPortalWebApp.Models.DataAccess;
using KnowledgeHubPortalWebApp.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortalWebApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class CatagoriesController : Controller
    {
        ICatagoriesRepository repo = new CatagoriesRepository();
        // http://domainname/catagories/index
        public IActionResult Index(string searchText = null) // displaying catagory list
        {
            // fetch the catagories data
            List<Catagory> catagories = null;
            if (searchText != null && searchText.Length >= 0)
            {
                catagories = repo.SearchCatagories(searchText);
            }
            else
            {
                catagories = repo.GetCatagories();
            }


            return View(catagories);
        }

        // /cagories/create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(Catagory catagory)
        {
            // do validation
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            repo.Save(catagory);
            return View();
        }

        public IActionResult Edit(int id)
        {
            // fetch the catagory by id 
            Catagory catagory = repo.GetCatagory(id);
            return View(catagory);
        }
        //[AllowAnonymous]
        public IActionResult Update(Catagory catagory)
        {
            if (!ModelState.IsValid && catagory == null)
            {
                return View("Edit");
            }
            repo.Edit(catagory);
            //return View("Index");
            TempData["Message"] = "Catagory data updated successfully";
            return RedirectToAction("Index");
        }

    }
}
