using CRUD2.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD2.Interfaces
{
    public interface IBlogPostService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostById(int id);
        Task CreateBlogPost(BlogPost blogPost);
        Task DeleteBlogPost(int id);
        Task UpdateBlogPost(BlogPost blogPost);
    }
}
