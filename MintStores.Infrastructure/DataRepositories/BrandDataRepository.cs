using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;

namespace MintStores.Infrastructure.DataRepositories
{
    public class BrandDataRepository : BaseDataRepository<Brand>
    {

        public BrandDataRepository(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<Brand> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();

            return connection.Query<Brand>(DataBaseConstants.GetAllBrands, commandType: CommandType.StoredProcedure);
        }

        public override Brand GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Brand>(DataBaseConstants.GetBrandById, new { Id = id }, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Brand newItem)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateBrand, new { newItem.BrandName }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Brand updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();


            var rows = connection.Execute(DataBaseConstants.UpdateBrand, new { Id = id, updatedItem.BrandName }, commandType: CommandType.StoredProcedure);

            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteBrand, new { Id = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override Brand GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.QueryFirstOrDefault<Brand>(
                DataBaseConstants.GetLastBrand,
                commandType: CommandType.StoredProcedure);

            return row;
        }

    }
}
