using System.Collections.Generic;

namespace Catalog.Test.Entities
{
    public class ClientParticipant 
	{
        public ClientParticipant()
        {
            Products = new List<ClientProduct>();
        }
        public string Href { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LifeSpan { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int TotalProducts { get; set; }
        public List<ClientProduct> Products { get; set; }
	} 
}	
