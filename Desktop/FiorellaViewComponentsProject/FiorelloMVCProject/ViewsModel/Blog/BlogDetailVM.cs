namespace FiorelloMVCProject.ViewsModel.Blog
{
    public class BlogDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string TeacherName { get; set; }
        public BlogImageUIVM BlogImage { get; set; }
    }
}
