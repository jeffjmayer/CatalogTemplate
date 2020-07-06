namespace Catalog.Test.Entities
{
    public class ClientOrderDetail
	{
        public string Href { get; set; }
        public ClientOrder Order { get; set; }
        public ClientProduct Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
	} 
}	
