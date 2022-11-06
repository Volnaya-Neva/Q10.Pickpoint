CREATE TABLE [dbo].[DataMosRuType] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Number] INT            NOT NULL,
    [Type]   NVARCHAR (MAX) NOT NULL,
    [IsUse]  BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

