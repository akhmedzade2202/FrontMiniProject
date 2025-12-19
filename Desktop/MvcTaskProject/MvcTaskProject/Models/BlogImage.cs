namespace MvcTaskProject.Models
{
    public class BlogImage : BaseEntity
    {
        public string Image { get; set; }

        public bool Ismain { get; set; } = false;

        public int BlogId { get; set; }

        public string Blog { get; set; }
    }
}
