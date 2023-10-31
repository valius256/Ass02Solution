﻿using BusinessObject.Models;

namespace DataAccessObject
{
    public class OrderDAO
    {
        // Using Singleton Pattern
        private static OrderDAO instance = null;
        private static object instanceLock = new object();

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public Order AddOrder(Order order)
        {
            Order returnOrder = null;
            try
            {
                var context = new SalesManagementContext();
                context.Orders.Add(order);
                context.SaveChanges();
                returnOrder = order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public IEnumerable<Order> GetOrders(int memberId)
        {
            IEnumerable<Order> orders = null;

            try
            {
                var context = new SalesManagementContext();
                if (memberId > 0)
                {
                    orders = context.Orders.Where(or => or.MemberId == memberId);
                }
                else
                {
                    orders = context.Orders;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return orders;
        }
        public IEnumerable<Order> GetOrders(int memberId, DateTime startDate, DateTime endDate)
        {
            IEnumerable<Order> orders = null;

            try
            {
                var context = new SalesManagementContext();
                if (memberId > 0)
                {
                    orders = context.Orders.Where(or => or.MemberId == memberId &&
                            DateTime.Compare(or.OrderDate, startDate) >= 0 &&
                            DateTime.Compare(or.OrderDate, endDate) <= 0);
                }
                else
                {
                    orders = context.Orders.Where(or =>
                            DateTime.Compare(or.OrderDate, startDate) >= 0 &&
                            DateTime.Compare(or.OrderDate, endDate) <= 0);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return orders;
        }
        public Order GetOrder(int orderId)
        {
            Order order = null;

            try
            {
                var context = new SalesManagementContext();
                order = context.Orders.SingleOrDefault(or => or.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return order;
        }
        public void DeleteOrder(int orderId)
        {
            try
            {
                var context = new SalesManagementContext();
                context.Orders.Remove(GetOrder(orderId));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteByMember(int memberId)
        {
            try
            {
                IEnumerable<Order> orders = GetOrders(memberId);
                var context = new SalesManagementContext();
                foreach (var order in orders)
                {
                    context.Remove(order);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
