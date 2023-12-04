CREATE PROCEDURE [dbo].[sp_Orders_UpdateOrder]
    @OrderId INT,
    @OrderStatus TINYINT = NULL,
    @OrderDate DATETIME = NULL,
    @RequiredDate DATETIME = NULL,
    @ShippedDate DATETIME = NULL
AS
BEGIN
    UPDATE [dbo].[Orders]
    SET
        [OrderStatus] = ISNULL(@OrderStatus,[OrderStatus]),
        [OrderDate] = ISNULL(@OrderDate,[OrderDate]),
        [RequiredDate] = ISNULL(@RequiredDate,[RequiredDate]),
        [ShippedDate] = ISNULL(@ShippedDate,[ShippedDate])
    WHERE [OrderId] = @OrderId;
END
