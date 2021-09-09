using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly DataContext _context;
        public CommentService(DataContext context)
        {
            _context = context;
        }
        public List<Comment> GetCommentsByPostId(string id)
        {
            return _context.Comments.Where(c => c.Post.Id.ToString().Equals(id)).ToList();
        }
        public Comment GetCommentById(Guid id)
        {
            return _context.Comments.SingleOrDefault(a => a.Id.Equals(id));
        }
        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
        public void DeleteComment(Guid id)
        {
            Comment comment = GetCommentById(id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}
