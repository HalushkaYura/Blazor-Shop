CREATE PROCEDURE [dbo].[sp_Brands_CreateBrand]
    @BrandName NVARCHAR(100)
AS
BEGIN
    INSERT INTO [dbo].[Brands] ([BrandName])
    VALUES (@BrandName);
END