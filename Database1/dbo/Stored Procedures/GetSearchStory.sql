-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSearchStory] 
	-- Add the parameters for the stored procedure here
	(



@ID int =null,
@JakataID int =null, 
@StoryCategorytName int =null,
@Title int =null,

@AnimalType nvarchar(30)=null,
@MoralType int =null,
@Comments nvarchar(max)=null, 
@Stories nvarchar(max) =null


)
AS
BEGIN
select * from [dbo].[Stories]
where ((@Title IS NULL) OR (Title = @Title )) 
AND		((@ID IS NULL) OR (ID = @ID )) 

AND		((@JakataID IS NULL) OR (JakataID = @JakataID )) 
AND		((@StoryCategorytName IS NULL) OR (StoryCategorytName = @StoryCategorytName )) 
AND		((@AnimalType IS NULL) OR (AnimalType = @AnimalType )) 
AND		((@MoralType IS NULL) OR (MoralType = @MoralType )) 
AND		((@Comments IS NULL) OR (Comments like '%' + @Comments + '%')) 

AND		((@Stories IS NULL) OR (Stories like '%' + @Stories + '%')) 

order by Title

 END
