using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime CommentDate { get; set; }
        public Comment()
        {
            CommentDate = DateTime.Now;
        }
        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
