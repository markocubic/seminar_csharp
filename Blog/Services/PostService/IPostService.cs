using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services.PostService
{
    interface IPostService
    {
        Task<List<Post>> GetPosts();
        Post GetBlogPostByUrl(string id);
        void CreatePost(Post post);
    }
}
