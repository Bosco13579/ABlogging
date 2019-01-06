using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABlogging.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public string CommentAuthor { get; set; }
        //[add data annotations]
        public DateTime CommentDate { get; set; }

        public virtual Post ThePost { get; set; }
    }
}
