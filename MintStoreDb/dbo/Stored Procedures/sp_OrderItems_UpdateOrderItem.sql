CREATE PROCEDURE [dbo].[sp_OrderItems_UpdateOrderItem]
    @OrderId INT,
    @ItemId INT,
    @Quantity INT,
    @Price DECIMAL(10, 2),
    @Discount DECIMAL(4, 2)
AS
BEGIN
    UPDATE [dbo].[OrderItems]
    SET
        [Quantity] = @Quantity,
        [Price] = @Price,
        [Discount] = @Discount
    WHERE [OrderId] = @OrderId AND [ItemId] = @ItemId;
END
