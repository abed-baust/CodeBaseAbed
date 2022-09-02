CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	SELECT *
	FROM DBO.[User];
end