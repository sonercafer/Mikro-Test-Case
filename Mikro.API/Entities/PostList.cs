using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Entities
{
    public class PostList
    {
        public string id { get; set; }
        public string text { get; set; }
        public string image { get; set; }
        public int likes { get; set; } 
        public string[] tags { get; set; }
        public string publishDate { get; set; }
        public UserList owner { get; set; } 

    }
}
