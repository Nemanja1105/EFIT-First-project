
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajVaganje
@tezina int=null,
@datumVaganje date=null,
@korisnikId int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Tezine(Tezine,DatumVaganja,KorisnikID$)
	VALUES(@tezina,@datumVaganje,@korisnikId);
END
GO
