CREATE PROCEDURE [dbo].[sp_Orders_DeleteOrder]
    @OrderId INT
AS
BEGIN
    DELETE FROM [dbo].[Orders]
    WHERE [OrderId] = @OrderId;
END
