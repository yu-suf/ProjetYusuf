CREATE PROCEDURE [dbo].[RegisterUser]
	@NomUtilisateur nvarchar (255),
	@Nom nvarchar(255),
	@Prenom nvarchar(255),
	@Email nvarchar(320),
	@Passwd varchar(20)
AS
Begin
	Insert into [Utilisateur] ([NomUtilisateur], [Nom], [Prenom], [Email], [Passwd])
	Values (@NomUtilisateur , @Nom, @Prenom, @Email, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt()));
End