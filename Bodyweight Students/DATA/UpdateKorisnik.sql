USE [BodyWeight DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateKorisnik]    Script Date: 10.1.2020. 11:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[UpdateKorisnik]
	@id int,
	@ime nvarchar(50)=null,
	@prezime nvarchar(50)=null,
	@godine int=null,
	@nivoSpreme nvarchar(50)=null,
	@visina int=null,
	@tezina int=null,
	@pol bit=null,
	@datumPrijave date=null


AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Korisnik
	SET Ime=@ime,prezime=@prezime,godine=@godine,Nivo_spreme=@nivoSpreme,Visina=@visina,
	Pol=@pol,DatumPrijave=@datumPrijave
	WHERE Korisnik_ID=@id;
END
