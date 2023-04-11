
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE VratiLicneVjezbe
@treningId int=null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT VjezbaId,Ponavljanja,Serija FROM [Trening(Spajanje)]
	WHERE TreningId=@treningId;

END
GO
