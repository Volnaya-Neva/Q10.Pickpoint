CREATE TABLE [dbo].[DataMosRuSource] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Number]     NVARCHAR (MAX) NOT NULL,
    [Type]       NVARCHAR (MAX) NULL,
    [CommonName] NVARCHAR (MAX) NULL,
    [FullName]   NVARCHAR (MAX) NULL,
    [ShortName]  NVARCHAR (MAX) NULL,
    [Area]       NVARCHAR (MAX) NULL,
    [Address]    NVARCHAR (MAX) NULL,
    [GlobalId]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

