CREATE PROC [dbo].[UpGhiChu](@maBaiTap int, @ghiChu nvarchar(500), @bool int OUT)
AS
	IF NOT EXISTS (SELECT * FROM LichSuLamBai l WHERE l.MaBaiTap = @maBaiTap)
		SET @bool = 1
	ELSE
	BEGIN
		UPDATE LichSuLamBai
		SET GhiChu = @ghiChu
		WHERE MaBaiTap = @maBaiTap
		SET @bool = 0
	END

