IF NOT EXISTS(SELECT * FROM sys.procedures WHERE [name] = 'spBlogPost_Update')
BEGIN
	exec('CREATE PROCEDURE spBlogPost_Update AS SET NOCOUNT ON')
END
GO

ALTER PROCEDURE spBlogPost_Update
	@Id INT,
	@Title VARCHAR(100),
	@Contents VARCHAR(MAX),
	@Timestamp Datetime,
	@CategoryId INT
AS
BEGIN
	SET NOCOUNT ON

	UPDATE BlogPost SET
		Title = @Title,
		Contents = @Contents,
		[Timestamp] = @Timestamp,
		CategoryId = @CategoryId

	WHERE Id = @Id
	
END
GO
