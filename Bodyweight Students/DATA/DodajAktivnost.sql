
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajAktivnost
@aktivnostH int=null,
@aktivnostDatum date=null,
@korisnikId int=null
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO DnevnaAktivnost(AktivnostH,DatumAktivnosti,KorisnikId$)
	VALUES(@aktivnostH,@aktivnostDatum,@korisnikId);
	
END
GO
