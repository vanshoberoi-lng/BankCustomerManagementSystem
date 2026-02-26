namespace CMS.Contracts
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal InitialDeposit { get; set; }
    }
}
