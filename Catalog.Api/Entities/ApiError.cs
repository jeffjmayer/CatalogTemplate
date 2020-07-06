using System;

namespace Catalog.Api.Entities
{
    public class ApiError : ApiEntity
	{ 
        public ApiEntity User { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string Everything { get; set; }
        public string HttpReferer { get; set; }
        public string PathAndQuery { get; set; }
	} 
}	
