CREATE TABLE [dbo].[Stories] (
    [ID]                 INT            IDENTITY (1, 1) NOT NULL,
    [JakataID]           INT            NULL,
    [StoryCategorytName] INT            NOT NULL,
    [Title]              INT            NULL,
    [AnimalType]         NVARCHAR (50)  NULL,
    [MoralType]          INT            NULL,
    [Comments]           NVARCHAR (MAX) NULL,
    [Stories]            NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Stories] PRIMARY KEY CLUSTERED ([ID] ASC)
);

