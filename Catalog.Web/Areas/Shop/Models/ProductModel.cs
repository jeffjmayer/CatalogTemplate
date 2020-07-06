using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.Web.Areas.Shop.Models
{

    public class ProductModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string AvgStars { get; set; }

        public int? ParticipantId { get; set; }
        public string ParticipantLastName { get; set; }

        public ParticipantModel Participant { get; set; }
    }
}