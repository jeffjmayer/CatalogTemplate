	
using System;

namespace Catalog.Domain
{
    // Domain objects
	
    public partial class Participant
    {
		public Participant() { }
        public Participant(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LifeSpan { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int TotalProducts { get; set; }
    }
	
    public partial class Cart
    {
		public Cart() { }
        public Cart(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public string Cookie { get; set; }
        public DateTime? CartDate { get; set; }
        public int ItemCount { get; set; }
    }
	
    public partial class CartItem
    {
		public CartItem() { }
        public CartItem(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int? CartId { get; set; }
        public int? ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
	
    public partial class Error
    {
		public Error() { }
        public Error(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string Everything { get; set; }
        public string HttpReferer { get; set; }
        public string PathAndQuery { get; set; }
    }
	
    public partial class Order
    {
		public Order() { }
        public Order(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public int OrderNumber { get; set; }
        public int ItemCount { get; set; }
    }
	
    public partial class OrderDetail
    {
		public OrderDetail() { }
        public OrderDetail(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
	
    public partial class OrderNumber
    {
		public OrderNumber() { }
        public OrderNumber(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int Number { get; set; }
    }
	
    public partial class Product
    {
		public Product() { }
        public Product(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParticipantId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double AvgStars { get; set; }
    }
	
    public partial class Rating
    {
		public Rating() { }
        public Rating(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int Stars { get; set; }
    }
	
    public partial class User
    {
		public User() { }
        public User(bool defaults) : base(defaults) { }

        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? SignupDate { get; set; }
        public int OrderCount { get; set; }
    }
}
