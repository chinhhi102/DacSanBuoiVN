CREATE TABLE [dbo].[DiaChiNhanHang]
(
	[DiaChiNhanHangID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Huyen] NVARCHAR(50) NULL, 
    [Tinh] NVARCHAR(50) NULL, 
    [UserID] INT NULL
)
