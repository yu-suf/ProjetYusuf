CREATE TABLE [dbo].[Jeux]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DateDeSortie] DATETIME NOT NULL, 
    [Image] NVARCHAR(255) NULL, 
    [PlateFormeId] INT NULL, 
    [EtatJeuxId] INT NULL, 
    [CategorieId] INT NULL, 
    CONSTRAINT [FK_Jeux_ToPlateForme] FOREIGN KEY ([PlateFormeId]) REFERENCES [PlateForme]([Id]), 
    CONSTRAINT [FK_Jeux_ToEtatJeux] FOREIGN KEY ([EtatJeuxId]) REFERENCES [EtatJeux]([Id]), 
    CONSTRAINT [FK_Jeux_ToCategorie] FOREIGN KEY ([CategorieId]) REFERENCES [Categorie]([Id])
)
