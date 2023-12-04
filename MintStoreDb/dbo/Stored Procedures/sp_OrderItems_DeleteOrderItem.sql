CREATE PROCEDURE [dbo].[sp_OrderItems_DeleteOrderItem]
    @OrderId INT,
    @ItemId INT
AS
BEGIN
    DELETE FROM [dbo].[OrderItems]
    WHERE [OrderId] = @OrderId AND [ItemId] = @ItemId;
END
