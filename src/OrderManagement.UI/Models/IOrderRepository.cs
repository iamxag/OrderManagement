namespace OrderManagement.UI.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
