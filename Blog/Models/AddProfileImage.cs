using Microsoft.AspNetCore.Http;

namespace Blog.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterStatus { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

    }
}
