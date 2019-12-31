CREATE TABLE [dbo].[tbl_TinTuc]
(
	[TinTucID] INT NOT NULL PRIMARY KEY, 
    [NoiDung] NVARCHAR(MAX) NULL, 
    [NgayViet] DATE NULL, 
    [TieuDe] NVARCHAR(250) NULL, 
    [ImageID] INT NULL
)
