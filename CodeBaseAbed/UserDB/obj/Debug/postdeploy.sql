if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName,LastName)
	values ('Tim','corey'),
		('Sue','corey'),
		('rim','corey'),
		('kim','corey'),
		('Pim','corey');
end
GO
