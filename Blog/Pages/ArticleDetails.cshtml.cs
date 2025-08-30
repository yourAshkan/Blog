using Blog.Context;
using Blog.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class ArticleDetailsModel(BlogContext _context) : PageModel
    {
        public ArticleViewModel Article { get; set; }
        public void OnGet(int id)
        {
            Article = _context.Articles.Select(x => new ArticleViewModel
            {
               Id = x.Id,
               Title = x.Title,
               Picture = x.Picture,
               PictureALT = x.PictureALT,
               PictureTitle = x.PictureTitle,
               Description = x.Description
            }).FirstOrDefault(x=>x.Id == id);
        }
    }
}
