CREATE TABLE [dbo].[JakataMaster] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [JakataID]      INT            NOT NULL,
    [Roman]         NCHAR (10)     NOT NULL,
    [Title]         NCHAR (50)     NOT NULL,
    [Comments]      NVARCHAR (MAX) NULL,
    [StoryImported] BIT            NULL,
    CONSTRAINT [PK_JakataMaster] PRIMARY KEY CLUSTERED ([id] ASC)
);

