namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class CartItem : Entity<CartItem>
    {
        protected override void OnInserting(ref string sql)
        {
            sql += "; UPDATE [Cart] Set ItemCount = ItemCount + 1 WHERE Id = " + this.CartId + ";";
        }

        protected override void OnDeleting(ref string sql)
        {
            sql += "; UPDATE [Cart] Set ItemCount = ItemCount - 1 WHERE Id = " + this.CartId + ";";
        }
	} 
}	
