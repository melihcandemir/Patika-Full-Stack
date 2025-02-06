namespace BasicMvcApp.Models
{
    public class CustomerOrderViewModel
    {
        // Bir Customer nesnesi
        public Customer? Customers { get; set; }

        // Bir Order nesneleri listesi
        public List<Order>? Orders { get; set; }
    }
}
