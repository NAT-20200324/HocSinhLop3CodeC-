
CREATE PROC [dbo].[XemLichSuLamBaiTheoMaLop](@maLop nchar(3), @bool int OUT)
AS
	IF EXISTS(
		SELECT *
		FROM sys.tables
		JOIN sys.schemas
		ON sys.tables.schema_id = sys.schemas.schema_id
		WHERE sys.schemas.name = 'dbo' AND sys.tables.name = 'TAM'
	) DROP TABLE dbo.TAM
	SELECT * INTO dbo.TAM
	FROM LichSuLamBai l
	WHERE l.TaiKhoan IN (SELECT d.TaiKhoan 
							FROM DanhSachHocSinh d
							WHERE d.MaLop = @maLop)
	SET @bool = 0
	IF NOT EXISTS(SELECT * FROM dbo.TAM)
		SET @bool = 1
	IF NOT EXISTS(SELECT * FROM dbo.GiaoVien WHERE MaLop = @maLop)
		SET @bool = 2 --KHONG TIM THAY MA LOP

