CREATE VIEW [dbo].[stRepor] AS
SELECT 
    [stClsSchedule_tbl].*, 
    [stAttendance_tbl].[attendance] 
FROM 
    [stClsSchedule_tbl] 
INNER JOIN 
    [stAttendance_tbl] 
ON 
    [stClsSchedule_tbl].[st_ID] = [stAttendance_tbl].[student_ID];