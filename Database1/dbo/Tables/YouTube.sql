CREATE TABLE [dbo].[YouTube] (
    [id]       INT         IDENTITY (1, 1) NOT NULL,
    [JakataID] INT         NOT NULL,
    [url]      NCHAR (200) NOT NULL,
    CONSTRAINT [PK_YouTube] PRIMARY KEY CLUSTERED ([id] ASC)
);

