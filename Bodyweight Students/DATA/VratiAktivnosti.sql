
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiAktivnosti
@korisnikId int=null
AS
BEGIN

	SET NOCOUNT ON;
	SELECT AktivnostH,DatumAktivnosti FROM DnevnaAktivnost
	WHERE KorisnikId$=@korisnikId;

END
GO
