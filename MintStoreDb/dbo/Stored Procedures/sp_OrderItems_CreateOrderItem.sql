CREATE PROCEDURE [dbo].[sp_OrderItems_CreateOrderItem]
    @OrderId INT,
    @ItemId INT,
    @ProductId INT,
    @Quantity INT,
    @Price DECIMAL(10, 2),
    @Discount DECIMAL(4, 2)
AS
BEGIN
    INSERT INTO [dbo].[OrderItems] ([OrderId], [ItemId], [ProductId], [Quantity], [Price], [Discount])
    VALUES (@OrderId, @ItemId, @ProductId, @Quantity, @Price, @Discount);
END
