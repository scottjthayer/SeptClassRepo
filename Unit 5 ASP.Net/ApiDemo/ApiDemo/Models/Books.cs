using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiDemo.Models
{
    public class Books
    {
        //non static
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        //static
        private static List<Books> Library = new List<Books>();
        private static int NextId = 1;

        public static Books AddBook(string _title, string _category)
        {
            Books newbook = new Books()
            {
                Id = NextId,
                Title = _title,
                Category = _category
            };
            NextId++;
            Library.Add(newbook);
            return newbook;
        }

        public static List<Books> GetAll()
        {
            return Library;
        }

        public static Books FindById(int _id)
        {
            return Library.Find(B => B.Id == _id);
        }

        public static List<Books> FindByCategory(string _category)
        {
            return Library.Where(B => B.Category.ToLower() == _category.ToLower()).ToList();
        }
    }
}
