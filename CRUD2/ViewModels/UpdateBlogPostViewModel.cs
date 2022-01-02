using System.ComponentModel.DataAnnotations;

namespace CRUD2.ViewModels
{
    public class UpdateBlogPostViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string BlogText { get; set; }
    }
}
