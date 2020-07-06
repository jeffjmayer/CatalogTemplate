using System;
using System.Collections.Generic;

namespace Catalog.Api.Entities
{
    public class ApiOrder : ApiEntity
	{ 
        public ApiOrder()
        {
            OrderDetails = new List<ApiEntity>();
        }
        public ApiEntity User { get; set; }
        public DateTime? OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public int OrderNumber { get; set; }
        public int ItemCount { get; set; }
        public List<ApiEntity> OrderDetails { get; set; }
	} 
}	
