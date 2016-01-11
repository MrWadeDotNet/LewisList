using LewisList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisList.ViewModels
{
     public class PostViewModel
    {
        public Post Post { get; set; }
        public Category CategoryName { get; set; }
        public List <Category> CategoriesId { get; set; }
        public List <Category> Categories { get; set; }
        public IQueryable <Post> Posts { get; set; }

    }
}
