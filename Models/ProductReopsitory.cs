using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern.Models
{
    internal class ProductReopsitory : IGenericRepository<Product>
    {
        readonly IDbConnection _connection;
        public ProductReopsitory()
        {
            _connection = AppConnection.GetConnection();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product>? GetAll()
        {
            var sql = @"select ProductId, ProductName, UnitPrice from Products;";
            return _connection.Query<Product>(sql);
        }

        public Product? GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
