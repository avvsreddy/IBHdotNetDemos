using System.ComponentModel.DataAnnotations;

namespace KnowledgeHubPortalWebApp.Models.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required(ErrorMessage = "Please enter the catagory name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kindly enter the desc")]
        public string Description { get; set; }
    }
}
