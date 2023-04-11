
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajTrening
@naziv nvarchar(50)=null,
@opis nvarchar(50)=null,
@dan nvarchar(50)=null,
@korisnikId int=null,
@treningId int output
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Treninzi(Naziv,Opis,Dan,KorisnikId)
	VALUES(@naziv,@opis,@dan,@korisnikId);
	SELECT @treningId=SCOPE_IDENTITY();
END
GO
