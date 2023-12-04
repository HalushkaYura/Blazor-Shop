CREATE PROCEDURE [dbo].[sp_Brands_GetLastBrand]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Brands]
    ORDER BY [BrandId] DESC;
END