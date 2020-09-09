CREATE TABLE [dbo].[FicheEchange]
(
	[StockIdArecuperer] INT NOT NULL , 
    [UtilisateurId] INT NOT NULL, 
    [DatedEchange] DATETIME NOT NULL, 
    [MontantSuplementaire] INT NULL, 
    [JeuxAdonner] INT NOT NULL, 
    CONSTRAINT [FK_FicheEchange_ToStock] FOREIGN KEY ([StockIdArecuperer]) REFERENCES [Stock]([Id]), 
    CONSTRAINT [FK_FicheEchange_ToUtilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateur]([Id]), 
    CONSTRAINT [PK_FicheEchange] PRIMARY KEY ([StockIdArecuperer], [UtilisateurId])
)
