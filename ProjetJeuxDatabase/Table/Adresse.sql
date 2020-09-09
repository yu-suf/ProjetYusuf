CREATE TABLE [dbo].[Adresse]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Rue] NVARCHAR(255) NOT NULL, 
    [Numero] INT NOT NULL, 
    [Boite] INT NULL, 
    [Localite] INT NOT NULL, 
    [Pays] NVARCHAR(255) NOT NULL
)
