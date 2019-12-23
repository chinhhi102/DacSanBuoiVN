USE QLDacSanBuoiDB
GO

-- Thêm loại sản phẩm
TRUNCATE TABLE dbo.tbl_LoaiSP;

INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi năm roi');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi da xanh');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi Diễn');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi Đoan Hùng');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi Phúc Trạch');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi Tân Triều');
INSERT INTO dbo.tbl_LoaiSP VALUES(N'Bưởi Luận Văn');

SELECT * FROM dbo.tbl_LoaiSP;