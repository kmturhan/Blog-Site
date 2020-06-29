using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public bool status { get; set; }
        public DateTime create_time { get; set; }
        public string author { get; set; }
        public string email { get; set; }
        public int post_id { get; set; }
    }
}
