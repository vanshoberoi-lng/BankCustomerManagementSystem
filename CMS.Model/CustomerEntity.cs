namespace CMS.Model
{
    public class CustomerEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string CustomerType { get; set; } = "Standard"; // Standard or VIP
        public string Email { get; set; } = string.Empty;
        public decimal CurrentBalance { get; set; }
    }
}
