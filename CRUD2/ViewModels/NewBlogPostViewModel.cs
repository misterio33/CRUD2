using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
