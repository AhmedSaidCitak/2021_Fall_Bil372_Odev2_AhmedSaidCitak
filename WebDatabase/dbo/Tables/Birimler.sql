CREATE TABLE [dbo].[Birimler] (
    [BirimID]                INT           NOT NULL,
    [BirimAdi]               NVARCHAR (50) NOT NULL,
    [UstBirimKodu]           NCHAR (10)    NOT NULL,
    [BulunduguAdres]         TEXT          NOT NULL,
    [PostaKodu]              INT           NOT NULL,
    [BirimMudurKullaniciAdi] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BirimID] ASC)
);

