namespace Blazor
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Status { get; set; }
        public int SellerId { get; set; }
        public int RealtorId { get; set; }
        public Seller Seller { get; set; }
        public Realtor Realtor { get; set; }
    }
}
