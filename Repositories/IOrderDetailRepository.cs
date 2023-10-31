using BusinessObject.Models;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail orderDetail);
        public decimal GetOrderTotal(int orderId);
        public IEnumerable<OrderDetail> GetOrderDetails(int orderId);
        public void DeleteOrderDetails(int orderId);
        public void DeleteByProduct(int productId);
    }
}
