
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE PromijeniNivoSpreme
@id int=null,
@nivospreme nvarchar(50)=null
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE Korisnik
	SET Nivo_spreme=@nivospreme
	WHERE Korisnik_ID=@id;
END
GO
