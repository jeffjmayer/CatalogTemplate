using System.Collections.Generic;

namespace Catalog.Test.Entities
{
    public class ClientProduct 
	{
        public ClientProduct()
        {
            OrderDetails = new List<ClientOrderDetail>();
        }
        public string Href { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ClientParticipant Participant { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double AvgStars { get; set; }
        public int QuantitySold { get; set; }
        public List<ClientOrderDetail> OrderDetails { get; set; }
	} 
}	
