

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiVaganja
@korisnikId int
AS
BEGIN

	SET NOCOUNT ON;
	Select Tezine,DatumVaganja FROM Tezine
	WHERE KorisnikID$=@korisnikId;
END
GO
