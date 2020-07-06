namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class Participant : Entity<Participant> 
	{
        public string FullName { get { return FirstName + " " + LastName; } }
	} 
}	
