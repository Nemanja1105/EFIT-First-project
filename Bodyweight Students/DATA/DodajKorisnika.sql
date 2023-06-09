USE [BodyWeight DB]
GO
/****** Object:  StoredProcedure [dbo].[DodajKorisnika]    Script Date: 14.1.2020. 9:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

ALTER PROCEDURE [dbo].[DodajKorisnika]
	@ime nvarchar(50)=null,
	@prezime nvarchar(50)=null,
	@godine int=null,
	@nivoSpreme nvarchar(50)=null,
	@visina int=null,
	@pol bit=null,
	@datumPrijave datetime=null,
	@id int OUTPUT
		
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Korisnik(Ime,Prezime,Godine,Nivo_spreme,Visina,Pol,DatumPrijave)
	VALUES(@ime,@prezime,@godine,@nivoSpreme,@visina,@pol,@datumPrijave);
	SELECT @id=SCOPE_IDENTITY();
END
