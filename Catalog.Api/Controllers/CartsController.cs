using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class CartsController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiCart> Get(string expand = "")
        {
            return new List<ApiCart>();
        }

        // GET Single

        [HttpGet]
        public ApiCart Get(int? id, string expand = "")
        {
            return new ApiCart();
        }

        // POST = Insert

        [HttpPost]
        public ApiCart Post([FromBody] ApiCart apicart)
        {
            return apicart;
        }

        // PUT = Update

        [HttpPut]
        public ApiCart Put(int? id, [FromBody] ApiCart apicart)
        {
            return apicart;
        }

        // DELETE

        [HttpDelete]
        public ApiCart Delete(int? id)
        {
			return new ApiCart();
        }
    }
}
