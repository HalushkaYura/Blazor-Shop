CREATE PROCEDURE [dbo].[sp_Orders_GetById]
    @OrderId INT
AS
BEGIN
    SELECT * FROM [dbo].[Orders] WHERE [OrderId] = @OrderId;
END
