CREATE PROC [dbo].[DangNhapHs](
@taikhoan nvarchar(50), 
@matkhau nvarchar(50),
@bool int OUT)
AS
	BEGIN
	IF EXISTS(SELECT * FROM HocSinh x 
	WHERE x.TaiKhoan = @taikhoan AND x.MatKhau = @matkhau)
		SET @bool = 0
	ELSE IF EXISTS(SELECT * FROM HocSinh x 
	WHERE x.TaiKhoan = @taikhoan AND x.MatKhau <> @matkhau)
		SET @bool = 1
	ELSE SET @bool = 2 --tai khoan khong ton tai
	END


