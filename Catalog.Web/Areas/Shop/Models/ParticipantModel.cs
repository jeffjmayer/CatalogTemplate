using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.Web.Areas.Shop.Models
{
    public class ParticipantModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LifeSpan { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int TotalProducts { get; set; }
    }
}