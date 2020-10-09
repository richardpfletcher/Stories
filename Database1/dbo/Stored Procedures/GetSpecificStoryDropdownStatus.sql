-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSpecificStoryDropdownStatus] 
	-- Add the parameters for the stored procedure here
	(
@StoryImported int

)	
AS
BEGIN
			SELECT JakataID,JakataMaster.Title
FROM        JakataMaster 
where StoryImported = @StoryImported
order by Title

 END
