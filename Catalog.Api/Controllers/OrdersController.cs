using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class OrdersController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiOrder> Get(string expand = "")
        {
            return new List<ApiOrder>();
        }

        // GET Single

        [HttpGet]
        public ApiOrder Get(int? id, string expand = "")
        {
            return new ApiOrder();
        }

        // POST = Insert

        [HttpPost]
        public ApiOrder Post([FromBody] ApiOrder apiorder)
        {
            return apiorder;
        }

        // PUT = Update

        [HttpPut]
        public ApiOrder Put(int? id, [FromBody] ApiOrder apiorder)
        {
            return apiorder;
        }

        // DELETE

        [HttpDelete]
        public ApiOrder Delete(int? id)
        {
			return new ApiOrder();
        }
    }
}
