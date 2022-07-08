IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_BlogPost_BlogCategory') AND parent_object_id = OBJECT_ID(N'dbo.BlogPost'))
BEGIN
	ALTER TABLE BlogPost ADD CONSTRAINT FK_BlogPost_BlogCategory FOREIGN KEY (CategoryId) REFERENCES BlogCategory(CategoryId)
END