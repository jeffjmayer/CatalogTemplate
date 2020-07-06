using System.Collections.Generic;

namespace Catalog.Test.Entities
{
    public class ClientUser
	{
        public ClientUser()
        {
            Orders = new List<ClientOrder>();
        }
        public string Href { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int OrderCount { get; set; }
        public List<ClientOrder> Orders { get; set; }
	} 
}	
