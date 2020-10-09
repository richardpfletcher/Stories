-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSpecificStory] 
	-- Add the parameters for the stored procedure here
	(
@ID int

)
AS
BEGIN
	SELECT [ID]
      ,[JakataID]
      ,[StoryCategorytName]
      ,[Title]
      ,[AnimalType]
      ,[MoralType]
      ,[Comments]
      ,[Stories]
  FROM [rfletcher_stories].[dbo].[Stories]
  where id = @ID
 END
