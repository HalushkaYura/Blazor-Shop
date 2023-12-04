CREATE PROCEDURE [dbo].[sp_Staffs_CreateStaff]
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(25) = NULL,
    @Active BIT = NULL,
    @StoreId INT,
    @ManagerId INT = NULL
AS
BEGIN
    INSERT INTO [dbo].[Staffs] ([FirstName], [LastName], [Email], [Phone], [Active], [StoreId], [ManagerId])
    VALUES (@FirstName, @LastName, @Email, @Phone, @Active, @StoreId, @ManagerId);
END
