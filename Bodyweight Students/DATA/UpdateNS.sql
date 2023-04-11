

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE PromijeniNivoSpreme
@id int,
@nivospreme nvarchar(50) 
	
AS
BEGIN
	
	SET NOCOUNT ON;
	update Korisnik
	set Nivo_spreme=@nivospreme
	where Korisnik_ID=@id;


    
	 
END
GO
