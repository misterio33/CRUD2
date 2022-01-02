using CRUD2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.Interfaces
{
    public interface IBlogPostService
    {
        public IEnumerable<BlogPost> GetBlogPosts();
        public BlogPost GetBlogPostById(int id);
        Task CreateBlogPost(BlogPost blogPost);
        public void DeleteBlogPost(int id);
        public void UpdateBlogPost(BlogPost blogPost);
    }
}
