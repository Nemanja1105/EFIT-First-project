
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE PovecajAktivnost
@korisnikId int=null,
@datumAktivnosti date=null,
@vrijednost int=null
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE DnevnaAktivnost
	SET AktivnostH=@vrijednost
	WHERE DatumAktivnosti=@datumAktivnosti AND KorisnikId$=@korisnikId;
END
GO
