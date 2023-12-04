CREATE PROCEDURE [dbo].[sp_OrderItems_GetAll]
AS
BEGIN
    SELECT * FROM [dbo].[OrderItems];
END
