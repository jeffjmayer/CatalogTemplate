using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class RatingsController : BaseApiController
    {
        // GET Collection

        [HttpGet]
        public IEnumerable<ApiRating> Get(string expand = "")
        {
            return new List<ApiRating>();
        }

        // GET Single

        [HttpGet]
        public ApiRating Get(int? id, string expand = "")
        {
            return new ApiRating();
        }

        // POST = Insert

        [HttpPost]
        public ApiRating Post([FromBody] ApiRating apirating)
        {
            return apirating;
        }

        // PUT = Update

        [HttpPut]
        public ApiRating Put(int? id, [FromBody] ApiRating apirating)
        {
            return apirating;
        }

        // DELETE

        [HttpDelete]
        public ApiRating Delete(int? id)
        {
			return new ApiRating();
        }
    }
}
