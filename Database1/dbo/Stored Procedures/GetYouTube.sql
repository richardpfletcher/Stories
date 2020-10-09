-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetYouTube] 
	@JakataID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id]
	  ,[JakataID]
      ,[url]
  FROM [dbo].[YouTube]
  WHERE JakataID = @JakataID
  order by JakataID
 
END
