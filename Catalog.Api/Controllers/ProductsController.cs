using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Catalog.Domain;
using AutoMapper;
using Catalog.Api.Entities;

namespace Catalog.Api.Controllers
{
    // Change code for each method

    public class ProductsController : BaseApiController
    {

        // GET Collection

        [HttpGet]
        public IEnumerable<ApiProduct> Get(string expand = null, string filter = null, string sort = null, int page = 1, int pagesize = 20)
        {
            var products = ParticipantContext.Products.All();
            var apiproducts = Mapper.Map<IEnumerable<Product>, IEnumerable<ApiProduct>>(products).ToList();

            int index = 0;
            if (expand != null && expand.ToLower() == "Participant")
            {
                var Participants = ParticipantContext.Participants.All().ToDictionary(a => a.Id);
                foreach (var product in products)
                {
                    var Participant = Participants[product.ParticipantId];
                    apiproducts[index].Participant = Mapper.Map<Participant, ApiParticipant>(Participant);

                    //each Participant itself has a product collection
                    foreach (var prod in products)
                    {
                        if (prod.ParticipantId == product.ParticipantId)
                        {
                            (apiproducts[index].Participant as ApiParticipant).Products.Add(new ApiEntity { Href = prod.Id.ToProductHref() });
                        }
                    }

                    index++;
                }
            }
            else
            {
                // only hold Participant reference
                foreach (var product in products)
                {
                    apiproducts[index++].Participant = new ApiEntity { Href = product.ParticipantId.ToParticipantHref() };
                }
            }
            return apiproducts;
        }

        // GET Single instance

        [HttpGet]
        public ApiProduct Get(int? id, string expand = null)
        {
            var product = ParticipantContext.Products.Single(id);
            var apiproduct = Mapper.Map<Product, ApiProduct>(product);

            if (expand != null && expand.ToLower() == "Participant")
            {
                var Participant = ParticipantContext.Participants.Single(product.ParticipantId);
                apiproduct.Participant = Mapper.Map<Participant, ApiParticipant>(Participant);

                var products = ParticipantContext.Products.All(@where: "ParticipantId = @0", parms: Participant.Id);
                foreach (var prod in products)
                    (apiproduct.Participant as ApiParticipant).Products.Add(new ApiEntity { Href = prod.Id.ToProductHref() });
            }
            else
            {
                apiproduct.Participant = new ApiEntity { Href = product.ParticipantId.ToParticipantHref() };
            }

            return apiproduct;
        }

        // POST = Insert

        [HttpPost]
        public ApiProduct Post([FromBody] ApiProduct apiproduct)
        {
            var product = Mapper.Map<ApiProduct, Product>(apiproduct, new Product(true));
            product.ParticipantId = apiproduct.Participant.Href.ToId();

            if (product.IsValid)
            {
                ParticipantContext.Products.Insert(product);
                apiproduct.Href = product.Id.ToProductHref();
                return apiproduct;
            }
            return null;
        }

        // PUT = Update

        [HttpPut]
        public ApiProduct Put(int? id, [FromBody] ApiProduct apiproduct)
        {
            var product = Mapper.Map<ApiProduct, Product>(apiproduct);
            product.ParticipantId = apiproduct.Participant.Href.ToId();

            if (product.IsValid)
            {
                ParticipantContext.Products.Update(product);
                return apiproduct;
            }

            return null;
        }

        // DELETE

        [HttpDelete]
        public ApiProduct Delete(int? id)
        {
            var product = ParticipantContext.Products.Single(id);
            ParticipantContext.Products.Delete(product);

            return Mapper.Map<Product, ApiProduct>(product);
        }
    }
}
