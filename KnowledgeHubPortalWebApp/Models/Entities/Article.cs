using Microsoft.Build.Framework;

namespace KnowledgeHubPortalWebApp.Models.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [System.ComponentModel.DataAnnotations.Url]
        public string URL { get; set; }
        public string? Description { get; set; }
        public string? PostedBy { get; set; }
        public DateTime DateSubmited { get; set; }
        public int CatagoryID { get; set; }
        public Catagory? Catagory { get; set; }
        public bool IsApproved { get; set; }

    }
}
