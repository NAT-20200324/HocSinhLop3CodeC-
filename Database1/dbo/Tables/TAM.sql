CREATE TABLE [dbo].[TAM] (
    [TaiKhoan]   NVARCHAR (50)  NOT NULL,
    [MatKhau]    NVARCHAR (50)  NOT NULL,
    [Ho]         NVARCHAR (20)  NOT NULL,
    [Ten]        NVARCHAR (20)  NOT NULL,
    [NgaySinh]   DATETIME       NOT NULL,
    [TenDem]     NVARCHAR (20)  NULL,
    [DiaChi]     NVARCHAR (100) NULL,
    [dtPhuHuynh] NVARCHAR (20)  NULL
);

