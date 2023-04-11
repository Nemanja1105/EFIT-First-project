
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajVjezbUTrening
@treningId int=null,
@vjezbaId int=null,
@ponavljanja int=null,
@serije int=null

AS
BEGIN
	SET NOCOUNT ON;
    INSERT INTO [Trening(Spajanje)](VjezbaId,Ponavljanja,Serija,TreningId)
	VALUES(@vjezbaId,@ponavljanja,@serije,@treningId);

END
GO
