using KnowledgeHubPortalWebApp.Models.DataAccess;
using KnowledgeHubPortalWebApp.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHubPortalWebApp.Controllers
{
    public class ArticlesController : Controller
    {
        ArticlesRepository articlesRepo = new ArticlesRepository();
        CatagoriesRepository catagoriesRepo = new CatagoriesRepository();
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult SubmitArticle()
        {
            var catagories = catagoriesRepo.GetCatagories();
            var selectlistcatagories = from c in catagories
                                       select new SelectListItem { Text = c.Name, Value = c.CatagoryID.ToString() };
            ViewBag.CatagoryID = selectlistcatagories;


            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult SubmitArticle(Article articleToSubmit)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("SubmitArticle");
            }
            articleToSubmit.DateSubmited = DateTime.Now;
            articleToSubmit.IsApproved = false;

            if (User.Identity.Name == null)
                articleToSubmit.PostedBy = "Unknown";
            else
                articleToSubmit.PostedBy = User.Identity.Name;


            articlesRepo.SubmitArticle(articleToSubmit);
            TempData["Message"] = $"Article {articleToSubmit.Title} submited successfully for review.";
            return RedirectToAction("SubmitArticle");
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult ReviewArticles()
        {
            var articlesForReview = articlesRepo.GetArticlesForReview();
            return View(articlesForReview);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Approve(List<int> ArticleID)
        {
            articlesRepo.ApproveArticles(ArticleID);
            TempData["Message"] = "Articles Approved";
            return RedirectToAction("ReviewArticles");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Reject(List<int> ArticleID)
        {
            articlesRepo.RejectArticles(ArticleID);
            TempData["Message"] = "Articles Rejected";
            return RedirectToAction("ReviewArticles");

        }

        public IActionResult BrowseArticles()
        {
            var articles = articlesRepo.GetArticlesForBrowse();
            return View(articles);
        }
    }
}
