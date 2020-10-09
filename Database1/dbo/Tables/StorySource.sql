CREATE TABLE [dbo].[StorySource] (
    [id]          INT        IDENTITY (1, 1) NOT NULL,
    [StorySource] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_StorySource] PRIMARY KEY CLUSTERED ([id] ASC)
);

