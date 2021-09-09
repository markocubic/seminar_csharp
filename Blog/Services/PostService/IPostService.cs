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
        List<Post> SearchPostsByTitle(string searchValue);
        void CreatePost(Post post);
        void EditPost(string url, Post post);
        void DeletePost(string url);

    }
}
