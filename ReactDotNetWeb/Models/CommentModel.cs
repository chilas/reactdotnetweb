namespace ReactDotNetWeb.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CommentModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}
