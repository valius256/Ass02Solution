using BusinessObject.Models;
using DataAccessObject;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddOrderDetail(orderDetail);

        public void DeleteByProduct(int productId) => OrderDetailDAO.Instance.DeleteByProduct(productId);

        public void DeleteOrderDetails(int orderId) => OrderDetailDAO.Instance.DeleteOrderDetails(orderId);

        public IEnumerable<OrderDetail> GetOrderDetails(int orderId) => OrderDetailDAO.Instance.GetOrderDetails(orderId);

        public decimal GetOrderTotal(int orderId) => OrderDetailDAO.Instance.GetOrderTotal(orderId);
    }
}
