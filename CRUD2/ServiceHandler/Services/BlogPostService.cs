using AutoMapper;
using CRUD2.DataBase;
using CRUD2.Entities;
using CRUD2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.ServiceHandler.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly Context context;
        private readonly IMapper mapper;

        public BlogPostService(Context context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public async Task CreateBlogPost(BlogPost blogPost)
        {
            context.BlogPosts.Add(blogPost);
            await context.SaveChangesAsync();
        }

        public void DeleteBlogPost(int id)
        {
            var blogPost = context.BlogPosts.FirstOrDefault(x => x.Id == id);
            if(blogPost == null)
            {
                throw new NullReferenceException();
            }
            context.BlogPosts.Remove(blogPost);
            context.SaveChanges();
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

        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return context.BlogPosts.ToList();
        }

        public void UpdateBlogPost(BlogPost blogPost)
        {
            var blogPostToUpdate = context.BlogPosts.FirstOrDefault(x => x.Id == blogPost.Id);
            if (blogPostToUpdate == null)
            {
                throw new NullReferenceException();
            }
            blogPostToUpdate = blogPost;
            context.BlogPosts.Update(blogPostToUpdate);
            context.SaveChanges();
        }
    }
}
