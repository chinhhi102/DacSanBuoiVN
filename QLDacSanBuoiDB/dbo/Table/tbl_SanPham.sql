﻿CREATE TABLE [dbo].[tbl_SanPham]
(
	[SanPhamID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TenSP] NVARCHAR(50) NOT NULL, 
    [Mota] NVARCHAR(MAX) NOT NULL, 
    [LoaiSPID] INT NOT NULL, 
    [DiaChiID] INT NOT NULL, 
    [DonGia] FLOAT NOT NULL, 
    [ImagePath] NVARCHAR(250) NULL
)
