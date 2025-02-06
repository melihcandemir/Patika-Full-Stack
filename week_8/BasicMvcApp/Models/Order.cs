// order class

namespace BasicMvcApp
{
    public class Order
    {
        public int Id { get; set; } // ürün benzersiz kimliği
        public string? ProductName { get; set; } // ürün adı
        public decimal Price { get; set; } // ürün fiyatı
        public int Quantity { get; set; } // sipariş edilen ürün miktarı
    }
}