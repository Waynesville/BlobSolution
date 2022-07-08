IF NOT EXISTS(SELECT * FROM sys.procedures WHERE [name] = 'spBlogPost_Insert')
BEGIN
	exec('CREATE PROCEDURE spBlogPost_Insert AS SET NOCOUNT ON')
END
GO

ALTER PROCEDURE spBlogPost_Insert 
	@Title VARCHAR(100),
	@Contents VARCHAR(MAX),
	@Timestamp Datetime,
	@CategoryId INT
AS
BEGIN
	SET NOCOUNT ON

	INSERT INTO BlogPost(Title,Contents,[Timestamp],CategoryId)
	VALUES (@Title, @Contents, @Timestamp, @CategoryId)
	
	RETURN SCOPE_IDENTITY()

END
GO
