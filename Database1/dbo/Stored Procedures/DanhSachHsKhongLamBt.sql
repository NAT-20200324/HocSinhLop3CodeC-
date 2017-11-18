CREATE PROC DanhSachHsKhongLamBt(@taiKhoan nvarchar(50))
AS
	IF EXISTS(
		SELECT *
		FROM sys.tables
		JOIN sys.schemas
		ON sys.schemas.schema_id = sys.tables.schema_id
		WHERE sys.schemas.name = 'dbo' AND sys.tables.name = 'TAM'
	)	DROP TABLE dbo.TAM
	SELECT * INTO dbo.TAM FROM DanhSachHocSinh d
	WHERE d.TaiKhoan NOT IN(SELECT l.TaiKhoan FROM LichSuLamBai l)
		AND d.MaLop IN (SELECT g.MaLop FROM GiaoVien g 
		WHERE g.TaiKhoan = @taiKhoan)
		
