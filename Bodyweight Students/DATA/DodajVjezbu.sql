
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DodajVjezbu
	@naziv nvarchar(50)=null,
	@ytCode nvarchar(50)=null,
	@tezina nvarchar(50)=null,
	@opis nvarchar(MAX)=null,
	@tipVjezbe nvarchar(50)=null,
	@dioTijela nvarchar(50)=null,
	@id int OUTPUT

AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO Vjezbe(naziv,ytCode,tezinaVjezbe,opis,tipVjezbe,dioTijela)
	VALUES(@naziv,@ytCode,@tezina,@opis,@tipVjezbe,@dioTijela);
	SELECT @id=SCOPE_IDENTITY();
END
GO
