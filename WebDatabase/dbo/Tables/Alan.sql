CREATE TABLE [dbo].[Alan] (
    [AlanID]   INT            IDENTITY (1, 1) NOT NULL,
    [AlanAdi]  NVARCHAR (MAX) NULL,
    [AlanTipi] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Alan] PRIMARY KEY CLUSTERED ([AlanID] ASC)
);

