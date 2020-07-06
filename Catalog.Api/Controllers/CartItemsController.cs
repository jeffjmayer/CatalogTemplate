using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class CartItemsController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiCartItem> Get(string expand = "")
        {
            return new List<ApiCartItem>();
        }

        // GET Single

        [HttpGet]
        public ApiCartItem Get(int? id, string expand = "")
        {
            return new ApiCartItem();
        }

        // POST = Insert

        [HttpPost]
        public ApiCartItem Post([FromBody] ApiCartItem apicartitem)
        {
            return apicartitem;
        }

        // PUT = Update

        [HttpPut]
        public ApiCartItem Put(int? id, [FromBody] ApiCartItem apicartitem)
        {
            return apicartitem;
        }

        // DELETE

        [HttpDelete]
        public ApiCartItem Delete(int? id)
        {
			return new ApiCartItem();
        }
    }
}
