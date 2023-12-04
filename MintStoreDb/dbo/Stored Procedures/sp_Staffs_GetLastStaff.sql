CREATE PROCEDURE [dbo].[sp_Staffs_GetLastStaff]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Staffs]
    ORDER BY [StaffId] DESC;
END