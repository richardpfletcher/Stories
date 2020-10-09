CREATE TABLE [dbo].[AnimalType] (
    [id]         INT        IDENTITY (1, 1) NOT NULL,
    [AnimalType] NCHAR (30) NOT NULL,
    CONSTRAINT [PK_AnimalType] PRIMARY KEY CLUSTERED ([id] ASC)
);

