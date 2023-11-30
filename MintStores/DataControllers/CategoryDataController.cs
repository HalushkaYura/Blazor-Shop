using Dapper;
using MintStores.Constants;
using MintStores.Models;
using System.Data;

namespace MintStores.DataControllers
{
    public class CategoryDataController : BaseDataController<Category>
    {

        public CategoryDataController(IConfiguration configuration) : base(configuration)
        {

        }

        public override IEnumerable<Category> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();

            return connection.Query<Category>(DataBaseConstants.GetAllCategories, commandType: CommandType.StoredProcedure);
        }
        public override Category GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.QueryFirstOrDefault<Category>(
                DataBaseConstants.GetLastCategory,
                commandType: CommandType.StoredProcedure);

            return row;
        }
        public override Category GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Category>(DataBaseConstants.GetCategoryById, new { Id = id }, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Category newItem)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateCategory, new { newItem.CategoryName }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Category updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();

            // Assuming you have an UPDATE stored procedure for categories
            var rows = connection.Execute(DataBaseConstants.UpdateCategory, new { Id = id, updatedItem.CategoryName }, commandType: CommandType.StoredProcedure);

            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteCategory, new { Id = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }




    }
}
