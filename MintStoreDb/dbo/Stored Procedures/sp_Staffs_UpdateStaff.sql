CREATE PROCEDURE [dbo].[sp_Staffs_UpdateStaff]
    @StaffId INT,
    @FirstName NVARCHAR(100) = NULL,
    @LastName NVARCHAR(100) = NULL,
    @Email NVARCHAR(100) = NULL,
    @Phone NVARCHAR(25) = NULL,
    @Active BIT = NULL,
    @ManagerId INT = NULL
AS
BEGIN
    UPDATE [dbo].[Staffs]
    SET
        [FirstName] = ISNULL(@FirstName, [FirstName]),
        [LastName] = ISNULL(@LastName,[Lastname]),
        [Email] = ISNULL(@Email,[Email]),
        [Phone] = ISNULL(@Phone, Phone),
        [Active] = ISNULL(@Active, Active),
        [ManagerId] = ISNULL(@ManagerId, ManagerId)
    WHERE StaffId = @StaffId;
END
