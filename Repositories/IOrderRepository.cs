using BusinessObject.Models;

namespace Repositories
{
    public interface IOrderRepository
    {
        public Order AddOrder(Order order);
        public IEnumerable<Order> GetOrders(int memberId);
        public IEnumerable<Order> GetOrders(int memberId, DateTime startDate, DateTime endDate);
        public void DeleteOrder(int orderId);
        public void DeleteByMember(int memberId);
    }
}
