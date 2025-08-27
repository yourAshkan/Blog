using Blog.Context;
using Blog.Model;
using Blog.Model.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class CreateArticleModel(BlogContext _context) : PageModel
    {
        public CreateArticle Command { get; set; }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {

                var article = new Article(command.Title, command.Picture, command.PictureALT, command.PictureTilte, command.ShortDescription, command.Description);


                _context.Add(article);
                _context.SaveChanges();
                return RedirectToPage("/Index");

            }
            else
            {
                TempData["Error"] = "لطفا مقادیر خواسته شده را تکمیل کنید";
                return RedirectToPage();
            }
        }
    }
}
