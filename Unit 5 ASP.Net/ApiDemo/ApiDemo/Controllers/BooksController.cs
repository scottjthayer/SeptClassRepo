using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDemo.Models;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //api/books
        [HttpPost()]
        public Books AddBook(string title, string category)
        {
            return Books.AddBook(title, category);
        }

        //api/books
        [HttpGet()]
        public List<Books> GetAll()
        {
            return Books.GetAll();
        }

        //api/books/1
        [HttpGet("{id}")]
        public Books getById(int id)
        {
            return Books.FindById(id);
        }

        //api/books/category/fantasy
        [HttpGet("category/{catname}")]
        public List<Books> getByCategory(string catname)
        {
            return Books.FindByCategory(catname);
        }
    }
}
