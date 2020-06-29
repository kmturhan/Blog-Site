using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public IFormFile PostImage { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Short_Content{ get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Update_Time { get; set; }
        public string Category_Name { get; set; }
    }
    public class MergeClass
    {
        public IEnumerable<Post> mainList { get; set; }
        public IEnumerable<string> categoryName { get; set; }
    }
}
