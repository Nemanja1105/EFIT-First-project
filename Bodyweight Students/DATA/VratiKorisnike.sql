
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiKorisnike
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Korisnik.Korisnik_ID,Korisnik.Ime,Korisnik.Prezime,Korisnik.Nivo_spreme,
	Korisnik.DatumPrijave,Login.Email,Login.Password,Login.IsVerified FROM Korisnik
	INNER JOIN Login ON Korisnik.Korisnik_ID=Login.Korisnik_ID$;

END
GO
