CREATE PROC DanhSachLop(@taiKhoan nvarchar(50))
AS
	BEGIN
	IF EXISTS(
		SELECT *
		FROM sys.tables
		JOIN sys.schemas
		ON sys.tables.schema_id = SYS.schemas.schema_id
		WHERE sys.schemas.name = 'dbo' AND sys.tables.name = 'TAM'
	)	DROP TABLE dbo.TAM
	SELECT * INTO QLHocSinhLop3.dbo.TAM FROM HocSinh h 
	WHERE h.TaiKhoan IN (SELECT d.TaiKhoan FROM DanhSachHocSinh d 
	WHERE d.MaLop IN (SELECT g.MaLop FROM GiaoVien g WHERE g.TaiKhoan = @taiKhoan))
	END
