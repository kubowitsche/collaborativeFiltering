using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DataAcess.Dto
{
    public class ReccommendationDto
    {
        public ObjectId _id { get; set; }
        public long user_id { get; set; }
        public long item_id { get; set; }
        public float rating { get; set; }
    }
}
