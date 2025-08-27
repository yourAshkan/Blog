using Blog.Context;
using Blog.Model.Entity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class CreateArticleModel(BlogContext _context) : PageModel
    {
        public CreateArticle Command { get; set; }

        public void OnGet()
        {
        }
        public void OnPost(CreateArticle command)
        {
            var article = new Article(command.Title, command.Picture, command.PictureALT, command.PictureTilte, command.ShortDescription, command.Description);


            _context.Add(article);
            _context.SaveChanges();

            ViewData["Success"] = "مقاله با موفقیت ذخیره شد";
        }
    }
}
