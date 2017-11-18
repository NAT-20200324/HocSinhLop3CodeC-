CREATE PROC [dbo].[XemThongTin] (@taiKhoan nvarchar(50), @bool int OUT)
AS
	IF EXISTS(
		SELECT *
		FROM sys.tables
		JOIN sys.schemas
		ON sys.schemas.schema_id = sys.tables.schema_id
		WHERE sys.schemas.name = 'dbo' AND sys.tables.name = 'TAM'
	)	DROP TABLE dbo.TAM
	SELECT * INTO dbo.TAM
	FROM HocSinh h 
	WHERE h.taiKhoan = @taiKhoan
	SET @bool = 0
	IF NOT EXISTS ( SELECT * FROM dbo.TAM)
		SET @bool = 1
