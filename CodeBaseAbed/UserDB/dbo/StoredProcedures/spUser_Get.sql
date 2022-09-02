CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	SELECT *
	FROM DBO.[User]
	WHERE Id = @Id;
end
