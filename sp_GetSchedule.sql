CREATE PROCEDURE sp_GetSchedule
(
@Member varchar(100) = '%',
@LocalDate DateTime2 = '%')
AS
BEGIN
 
SELECT Members,
	   Name,
	   LocalDate,
	   ExclusiveOrShared 
Where Members like @Member and LocalDate like @LocalDate
 
END