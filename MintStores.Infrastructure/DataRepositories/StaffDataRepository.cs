using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;

namespace MintStores.Infrastructure.DataRepositories
{
    public class StaffDataRepository : BaseDataRepository<Staff>
    {
        public StaffDataRepository(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<Staff> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.Query<Staff>(DataBaseConstants.GetAllStaffs, commandType: CommandType.StoredProcedure);
        }

        public override Staff GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { StaffId = id };
            return connection.QueryFirstOrDefault<Staff>(DataBaseConstants.GetStaffById, parameters, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Staff newItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                newItem.FirstName,
                newItem.LastName,
                newItem.Email,
                newItem.Phone,
                newItem.Active,
                newItem.StoreId,
                newItem.ManagerId
            };

            var rows = connection.Execute(DataBaseConstants.CreateStaff, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Staff updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                updatedItem.StaffId,
                updatedItem.FirstName,
                updatedItem.LastName,
                updatedItem.Email,
                updatedItem.Phone,
                updatedItem.Active,
                updatedItem.StoreId,
                updatedItem.ManagerId
            };

            var rows = connection.Execute(DataBaseConstants.UpdateStaff, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { StaffId = id };
            var rows = connection.Execute(DataBaseConstants.DeleteStaff, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override Staff GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<Staff>(DataBaseConstants.GetLastStaff, commandType: CommandType.StoredProcedure);
        }
    }
}
