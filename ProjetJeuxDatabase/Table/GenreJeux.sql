CREATE TABLE [dbo].[GenreJeux]
(
	[GenreId] INT NOT NULL, 
    [JeuxId] INT NOT NULL, 
    CONSTRAINT [FK_GenreJeux_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id]), 
    CONSTRAINT [FK_GenreJeux_ToJeux] FOREIGN KEY ([JeuxId]) REFERENCES [Jeux]([Id]), 
    CONSTRAINT [PK_GenreJeux] PRIMARY KEY ([GenreId] , [JeuxId])
)
