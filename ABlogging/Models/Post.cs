using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABlogging.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostAuthor { get; set; }
        //[add data annoations]
        public DateTime PostDate { get; set; }
    }
}
