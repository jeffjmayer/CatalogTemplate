namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class Entity<T> where T : Entity<T>, new()
	{
	}
}
