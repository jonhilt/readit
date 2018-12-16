using Readit.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Readit.Controllers
{
public class PostService
{
    private readonly ReadItContext dbContext;

    public PostService(ReadItContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public PostList List()
    {
        var posts = dbContext.Posts;

        var model = new PostList { Posts = new List<PostList.Post>() };
        foreach (var post in posts)
        {
            model.Posts.Add(new PostList.Post {
                Id = post.Id,
                Link = post.Link,
                PostedBy = post.PostedBy,
                Title = post.Title
            });
        }
        return model;
    }

    public PostDetails Details(int id)
    {
        var post = dbContext.Posts.FirstOrDefault(x => x.Id == id);

        return new PostDetails
        {
            Id = post.Id,
            Description = post.Description,
            Title = post.Title,
            PostedBy = post.PostedBy
        };
    }
}
}