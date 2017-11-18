CREATE TABLE [dbo].[LichSuLamBai] (
    [MaBaiTap] INT            IDENTITY (1, 1) NOT NULL,
    [TaiKhoan] NVARCHAR (50)  NOT NULL,
    [Cau1]     NVARCHAR (50)  NOT NULL,
    [Cau2]     NVARCHAR (50)  NOT NULL,
    [Cau3]     NVARCHAR (50)  NOT NULL,
    [Cau4]     NVARCHAR (50)  NOT NULL,
    [Cau5]     NVARCHAR (50)  NOT NULL,
    [Cau6]     NVARCHAR (50)  NOT NULL,
    [Cau7]     NVARCHAR (50)  NOT NULL,
    [Cau8]     NVARCHAR (50)  NOT NULL,
    [Cau9]     NVARCHAR (50)  NOT NULL,
    [Cau10]    NVARCHAR (50)  NOT NULL,
    [BatDau]   DATETIME       NOT NULL,
    [KetThuc]  DATETIME       NOT NULL,
    [GhiChu]   NVARCHAR (500) NULL,
    CONSTRAINT [PK_LichSuLamBai-1] PRIMARY KEY CLUSTERED ([MaBaiTap] ASC, [TaiKhoan] ASC),
    CONSTRAINT [FK_LichSuLamBai-1_HocSinh] FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[HocSinh] ([TaiKhoan])
);

