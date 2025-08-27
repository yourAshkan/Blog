namespace Blog.Model.Entity
{
    public class Article(string title,string picture, string pictureAlt, string pictureTitle,string shortDescription,string description)
    {
        public int Id { get; set; }
        public string? Title { get; private set; } = title;
        public string? Picture { get; private set; } = picture;
        public string? PictureALT { get; private set; } = pictureAlt;
        public string? PictureTitle { get; private set; } = pictureTitle;
        public string? ShortDescription { get; private set; } = shortDescription;
        public string? Description { get; private set; } = description;
        public DateTime? CreationDate { get; private set; } = DateTime.Now;
    }
}
