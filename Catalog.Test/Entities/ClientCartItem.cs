namespace Catalog.Test.Entities
{
    public class ClientCartItem 
	{
        public string Href { get; set; }
        public ClientCart Cart { get; set; }
        public ClientProduct Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
	} 
}	
