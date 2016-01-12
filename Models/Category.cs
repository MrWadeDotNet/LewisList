using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisList.Models
{
    public class Category
    {
        public List<Category> Categories { get; set; }
       
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryMasterName { get; set; }

    }
}
