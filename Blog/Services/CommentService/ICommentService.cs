using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services.CommentService
{
    interface ICommentService
    {
        List<Comment> GetCommentsByPostId(string url);
        void CreateComment(Comment comment);
    }
}
