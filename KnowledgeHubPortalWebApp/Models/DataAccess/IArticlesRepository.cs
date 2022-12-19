using KnowledgeHubPortalWebApp.Models.Entities;

namespace KnowledgeHubPortalWebApp.Models.DataAccess
{
    public interface IArticlesRepository
    {
        void SubmitArticle(Article articleToSubmit);
        void ApproveArticles(List<int> articleIds);
        void RejectArticles(List<int> articleIds);
        List<Article> GetArticlesForReview();
        List<Article> GetArticlesForBrowse();
        List<Article> GetArticlesByCatagoryID(int catagoryId);


    }
}
