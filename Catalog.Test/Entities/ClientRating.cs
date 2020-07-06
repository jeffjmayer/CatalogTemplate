namespace Catalog.Test.Entities
{
    public class ClientRating
	{
        public string Href { get; set; }
        public ClientUser User { get; set; }
        public ClientProduct Product { get; set; }
        public int Stars { get; set; }
	} 
}	
