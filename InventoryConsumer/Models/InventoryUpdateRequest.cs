namespace InventoryConsumer.Models
{
    public class InventoryUpdateRequest
    {
        public int Id { get; set; }

        public required string ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
