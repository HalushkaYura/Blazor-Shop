CREATE PROCEDURE [dbo].[sp_Staffs_DeleteStaff]
    @StaffId INT
AS
BEGIN
    DELETE FROM [dbo].[Staffs]
    WHERE StaffId = @StaffId;
END
