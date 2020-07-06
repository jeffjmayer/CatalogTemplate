using System.Linq;

namespace Catalog.Domain.Repository
{
    // Add custom code inside partial class

    public class OrderNumbers : Repository<OrderNumber> 
	{
        public int Next()
        {
            // default is autocommit, so this is a single transaction

            var on = Query("UPDATE [OrderNumber] SET Number = Number + 1; SELECT Number FROM [OrderNumber];").ToList();
            return on[0].Number;
        }
	}
}	
