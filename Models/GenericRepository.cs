using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern.Models
{
    public class GenericRepository : IGenericRepository<Product>
    {
        readonly IDbConnection _connection;

        public GenericRepository()
        {
            _connection = AppConnection.GetConnection();
        }

        public bool Add(Product product)
        {

            throw new NotImplementedException();
        }

        public bool Delete(int productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product>? GetAll()
        {
            IEnumerable<Product>? result = null;
            try
            {
                var sql = @"select ProductId, ProductName, UnitPrice from Products;";
                result = _connection.Query<Product>(sql);
            }
            catch (Exception) { }
            return result;
        }

        public Product? GetById(int productID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
