using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Model
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage ="عنوان مقاله اجباری است!")]
        public string? Title { get; set; }

        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "عکس مقاله اجباری است!")]
        public string? Picture { get; set; }

        public string? PictureALT { get; set; }

        public string? PictureTilte { get; set; }

        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است!")]
        public string? ShortDescription { get; set; }

        [DisplayName("توضیحات")]
        [Required(ErrorMessage = "توضیحات مقاله اجباری است!")]
        public string? Description { get; set; }
    }
}
