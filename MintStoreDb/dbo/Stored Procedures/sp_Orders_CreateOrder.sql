CREATE PROCEDURE [dbo].[sp_Orders_CreateOrder]
    @CustomerId INT = NULL,
    @OrderStatus TINYINT,
    @OrderDate DATETIME,
    @RequiredDate DATETIME = NULL,
    @ShippedDate DATETIME,
    @StoreId INT,
    @StaffId INT
AS
BEGIN
    INSERT INTO [dbo].[Orders] (CustomerId, OrderStatus, OrderDate, RequiredDate, ShippedDate, StoreId, StaffId)
    VALUES (@CustomerId, @OrderStatus, @OrderDate, @RequiredDate, @ShippedDate, @StoreId, @StaffId);
END
