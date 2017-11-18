CREATE TABLE [dbo].[DanhSachHocSinh] (
    [MaLop]    NCHAR (3)     NOT NULL,
    [TaiKhoan] NVARCHAR (50) NOT NULL,
    [NienKhoa] NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_DanhSachHocSinh] PRIMARY KEY CLUSTERED ([MaLop] ASC, [TaiKhoan] ASC, [NienKhoa] ASC),
    CONSTRAINT [FK_DanhSachHocSinh_HocSinh] FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[HocSinh] ([TaiKhoan]),
    CONSTRAINT [FK_DanhSachHocSinh_Lop] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[Lop] ([MaLop])
);

