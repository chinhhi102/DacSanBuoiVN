USE QLDacSanBuoiDB
GO

-- Thêm các tỉnh
TRUNCATE TABLE dbo.tbl_DiaChi;

INSERT INTO dbo.tbl_DiaChi VALUES(N'Hồ Chí Minh');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Hà Nội');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Bình Dương');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Tiền Giang');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Đà Lạt');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Đà Nẵng');
INSERT INTO dbo.tbl_DiaChi VALUES(N'Bình Định');

SELECT * FROM dbo.tbl_DiaChi;

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


-- Thêm sản phẩm
TRUNCATE TABLE dbo.tbl_SanPham;

INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi thường', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 100000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi VIP PRO', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 200000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Royal', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 300000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Đẳng cấp Số 1 Việt Nam', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 400000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Internation', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 500000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi thường', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 100000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi VIP PRO', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 200000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Royal', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 300000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Đẳng cấp Số 1 Việt Nam', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 400000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Internation', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 500000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi thường', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 100000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi VIP PRO', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 200000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Royal', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 300000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Đẳng cấp Số 1 Việt Nam', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 400000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Internation', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 500000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi thường', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 100000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi VIP PRO', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 200000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Royal', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 300000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Đẳng cấp Số 1 Việt Nam', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 400000);
INSERT INTO dbo.tbl_SanPham VALUES(N'Bưởi năm roi Internation', '...', RAND()*(7-1)+1, RAND()*(7-1)+1, 500000);


SELECT * FROM dbo.tbl_SanPham;

TRUNCATE TABLE dbo.tbl_Users;

INSERT INTO dbo.tbl_Users VALUES('ad', 'ad', 'ad', 'ad', 'ad', 'ad', 2);

SELECT * FROM dbo.tbl_Users;