
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajKorisnika
@ime nvarchar(50)=null,
@prezime nvarchar(50)=null,
@godine int=null,
@nivoSpreme nvarchar(50)=null,
@visina int=null,
@tezine int=null,
@pol bit=null,
@datumPrijave date=null,
@id int OUTPUT

AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO Korisnik(Ime,Prezime,Godine,Nivo_spreme,Visina,Tezina,Pol,DatumPrijave)
    VALUES (@ime,@prezime,@godine,@nivoSpreme,@visina,@tezine,@pol,@datumPrijave);
	SELECT @id=SCOPE_IDENTITY();

END
GO
