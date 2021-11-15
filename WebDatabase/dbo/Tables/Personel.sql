CREATE TABLE [dbo].[Personel] (
    [Email]           NVARCHAR (50) NOT NULL,
    [Ad]              NVARCHAR (50) NOT NULL,
    [Soyad]           NVARCHAR (50) NOT NULL,
    [SicilNo]         INT           NOT NULL,
    [Cep]             NVARCHAR (10) NOT NULL,
    [EvAdresi]        TEXT          NOT NULL,
    [PostaKodu]       INT           NOT NULL,
    [UstKullaniciAdi] NVARCHAR (50) NOT NULL,
    [KullaniciAdi]    NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Email] ASC)
);

