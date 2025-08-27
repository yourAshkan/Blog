using Blog.Context;
using Blog.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Blog.Pages
{
    public class IndexModel(BlogContext _context) : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        
        public async Task OnGetAsync()
        {
            Articles = await _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureALT = x.PictureALT,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,

            }).OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
