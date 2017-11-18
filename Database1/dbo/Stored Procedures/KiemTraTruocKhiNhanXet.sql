CREATE PROC KiemTraTruocKhiNhanXet(@taiKhoan nvarchar(50), @maBaiTap int, @bool int OUT)
AS
	SET @bool = 1
	IF EXISTS (SELECT * FROM DanhSachHocSinh d
	WHERE d.TaiKhoan IN (SELECT l.TaiKhoan FROM LichSuLamBai l
	WHERE l.MaBaiTap = @maBaiTap) AND d.MaLop IN (SELECT g.MaLop 
			FROM GiaoVien g WHERE g.TaiKhoan = @taiKhoan))
		SET @bool = 0
