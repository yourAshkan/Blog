namespace Blog.Model.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; private set; }
        public string? Picture { get; private set; }
        public string? PictureALT { get; private set; }
        public string? PictureTitle { get; private set; }
        public string? ShortDescription { get; private set; }
        public string? Description { get; private set; }
        public DateTime? CreationDate { get; private set; }
        public string? PictureTilte { get; }
        public bool IsDeleted { get; set; }

        public Article()
        {

        }

        public Article(string? title, string? picture, string? pictureALT, string? pictureTilte, string? shortDescription,string? description)
        {
            Title = title;
            Picture = picture;
            PictureALT = pictureALT;
            PictureTilte = pictureTilte;
            ShortDescription = shortDescription;
            Description = description;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
