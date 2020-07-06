using System.Collections.Generic;

namespace Catalog.Api.Entities
{
    public class ApiParticipant : ApiEntity
	{ 
        public ApiParticipant()
        {
            Products = new List<ApiEntity>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LifeSpan { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int TotalProducts { get; set; }
        public List<ApiEntity> Products { get; set; }
	} 
}	

