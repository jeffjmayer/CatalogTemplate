using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class OrderNumbersController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiOrderNumber> Get(string expand = "")
        {
            return new List<ApiOrderNumber>();
        }

        // GET Single

        [HttpGet]
        public ApiOrderNumber Get(int? id, string expand = "")
        {
            return new ApiOrderNumber();
        }

        // POST = Insert

        [HttpPost]
        public ApiOrderNumber Post([FromBody] ApiOrderNumber apiordernumber)
        {
            return apiordernumber;
        }

        // PUT = Update

        [HttpPut]
        public ApiOrderNumber Put(int? id, [FromBody] ApiOrderNumber apiordernumber)
        {
            return apiordernumber;
        }

        // DELETE

        [HttpDelete]
        public ApiOrderNumber Delete(int? id)
        {
			return new ApiOrderNumber();
        }
    }
}
