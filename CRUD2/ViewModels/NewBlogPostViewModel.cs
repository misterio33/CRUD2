using System.ComponentModel.DataAnnotations;

namespace CRUD2.ViewModels
{
    public class NewBlogPostViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string BlogText { get; set; }
    }
}
