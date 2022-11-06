CREATE TABLE [dbo].[Test] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Type]      NVARCHAR (255) NOT NULL,
    [Name]      NVARCHAR (255) NOT NULL,
    [Adress]    NVARCHAR (255) NOT NULL,
    [Metro]     NVARCHAR (255) NOT NULL,
    [Latitude]  NVARCHAR (255) NOT NULL,
    [Longitude] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

