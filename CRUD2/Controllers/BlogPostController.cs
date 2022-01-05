using AutoMapper;
using CRUD2.Entities;
using CRUD2.Interfaces;
using CRUD2.Interfaces.Repositories;
using CRUD2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IBlogPostService blogPostService;

        public BlogPostController(IMapper mapper, IBlogPostRepository blogPostRepository, IBlogPostService blogPostService)
        {
            this.mapper = mapper;
            this.blogPostRepository = blogPostRepository;
            this.blogPostService = blogPostService;
        }

        /// <summary>
        /// Create new blog post
        /// </summary>
        /// <param name="newBlogPostViewModel"></param>
        /// <returns></returns>
        [HttpPost("Create new blog post")]
        public async Task<IActionResult> CreateNewBlogPost(NewBlogPostViewModel newBlogPostViewModel)
        {
            var newBlogPost = mapper.Map<BlogPost>(newBlogPostViewModel);
            await blogPostRepository.CreateBlogPost(newBlogPost);
            return Ok();
        }

        /// <summary>
        /// Get blog post by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get blog post by ID")]
        public async Task<IActionResult> GetBlogPostById(int id)
        {
            var blog =  blogPostRepository.GetBlogPostById(id);
            return Ok(blog);
        }

        /// <summary>
        /// Get all blog posts
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get all blog posts")]
        public async Task<IActionResult> GetBlogPosts()
        {
            var blogs = blogPostRepository.GetBlogPosts();
            return Ok(blogs);
        }

        /// <summary>
        /// Delete blog post by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete blog post by ID")]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            await blogPostRepository.DeleteBlogPost(id);
            return Ok();
        }

        /// <summary>
        /// Update blog post info
        /// </summary>
        /// <param name="updateBlogPostViewModel"></param>
        /// <returns></returns>
        [HttpPut("Update blog post")]
        public async Task<IActionResult> UpdateBlogPost(UpdateBlogPostViewModel updateBlogPostViewModel)
        {
            var updatedBlog = mapper.Map<BlogPost>(updateBlogPostViewModel);
            await blogPostRepository.UpdateBlogPost(updatedBlog);
            return Ok();
        }

        [HttpGet("Get blog post Title")]
        public async Task<IActionResult> GetBlogPostTitle(int id)
        {
            var title = blogPostService.GetBlogPostTitle(id);
            return Ok(title);
        }

    }
}
