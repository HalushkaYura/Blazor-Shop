CREATE PROCEDURE [dbo].[sp_OrderItems_GetLastOrderItem]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[OrderItems]
    ORDER BY [ItemId] DESC;
END