USE [PqnK22CNTT1lesson10]
GO
/****** Object:  Table [dbo].[pqnketqua]    Script Date: 6/24/2024 6:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pqnketqua](
	[PqnMaSV] [nvarchar](50) NOT NULL,
	[PqnMaMH] [nvarchar](50) NOT NULL,
	[Diem] [nvarchar](50) NULL,
 CONSTRAINT [PK_pqnketqua] PRIMARY KEY CLUSTERED 
(
	[PqnMaSV] ASC,
	[PqnMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pqnkhoa]    Script Date: 6/24/2024 6:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pqnkhoa](
	[PqnMaKH] [nvarchar](50) NOT NULL,
	[PqnTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_pqnkhoa] PRIMARY KEY CLUSTERED 
(
	[PqnMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pqnmonhoc]    Script Date: 6/24/2024 6:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pqnmonhoc](
	[PqnMaMH] [nvarchar](50) NOT NULL,
	[PqnTenMH] [nvarchar](50) NULL,
	[Sotiet] [nvarchar](50) NULL,
 CONSTRAINT [PK_pqnmonhoc] PRIMARY KEY CLUSTERED 
(
	[PqnMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pqnsinhvien]    Script Date: 6/24/2024 6:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pqnsinhvien](
	[PqnMaSV] [nvarchar](50) NOT NULL,
	[PqnHoSV] [nvarchar](50) NULL,
	[PqnTenSV] [nvarchar](50) NULL,
	[PqnPhai] [bit] NULL,
	[PqnNgaySinh] [date] NULL,
	[PqnNoiSinh] [nvarchar](50) NULL,
	[PqnMaKH] [nvarchar](50) NULL,
	[PqnHocBong] [nvarchar](50) NULL,
	[PqnDiemTrungBinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_pqnsinhvien] PRIMARY KEY CLUSTERED 
(
	[PqnMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
