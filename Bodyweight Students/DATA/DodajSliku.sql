
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajSliku
@slika image=null,
@datum date=null,
@korisnikId int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO SlikeProgres(Slika,DatumSlikanja,KorisnikID$)
	VALUES(@slika,@datum,@korisnikId);
	
END
GO
