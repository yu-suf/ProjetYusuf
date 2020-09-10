CREATE TABLE [dbo].[FicheEchange]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DateDEchange] DATETIME NOT NULL, 
    [MontantSuplementaire] MONEY NULL, 
    [JeuxIdAdonner] INT NOT NULL, 
    [JeuxIdArecevoir] INT NOT NULL, 
    [UtilisateurId] INT NOT NULL, 
    CONSTRAINT [FK_FicheEchange_ToJeux] FOREIGN KEY ([JeuxIdArecevoir]) REFERENCES [Jeux]([Id])
)
