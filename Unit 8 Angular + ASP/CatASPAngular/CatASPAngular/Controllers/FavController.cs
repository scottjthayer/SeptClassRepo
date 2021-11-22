using CatASPAngular.Data;
using CatASPAngular.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CatASPAngular.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FavController : ControllerBase
    {
        public ApplicationDbContext context;

        public FavController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpPost("NewFav")]
        public userFavorites NewFavorite(string _CatId)
        {
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            userFavorites result = new userFavorites() { CatId = _CatId, UserId = currentUserID };
            this.context.favorites.Add(result);
            this.context.SaveChanges();
            return result;
        }

        [HttpGet("GetFavs")]
        public List<userFavorites> GetFavorites()
        {
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            return this.context.favorites.Where(F => F.UserId == currentUserID).ToList();
        }

        [HttpDelete("DeleteFav")]
        public userFavorites DeleteFavorite(string id)
        {
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            userFavorites result = this.context.favorites.ToList().Find(F => F.CatId == id && F.UserId == currentUserID);
            this.context.favorites.Remove(result);
            this.context.SaveChanges();

            return result;
        }
    }
}
