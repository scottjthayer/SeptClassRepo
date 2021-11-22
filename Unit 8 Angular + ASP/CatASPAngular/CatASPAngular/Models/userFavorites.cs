using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatASPAngular.Models
{
    public class userFavorites
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CatId { get; set; }
    }
}
