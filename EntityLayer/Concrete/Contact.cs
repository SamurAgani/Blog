using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContentID { get; set; }
        public string ContentUserName { get; set; }
        public string ContentMail { get; set; }
        public string ContentSubject { get; set; }
        public string ContentMessage { get; set; }
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }
    }
}
