CREATE TABLE userData
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Phone] VARCHAR(13) NULL, 
    [Email] NVARCHAR(255) NULL, 
    [Photo] VARBINARY(MAX) NULL, 
    [Password] VARBINARY(50) NULL
)
