using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;


namespace Blog.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly DataContext _context;
        public CommentService(DataContext context)
        {
            _context = context;
        }
        public List<Comment> GetCommentsByPostId(string url)
        {
            //return _context.Comments.Where(c => c.Post.Id.ToString().Equals(url));
            return (List<Comment>)_context.Comments.Where(c => c.Post.Id.ToString().Equals(url)).ToList();
        }
        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
