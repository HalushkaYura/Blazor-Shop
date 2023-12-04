CREATE PROCEDURE [dbo].[sp_Brands_DeleteBrand]
    @BrandId INT
AS
BEGIN
    DELETE FROM [dbo].[Brands]
    WHERE BrandId = @BrandId;
END
