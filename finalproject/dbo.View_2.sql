CREATE VIEW [dbo].[stgrade] AS
SELECT 
    [result_tbl].*,
    [offence_tbl].[date],[offence_tbl].[offence_Type] 
FROM 
    [result_tbl] 
FULL OUTER JOIN 
    [offence_tbl] 
ON 
    [result_tbl].[student_id] = [offence_tbl].[student_ID];
