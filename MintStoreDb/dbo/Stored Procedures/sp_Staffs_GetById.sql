CREATE PROCEDURE [dbo].[sp_Staffs_GetById]
    @StaffId INT
AS
BEGIN
    SELECT * FROM [dbo].[Staffs] WHERE [StaffId] = @StaffId;
END
