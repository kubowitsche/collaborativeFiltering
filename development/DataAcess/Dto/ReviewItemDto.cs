using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DataAcess.Dto
{
    public class ReviewItemDto
    {
        public ObjectId _id { get; set; }
        public long review_item_id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public string description { get; set; }
    }
}
