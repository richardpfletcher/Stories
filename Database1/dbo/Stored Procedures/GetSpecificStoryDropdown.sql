-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSpecificStoryDropdown] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
			SELECT Stories.ID,JakataMaster.Title
FROM        Stories INNER JOIN JakataMaster ON Stories.JakataID = JakataMaster.JakataID
order by JakataMaster.Title

 END
