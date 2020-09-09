CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomUtilisateur] NVARCHAR(255) NOT NULL UNIQUE, 
    [Nom] NVARCHAR(255) NOT NULL, 
    [Prenom] NVARCHAR(255) NOT NULL, 
    [Email] NVARCHAR(320) NOT NULL, 
    [Passwd] VARBINARY(64) NOT NULL, 
    [FormuleId] INT NULL, 
    [AdresseId] INT NULL,
    CONSTRAINT [FK_Utilisateur_ToFormule] FOREIGN KEY ([FormuleId]) REFERENCES [Formule]([Id]), 
    CONSTRAINT [FK_Utilisateur_ToAdresse] FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id])
)
