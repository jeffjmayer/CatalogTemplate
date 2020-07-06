namespace Catalog.Api.Entities
{
  

    public class ApiOrderDetail : ApiEntity
	{ 
        public ApiEntity Order { get; set; }
        public ApiEntity Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
	} 
}	
