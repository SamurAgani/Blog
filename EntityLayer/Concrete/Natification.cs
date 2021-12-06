using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Natification
    {
        [Key]
        public int Id { get; set; }
        public string NatificationType { get; set; }
        public string NatifationTypeSymbol { get; set; }
        public string NatifationDetails { get; set; }
        public DateTime NatificationDate { get; set; }
        public bool NatificationStatus { get; set; }
        public string NatificationColor { get; set; }
    }
}
