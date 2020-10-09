-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertURL] 
	-- Add the parameters for the stored procedure here
	(



@JakataID int, 
@URL nvarchar(200) 


)
AS
BEGIN



	INSERT INTO [dbo].[YouTube]
           ([JakataID]
           ,[URL])
     VALUES
           (@JakataID,
            @URL)

declare @id int
 
  
SELECT @id =  @@IDENTITY    
--SELECT @id =  SCOPE_IDENTITY() 
SELECT @id as totalReceipesInt
 END
