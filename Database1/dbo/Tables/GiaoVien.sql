CREATE TABLE [dbo].[GiaoVien] (
    [TaiKhoan]  NVARCHAR (50)  NOT NULL,
    [MatKhau]   NVARCHAR (50)  NOT NULL,
    [Ho]        NVARCHAR (20)  NOT NULL,
    [Ten]       NVARCHAR (20)  NOT NULL,
    [NgaySinh]  DATETIME       NOT NULL,
    [MaLop]     NCHAR (3)      NOT NULL,
    [TenDem]    NVARCHAR (20)  NULL,
    [DiaChi]    NVARCHAR (100) NULL,
    [DienThoai] NVARCHAR (20)  NULL,
    CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED ([TaiKhoan] ASC),
    CONSTRAINT [FK_GiaoVien_Lop] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[Lop] ([MaLop])
);

