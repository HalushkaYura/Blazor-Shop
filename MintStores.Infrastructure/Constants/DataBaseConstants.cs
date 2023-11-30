namespace MintStores.Constants
{
    public class DataBaseConstants
    {
        #region Brands

        public const string CreateBrand = "sp_Brands_CreateBrand";
        public const string UpdateBrand = "sp_Brands_UpdateBrand";
        public const string DeleteBrand = "sp_Brands_DeleteBrand";
        public const string GetAllBrands = "sp_Brands_GetAll";
        public const string GetBrandById = "sp_Brands_GetById";
        public const string GetLastBrand = "sp_Brands_GetLastBrand";

        #endregion

        #region Categories

        public const string CreateCategory = "sp_Categories_CreateCategory";
        public const string UpdateCategory = "sp_Categories_UpdateCategory";
        public const string DeleteCategory = "sp_Categories_DeleteCategory";
        public const string GetAllCategories = "sp_Categories_GetAll";
        public const string GetCategoryById = "sp_Categories_GetById";
        public const string GetLastCategory = "sp_Categories_GetLastCategory";

        #endregion

        #region Customers
        public const string CreateCustomer = "sp_Customers_CreateCustomer";
        public const string UpdateCustomer = "sp_Customers_UpdateCustomer";
        public const string DeleteCustomer = "sp_Customers_DeleteCustomer";
        public const string GetAllCustomers = "sp_Customers_GetAll";
        public const string GetCustomerById = "sp_Customers_GetById";
        public const string GetLastCustomer = "sp_Categories_GetLastCustomer";

        #endregion

        #region OrderItems
        public const string CreateOrderItem = "sp_OrderItems_CreateOrderItem";
        public const string UpdateOrderItem = "sp_OrderItems_UpdateOrderItem";
        public const string DeleteOrderItem = "sp_OrderItems_DeleteOrderItem";
        public const string GetAllOrderItems = "sp_OrderItems_GetAll";
        public const string GetOrderItemById = "sp_OrderItems_GetById";
        public const string GetLastOrderItem = "sp_Categories_GetLastOrderItem";

        #endregion

        #region Orders
        public const string CreateOrder = "sp_Orders_CreateOrder";
        public const string UpdateOrder = "sp_Orders_UpdateOrder";
        public const string DeleteOrder = "sp_Orders_DeleteOrder";
        public const string GetAllOrders = "sp_Orders_GetAll";
        public const string GetOrderById = "sp_Orders_GetById";
        public const string GetLastOrder = "sp_Categories_GetLastOrder";

        #endregion

        #region Products
        public const string CreateProduct = "sp_Products_CreateProduct";
        public const string UpdateProduct = "sp_Products_UpdateProduct";
        public const string DeleteProduct = "sp_Products_DeleteProduct";
        public const string GetAllProducts = "sp_Products_GetAll";
        public const string GetProductById = "sp_Products_GetById";
        public const string GetLastProduct = "sp_Categories_GetLastProduct";

        public const string GetProductsByCategory = "sp_Products_GetByCategory";


        #endregion

        #region Staffs
        public const string CreateStaff = "sp_Staffs_CreateStaff";
        public const string UpdateStaff = "sp_Staffs_UpdateStaff";
        public const string DeleteStaff = "sp_Staffs_DeleteStaff";
        public const string GetAllStaffs = "sp_Staffs_GetAll";
        public const string GetStaffById = "sp_Staffs_GetById";
        public const string GetLastStaff = "sp_Categories_GetLastStaff";

        #endregion

        #region Stores
        public const string CreateStore = "sp_Stores_CreateStore";
        public const string UpdateStore = "sp_Stores_UpdateStore";
        public const string DeleteStore = "sp_Stores_DeleteStore";
        public const string GetAllStores = "sp_Stores_GetAll";
        public const string GetStoreById = "sp_Stores_GetById";
        public const string GetLastStore = "sp_Categories_GetLastStore";

        #endregion
    }
}
