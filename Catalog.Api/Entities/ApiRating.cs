namespace Catalog.Api.Entities
{
    public class ApiRating : ApiEntity
	{ 
        public ApiEntity User { get; set; }
        public ApiEntity Product { get; set; }
        public int Stars { get; set; }
	} 
}	
