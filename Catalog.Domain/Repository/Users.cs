namespace Catalog.Domain.Repository
{
    // Add custom code inside partial class

    public class Users : Repository<User>
    {
        public virtual User ByEmail(string email)
        {
            return Single(where: "Email = @0", parms: email);
        }
	}
}	
