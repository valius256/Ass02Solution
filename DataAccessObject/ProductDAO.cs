﻿using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessDAO
{
    public class ProductDAO
    {
        // Singleton
        private static ProductDAO instance;
        private static object instanceLock = new object();

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProductsList(bool order = false)
        {
            IEnumerable<Product> products = null;

            try
            {
                var context = new SalesManagementContext();
                // Get From Database
                if (order)
                {
                    // Get Units In Stock > 0
                    products = context.Products
                            .Where(pro => pro.UnitInStock > 0)
                            .Include(pro => pro.CategoryId);
                }
                else
                {
                    products = context.Products
                            .Include(pro => pro.CategoryId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return products;
        }

        public Product GetProduct(int productId, IEnumerable<Product> searchList = null)
        {
            Product product = null;

            try
            {
                if (searchList == null)
                {
                    var context = new SalesManagementContext();
                    product = context.Products.SingleOrDefault(pro => pro.ProductId == productId);
                }
                else
                {
                    product = searchList.SingleOrDefault(pro => pro.ProductId == productId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return product;
        }

        public Product GetProduct(string productName, IEnumerable<Product> searchList = null)
        {
            Product product = null;

            try
            {
                if (searchList == null)
                {
                    var context = new SalesManagementContext();
                    product = context.Products.SingleOrDefault(pro => pro.ProductName.Equals(productName));
                }
                else
                {
                    product = searchList.SingleOrDefault(pro => pro.ProductName.Equals(productName));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return product;
        }

        public int GetNextProductId()
        {
            int nextMemberId = -1;

            try
            {
                var context = new SalesManagementContext();
                nextMemberId = context.Products.Max(pro => pro.ProductId) + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return nextMemberId;
        }
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product is undefined!!");
            }
            try
            {
                if (GetProduct(product.ProductId) == null)
                {
                    var context = new SalesManagementContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product is existed!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product is undefined!!");
            }
            try
            {
                Product _mem = GetProduct(product.ProductId);
                if (_mem != null)
                {
                    var context = new SalesManagementContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Delete(int productId)
        {
            try
            {
                Product Product = GetProduct(productId);
                if (Product != null)
                {
                    var context = new SalesManagementContext();
                    context.Products.Remove(Product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Product> SearchProduct(string name, IEnumerable<Product> searchList)
        {
            IEnumerable<Product> searchResult = null;

            try
            {
                if (searchList == null)
                {
                    var context = new SalesManagementContext();
                    searchResult = context.Products
                                        .Where(pro => pro.ProductName.ToLower().Contains(name.ToLower()))
                                        .Include(pro => pro.ProductId);
                }
                else
                {
                    searchResult = searchList.Where(pro => pro.ProductName.ToLower().Contains(name.ToLower()));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchResult;
        }

        public IEnumerable<Product> SearchProduct(int startUnit, int endUnit, IEnumerable<Product> searchList = null)
        {
            IEnumerable<Product> searchResult = null;

            try
            {
                if (searchList == null)
                {
                    var context = new SalesManagementContext();
                    searchResult = context.Products
                                    .Where(pro => pro.UnitInStock >= startUnit && pro.UnitInStock <= endUnit)
                                    .Include(pro => pro.ProductId);
                }
                else
                {
                    searchResult = searchList.Where(pro => pro.UnitInStock >= startUnit && pro.UnitInStock <= endUnit);
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return searchResult;
        }

        public IEnumerable<Product> SearchProduct(decimal startPrice, decimal endPrice, IEnumerable<Product> searchList = null)
        {
            IEnumerable<Product> searchResult = null;

            try
            {
                if (searchList == null)
                {
                    var context = new SalesManagementContext();
                    searchResult = context.Products
                                        .Where(pro => pro.UnitPrice >= startPrice && pro.UnitPrice <= endPrice)
                                        .Include(pro => pro.ProductId);
                }
                else
                {
                    searchResult = searchList.Where(pro => pro.UnitPrice >= startPrice && pro.UnitPrice <= endPrice);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return searchResult;
        }
    }
}
