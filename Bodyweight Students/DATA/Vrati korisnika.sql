
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiKorisnika
@id int
 
	
AS
BEGIN
	
	SET NOCOUNT ON;
	select * from Korisnik
	where Korisnik_ID=@id;

    
END
GO
