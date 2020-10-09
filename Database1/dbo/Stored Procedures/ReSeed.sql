
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ReSeed]

AS
BEGIN
	DBCC CHECKIDENT ('[dbo].[jakataMaster]', RESEED, 0) --starts ressding at this number

END

