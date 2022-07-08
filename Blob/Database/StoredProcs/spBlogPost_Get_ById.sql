IF NOT EXISTS(SELECT * FROM sys.procedures WHERE [name] = 'spBlogPost_Get_ById')
BEGIN
	exec('CREATE PROCEDURE spBlogPost_Get_ById AS SET NOCOUNT ON')
END
GO

ALTER PROCEDURE spBlogPost_Get_ById 
	@Id int
AS
BEGIN
	SET NOCOUNT ON

	SELECT
		Id,
		Title,
		Contents,
		[Timestamp],
		CategoryId
	FROM
		BlogPost
	WHERE
		Id = @Id

END
GO
