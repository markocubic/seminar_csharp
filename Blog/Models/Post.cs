using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        [Required, StringLength(60)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual User User { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}