namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class Order : Entity<Order>
    {
        protected override void OnInserting(ref string sql)
        {
            sql += "; UPDATE [User] Set OrderCount = OrderCount + 1 WHERE Id = " + this.UserId + ";";
        }

        protected override void OnDeleting(ref string sql)
        {
            sql += "; UPDATE [User] Set OrderCount = OrderCount - 1 WHERE Id = " + this.UserId + ";";
        }
	} 
}	
