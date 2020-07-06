namespace Catalog.Domain
{
	// Unit-of-Work

	public class IaSUnitOfWork : UnitOfWork
    {
        public IaSUnitOfWork() : base(new IaSdb()) { }
    }
}
