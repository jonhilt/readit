using System.Collections.Generic;

namespace Readit.Controllers
{
    public class PostList
    {
        public List<Post> Posts { get; set; }

        public class Post
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Link { get; set; }
            public string PostedBy { get; set; }
        }
    }
}