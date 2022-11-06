CREATE TYPE [dbo].[DataMosRuSourceTVP] AS TABLE (
    [Number]     NVARCHAR (MAX) NOT NULL,
    [Type]       NVARCHAR (MAX) NULL,
    [CommonName] NVARCHAR (MAX) NULL,
    [FullName]   NVARCHAR (MAX) NULL,
    [ShortName]  NVARCHAR (MAX) NULL,
    [Area]       NVARCHAR (MAX) NULL,
    [Address]    NVARCHAR (MAX) NULL,
    [GlobalId]   NVARCHAR (MAX) NULL);

