﻿CREATE TABLE [dbo].[tbl_Images]
(
	[ImageID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(250) NULL, 
    [ImagePath] NVARCHAR(MAX) NULL
)
