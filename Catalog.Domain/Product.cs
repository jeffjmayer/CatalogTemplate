namespace Catalog.Domain
{
    // Add custom code inside partial class

    public partial class Product : Entity<Product> 
	{
        protected override void Validate()
        {
            // simple validation rules

            if (string.IsNullOrEmpty(Title)) Errors.Add("0001", "Title is required");
            if (string.IsNullOrEmpty(Image)) Errors.Add("0002", "Image is required");

            if (Title.Length > 100) Errors.Add("0003", "Title cannot be longer than 100 characters");
            if (!string.IsNullOrEmpty(Description) && Description.Length > 250) Errors.Add("0004", "Description cannot be longer than 250 characters");

            if (ParticipantId == null || ParticipantId < 0) Errors.Add("0005", "Invalid ParticipantId");

            if (Price < 0) Errors.Add("0006", "Price cannot be negative");
            if (AvgStars < 0) Errors.Add("0007", "Avg Stars cannot be negative");
            if (QuantitySold < 0) Errors.Add("0008", "QuantitySold cannot be negative");
        }
	} 
}	
