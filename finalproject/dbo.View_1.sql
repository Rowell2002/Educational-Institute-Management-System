CREATE VIEW [dbo].[studentr] AS
SELECT 
    [result_tbl].*, 
    [offence_tbl].[date],[offence_tbl].[offence_Type] 
FROM 
    [result_tbl] 
LEFT OUTER JOIN 
    [offence_tbl] 
ON 
    [result_tbl].[student_id] = [offence_tbl].[student_ID];
