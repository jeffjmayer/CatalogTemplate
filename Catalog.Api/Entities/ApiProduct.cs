using System.Collections.Generic;

namespace Catalog.Api.Entities
{
    public class ApiProduct : ApiEntity
    { 
        public ApiProduct()
        {
            OrderDetails = new List<ApiEntity>();
            Ratings = new List<ApiEntity>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public ApiEntity Participant { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double AvgStars { get; set; }
        public List<ApiEntity> OrderDetails { get; set; }
        public List<ApiEntity> Ratings { get; set; }
    } 
}	
