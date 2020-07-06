using System;

namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class Cart : Entity<Cart>
    {
        protected override void OnInserting(ref string sql)
        {
            if (CartDate == null) CartDate = DateTime.Now;
        }
	} 
}	
