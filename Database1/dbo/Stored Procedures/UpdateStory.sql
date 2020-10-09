-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateStory] 
	-- Add the parameters for the stored procedure here
	(


@ID int, 
@JakataID int, 
@StoryCategorytName int,
@Title int ,
@AnimalType nchar(30),
@MoralType int,
@Comments nvarchar(max) ,
@Stories nvarchar(max) NULL


)
AS
BEGIN

update JakataMaster
  set StoryImported =1
  where JakataID =@JakataID

UPDATE [dbo].[Stories]
   SET [JakataID] = @JakataID
      ,[StoryCategorytName] = @StoryCategorytName
      ,[Title] = @Title
      ,[AnimalType] = @AnimalType
      ,[MoralType] = @MoralType
      ,[Comments] = @Comments
      ,[Stories] = @Stories

 WHERE ID =@ID

	
declare @id1 int
 
  
SELECT @id1 =  @@IDENTITY    
--SELECT @id =  SCOPE_IDENTITY() 
SELECT @id1 as totalReceipesInt
 END
