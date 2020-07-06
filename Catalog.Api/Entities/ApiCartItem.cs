namespace Catalog.Api.Entities
{
    public class ApiCartItem : ApiEntity
	{ 
        public ApiEntity Cart { get; set; }
        public ApiEntity Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
	} 
}	
