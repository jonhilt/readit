using Microsoft.AspNetCore.Mvc;

namespace Readit.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService postService;

        public PostController(PostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            PostList posts = postService.List();
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            PostDetails details = postService.Details(id);
            return View(details);
        }
    }
}