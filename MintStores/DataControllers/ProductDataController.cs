using Dapper;
using MintStores.Constants;
using MintStores.Interfaces;
using MintStores.Interfaces.DataController;
using MintStores.Interfaces.Services;
using MintStores.Models;
using System.Data;

namespace MintStores.DataControllers
{
    public class ProductDataController : BaseDataController<Product>, IProductDataController
    {
        public ProductDataController(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<Product> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.Query<Product>(DataBaseConstants.GetAllProducts, commandType: CommandType.StoredProcedure);
        }

        public override Product GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { ProductId = id };
            return connection.QueryFirstOrDefault<Product>(DataBaseConstants.GetProductById, parameters, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Product newItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                newItem.ProductName,
                newItem.BrandId,
                newItem.CategoryId,
                newItem.ModelYear,
                newItem.Price,
                newItem.ProdurtURL
            };

            var rows = connection.Execute(DataBaseConstants.CreateProduct, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Product updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                updatedItem.ProductId,
                updatedItem.ProductName,
                updatedItem.BrandId,
                updatedItem.CategoryId,
                updatedItem.ModelYear,
                updatedItem.Price,
                updatedItem.ProdurtURL
            };

            var rows = connection.Execute(DataBaseConstants.UpdateProduct, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { ProductId = id };
            var rows = connection.Execute(DataBaseConstants.DeleteProduct, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override Product GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<Product>(DataBaseConstants.GetLastProduct, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { CategoryId = categoryId };
            return connection.Query<Product>(DataBaseConstants.GetProductsByCategory, parameters, commandType :CommandType.StoredProcedure);
        }
    }
}
