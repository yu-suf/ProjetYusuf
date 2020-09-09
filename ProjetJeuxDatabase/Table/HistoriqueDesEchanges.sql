CREATE TABLE [dbo].[HistoriqueDesEchanges]
(
	[JeuxId] INT NOT NULL , 
    [UtilisateurId] INT NOT NULL, 
    [DateEnregistrement] DATETIME NOT NULL, 
    CONSTRAINT [FK_HistoriqueDesEchanges_ToJeux] FOREIGN KEY ([JeuxId]) REFERENCES [Jeux]([Id]), 
    CONSTRAINT [FK_HistoriqueDesEchanges_ToUtilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateur]([Id]), 
    CONSTRAINT [PK_HistoriqueDesEchanges] PRIMARY KEY ([JeuxId], [UtilisateurId])
)
