using KnowledgeHubPortalWebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortalWebApp.Models.DataAccess
{
    public class ArticlesRepository : IArticlesRepository
    {
        private KHDbContext db = new KHDbContext();
        public void ApproveArticles(List<int> articleIds)
        {
            foreach (var aid in articleIds)
            {
                var articleToApprove = db.Articles.Find(aid);
                articleToApprove.IsApproved = true;

            }
            db.SaveChanges();
        }

        public List<Article> GetArticlesByCatagoryID(int catagoryId)
        {
            return db.Articles.Where(a => a.CatagoryID == catagoryId).ToList();
        }

        public List<Article> GetArticlesForBrowse()
        {
            return db.Articles.Where(a => a.IsApproved).ToList();
        }

        public List<Article> GetArticlesForReview()
        {
            var articles = from a in db.Articles.Include("Catagory")
                           where a.IsApproved == false
                           select a;
            return articles.ToList();
            //return db.Articles.Include("Catagory").Where(a => !a.IsApproved).ToList();
        }

        public void RejectArticles(List<int> articleIds)
        {
            foreach (var aid in articleIds)
            {
                var articleToReject = db.Articles.Find(aid);
                db.Articles.Remove(articleToReject);

            }
            db.SaveChanges();
        }

        public void SubmitArticle(Article articleToSubmit)
        {
            db.Articles.Add(articleToSubmit);
            db.SaveChanges();

        }



    }
}
