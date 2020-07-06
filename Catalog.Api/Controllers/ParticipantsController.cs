using System.Collections.Generic;
using System.Web.Http;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class ParticipantsController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiParticipant> Get(string expand = "")
        {
            return new List<ApiParticipant>();
        }

        // GET Single

        [HttpGet]
        public ApiParticipant Get(int? id, string expand = "")
        {
            return new ApiParticipant();
        }

        // POST = Insert

        [HttpPost]
        public ApiParticipant Post([FromBody] ApiParticipant apiParticipant)
        {
            return apiParticipant;
        }

        // PUT = Update

        [HttpPut]
        public ApiParticipant Put(int? id, [FromBody] ApiParticipant apiParticipant)
        {
            return apiParticipant;
        }

        // DELETE

        [HttpDelete]
        public ApiParticipant Delete(int? id)
        {
			return new ApiParticipant();
        }
    }
}
