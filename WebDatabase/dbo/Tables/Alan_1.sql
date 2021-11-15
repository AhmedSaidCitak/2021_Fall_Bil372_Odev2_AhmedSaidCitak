CREATE TABLE [dbo].[Alan] (
    [AlanID]   INT            IDENTITY (1, 1) NOT NULL,
    [AlanAdi]  NVARCHAR (MAX) NOT NULL,
    [AlanTipi] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Alan] PRIMARY KEY CLUSTERED ([AlanID] ASC)
);

