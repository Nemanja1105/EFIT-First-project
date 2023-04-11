
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiTrening
@korisnikId int=null,
@dan nvarchar(50)=null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Treninzi.TreningId,Treninzi.Naziv,Treninzi.Opis,Treninzi.Dan,Treninzi.KorisnikId
	FROM Treninzi
	WHERE @korisnikId=KorisnikId AND @dan=Dan;


END
GO
