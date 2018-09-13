using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment29thAugust.Models
{
    public class SearchFilter
    {
        public string text { get; set; }
        public string searchBy { get; set; }
        public string sortBy { get; set; }
        public double minRange { get; set; }
        public double maxRange { get; set; }
    }
}
