using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;
using System.Data.SqlClient;

namespace MintStores.Infrastructure.DataRepositories
{
    public class CustomerDataRepository : BaseDataRepository<Customer>
    {


        public CustomerDataRepository(IConfiguration configuration) : base(configuration)
        {
            
        }

        public override IEnumerable<Customer> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<Customer>(
                DataBaseConstants.GetAllCustomers,
                commandType: CommandType.StoredProcedure);

            return rows;
        }

        public override Customer GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.QueryFirst<Customer>(
                DataBaseConstants.GetCustomerById,
                new { Id = id },
                commandType: CommandType.StoredProcedure);

            return rows;
        }

        public override bool CreateItem(Customer customer)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(
                DataBaseConstants.CreateCustomer,
                new
                {
                    customer.FirstName,
                    customer.LastName,
                    customer.Phone,
                    customer.Email,
                    customer.Streat,
                    customer.City,
                    customer.State,
                    customer.Zipcode
                },
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }
        public override bool UpdateItem(int id, Customer updatedCustomer)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(
                DataBaseConstants.UpdateCustomer,
                new
                {
                    Id = id,
                    updatedCustomer.FirstName,
                    updatedCustomer.LastName,
                    updatedCustomer.Phone,
                    updatedCustomer.Email,
                    updatedCustomer.Streat,
                    updatedCustomer.City,
                    updatedCustomer.State,
                    updatedCustomer.Zipcode
                },
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Execute(
                DataBaseConstants.DeleteCustomer,
                new { Id = id },
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }
        public override Customer GetLastItem()
        {
            using var connection = GetConnection();
            var rows = connection.QueryFirst<Customer>(
                DataBaseConstants.GetLastCustomer,
                commandType: CommandType.StoredProcedure);

            return rows;
        }
    }
}
