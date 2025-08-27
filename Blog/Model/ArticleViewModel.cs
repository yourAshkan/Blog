namespace Blog.Model
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }  
        public string? Picture { get; set; } 
        public string? PictureALT { get; set; }
        public string? PictureTitle { get; set; }   
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }  
        public string? CreationDate { get; set; } 
    }
}
