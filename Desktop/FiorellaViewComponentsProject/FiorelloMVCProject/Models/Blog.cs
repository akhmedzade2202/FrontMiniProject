namespace FiorelloMVCProject.Models
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeacherName { get; set; }
        public ICollection<BlogImage> Images { get; set; }
    }
}
