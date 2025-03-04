namespace Cybersecurity.MVC.Models
{
    public class About
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<String> Tags { get; set; } = [];
    }
}
