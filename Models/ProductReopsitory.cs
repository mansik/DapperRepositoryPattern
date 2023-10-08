using Dapper;
using DapperRepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern
{
    internal class ProductReopsitory : IProductRepository
    {
        public bool Delete(string productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            //var db = new SqlConnection(AppConnection.ConnectionString);
            //using IDbConnection db = new SqlConnection(AppConnection.ConnectionString); // using 선언은 C# 8.0 이상에서 사용
            using IDbConnection connection = AppConnection.GetConnection();    
            var sql = @"select ProductId, ProductName, UnitPrice from Products;";
            return connection.Query<Product>(sql);
        }

        public bool Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
