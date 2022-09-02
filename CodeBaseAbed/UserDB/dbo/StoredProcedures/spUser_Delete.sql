CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
begin
	DELETE 
	FROM DBO.[User]
	WHERE Id = @Id;
end
