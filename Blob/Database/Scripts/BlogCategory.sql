DECLARE @BlogCategory TABLE(Id int, [Name] varchar(100))

INSERT INTO @BlogCategory(Id, [Name]) VALUES(1, 'General')
INSERT INTO @BlogCategory(Id, [Name]) VALUES(2, 'Technology')
INSERT INTO @BlogCategory(Id, [Name]) VALUES(3, 'Random')

DELETE BlogCategory

INSERT INTO BlogCategory(Id, [Name])
SELECT Id, [Name] FROM @BlogCategory
