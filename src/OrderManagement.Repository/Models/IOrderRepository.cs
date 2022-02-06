using OrderManagement.Domain.Models;

namespace OrderManagement.Repository.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
