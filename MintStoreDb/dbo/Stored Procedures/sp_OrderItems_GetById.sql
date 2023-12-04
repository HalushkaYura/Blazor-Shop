CREATE PROCEDURE [dbo].[sp_OrderItems_GetById]
    @ItemId INT
AS
BEGIN
    SELECT * FROM [dbo].[OrderItems] WHERE [ItemId] = @ItemId;
END
