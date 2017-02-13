using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Dto
{
    public class ReviewDto
    {
        public long user_id { get; set; }
        public long item_id { get; set; }
        public int rating { get; set; }
        public string text { get; set; }
    }
}
