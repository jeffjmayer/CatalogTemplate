using System;

namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class User : Entity<User> 
	{
        public string FullName { get { return FirstName + " " + LastName; } }

        protected override void OnInserting(ref string sql)
        {
            if (SignupDate == null) SignupDate = DateTime.Now;
        }

        protected override void Validate()
        {
            // examples

            //ValidateLength(this.FirstName, "FirstName is too short");
            //ValidateExistence(this.LastName);
            //ValidateEmail(Email);
        }
	} 
}	
