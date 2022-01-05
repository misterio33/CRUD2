using CRUD2.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD2.Interfaces
{
    public interface IBlogPostService
    {
        public string GetBlogPostTitle(int id);
    }
}
