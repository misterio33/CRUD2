using AutoMapper;
using CRUD2.DataBase;
using CRUD2.Entities;
using CRUD2.Interfaces;
using CRUD2.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBlogPostService blogPostService;

        public BlogPostController(IMapper mapper, IBlogPostService blogPostService)
        {
            this.mapper = mapper;
            this.blogPostService = blogPostService;
        }

        [HttpPost("Create new blog post")]
        public async Task<IActionResult> CreateNewBlogPost(NewBlogPostViewModel newBlogPostViewModel)
        {
            var newBlogPost = mapper.Map<BlogPost>(newBlogPostViewModel);
            await blogPostService.CreateBlogPost(newBlogPost);
            return Ok();
        }
    }
}
