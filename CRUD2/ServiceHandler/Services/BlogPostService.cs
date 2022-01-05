using CRUD2.DataBase;
using CRUD2.Entities;
using CRUD2.Interfaces;
using CRUD2.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.ServiceHandler.Services
{
    public class BlogPostService : IBlogPostRepository, IBlogPostService
    {
        private readonly Context context;

        public BlogPostService(Context context)
        {
            this.context = context;
        }
        public async Task CreateBlogPost(BlogPost blogPost)
        {
            context.BlogPosts.Add(blogPost);
            await context.SaveChangesAsync();
        }

        public async Task DeleteBlogPost(int id)
        {
            var blogPost = context.BlogPosts.FirstOrDefault(x => x.Id == id);

            if(blogPost == null)
            {
                throw new NullReferenceException();
            }

            context.BlogPosts.Remove(blogPost);
            await context.SaveChangesAsync();
        }

        public BlogPost GetBlogPostById(int id)
        {
            var blogPost = context.BlogPosts.FirstOrDefault(x => x.Id == id);
            if (blogPost == null)
            {
                throw new NullReferenceException();
            }
            return blogPost;
        }

        public List<BlogPost> GetBlogPosts()
        {
            return context.BlogPosts.ToList();
        }

        public string GetBlogPostTitle(int id)
        {
            var blogPost = context.BlogPosts.FirstOrDefault(x => x.Id == id);
            if (blogPost == null)
            {
                throw new NullReferenceException();
            }
            return blogPost.Title;
        }

        public async Task UpdateBlogPost(BlogPost blogPost)
        {
            context.BlogPosts.Update(blogPost);
            await context.SaveChangesAsync();
        }
    }
}
