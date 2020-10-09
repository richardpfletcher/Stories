-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertStory] 
	-- Add the parameters for the stored procedure here
	(



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


	INSERT INTO [dbo].[Stories]
           ([JakataID]
           ,[StoryCategorytName]
           ,[Title]
           ,[AnimalType]
           ,[MoralType]
           ,[Comments]
           ,[Stories])
     VALUES
           (@JakataID,
           @StoryCategorytName, 
           @Title,
           @AnimalType,
           @MoralType, 
           @Comments, 
           @Stories)

declare @id int
 
  
SELECT @id =  @@IDENTITY    
--SELECT @id =  SCOPE_IDENTITY() 
SELECT @id as totalReceipesInt
 END
