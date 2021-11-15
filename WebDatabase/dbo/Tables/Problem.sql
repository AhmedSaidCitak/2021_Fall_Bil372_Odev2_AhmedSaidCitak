CREATE TABLE [dbo].[Problem] (
    [ProblemID]                INT           NOT NULL,
    [ProblemTanimi]            NVARCHAR (50) NOT NULL,
    [ProblemTanimlayiciAdi]    NVARCHAR (50) NOT NULL,
    [ProblemTanimlayiciSoyadi] NVARCHAR (50) NOT NULL,
    [ProblemTanimlayiciTCNO]   INT           NOT NULL,
    [HedefAmacTanimi]          NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProblemID] ASC)
);

