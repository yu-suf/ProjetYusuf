CREATE PROCEDURE [dbo].[CheckUser]
	@Email nvarchar(320),
	@NomUtilisateur nvarchar(255),
	@Passwd varchar(20)
	
AS
Begin
	SELECT Id, NomUtilisateur, Nom, Prenom, Email 
	from [Utilisateur] 
	where Email = @Email or NomUtilisateur = @NomUtilisateur and Passwd = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt());
End