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
        Comment GetCommentById(Guid id);
        void CreateComment(Comment comment);
        void DeleteComment(Guid id);
    }
}
