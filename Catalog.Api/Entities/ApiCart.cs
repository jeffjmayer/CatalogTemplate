using System;
using System.Collections.Generic;

namespace Catalog.Api.Entities
{
    public class ApiCart : ApiEntity
	{ 
        public ApiCart()
        {
            CartItems = new List<ApiEntity>();
        }
        public string Cookie { get; set; }
        public DateTime? CartDate { get; set; }
        public int ItemCount { get; set; }
        public List<ApiEntity> CartItems { get; set; }
	} 
}	
