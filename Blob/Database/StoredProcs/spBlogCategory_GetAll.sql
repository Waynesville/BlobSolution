IF NOT EXISTS(SELECT * FROM sys.procedures WHERE [name] = 'spBlogCategory_GetAll')
BEGIN
	exec('CREATE PROCEDURE spBlogCategory_GetAll AS SET NOCOUNT ON')
END
GO

ALTER PROCEDURE spBlogCategory_GetAll 
AS
BEGIN
	SET NOCOUNT ON

	SELECT
		Id,
		[Name]
	FROM
		BlogCategory

END
GO
