using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly DataContext _context;

        public PostService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Post>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }
        public Post GetBlogPostByUrl(string url)
        {
            return _context.Posts.FirstOrDefault(p => p.Id.ToString().Equals(url));
        }
        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}
