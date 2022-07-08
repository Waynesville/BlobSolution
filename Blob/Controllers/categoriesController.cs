using Blog.Model;
using Blog.DatabaseServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoriesController : ControllerBase
    {
        // GET: api/<categoriesController>
        [HttpGet]
        public List<BlogCategory> Get()
        {
            BlogCategoryService blogCategoryService = new BlogCategoryService();
            List<BlogCategory> blogCategories = blogCategoryService.GetAll();

            return blogCategories;
        }

    }
}
