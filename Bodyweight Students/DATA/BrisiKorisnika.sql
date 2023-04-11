
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE BrisiKorisnika
@id int

AS
BEGIN
	
	SET NOCOUNT ON;
	delete from Korisnik where Korisnik_ID=@id;

 
END
GO
