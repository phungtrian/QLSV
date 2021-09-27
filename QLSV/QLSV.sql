USE [QLSV]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 08/19/2021 15:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tenTaiKhoan] [varchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 08/19/2021 15:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [int] NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[gioiTinh] [tinyint] NOT NULL,
	[namSinh] [date] NULL,
	[queQuan] [nvarchar](50) NULL,
	[dienThoai] [int] NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[ngayTao] [datetime] NULL,
	[ngayCapNhat] [datetime] NULL,
	[nguoiTao] [nvarchar](50) NULL,
	[nguoiCapNhat] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 08/19/2021 15:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMonHoc] [int] IDENTITY(1,1) NOT NULL,
	[tenMonHoc] [nvarchar](50) NOT NULL,
	[soTinChi] [int] NULL,
	[ngayTao] [datetime] NULL,
	[ngayCapNhat] [datetime] NULL,
	[nguoiTao] [nvarchar](50) NULL,
	[nguoiCapNhat] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 08/19/2021 15:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGiangVien] [int] IDENTITY(1,1) NOT NULL,
	[ho] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[gioiTinh] [tinyint] NULL,
	[namSinh] [date] NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[soDienThoai] [int] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngayTao] [datetime] NULL,
	[ngayCapNhat] [datetime] NULL,
	[nguoiTao] [nvarchar](50) NULL,
	[nguoiCapNhat] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 08/19/2021 15:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[maMonHoc] [int] NOT NULL,
	[maGiangVien] [int] NOT NULL,
	[maSinhVien] [int] NOT NULL,
	[diemGV1] [float] NOT NULL,
	[diemGV2] [float] NOT NULL,
	[ngayTao] [datetime] NULL,
	[ngayCapNhat] [datetime] NULL,
	[nguoiTao] [nvarchar](50) NULL,
	[nguoiCapNhat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC,
	[maGiangVien] ASC,
	[maSinhVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_GiangVien_ngayTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [DF_GiangVien_ngayTao]  DEFAULT (getdate()) FOR [ngayTao]
GO
/****** Object:  Default [DF_GiangVien_ngayCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [DF_GiangVien_ngayCapNhat]  DEFAULT (getdate()) FOR [ngayCapNhat]
GO
/****** Object:  Default [DF_GiangVien_nguoiTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [DF_GiangVien_nguoiTao]  DEFAULT ('admin') FOR [nguoiTao]
GO
/****** Object:  Default [DF_GiangVien_nguoiCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [DF_GiangVien_nguoiCapNhat]  DEFAULT ('admin') FOR [nguoiCapNhat]
GO
/****** Object:  Default [DF_MonHoc_ngayTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [DF_MonHoc_ngayTao]  DEFAULT (getdate()) FOR [ngayTao]
GO
/****** Object:  Default [DF_MonHoc_ngayCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [DF_MonHoc_ngayCapNhat]  DEFAULT (getdate()) FOR [ngayCapNhat]
GO
/****** Object:  Default [DF_MonHoc_nguoiTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [DF_MonHoc_nguoiTao]  DEFAULT ('admin') FOR [nguoiTao]
GO
/****** Object:  Default [DF_MonHoc_nguoiCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [DF_MonHoc_nguoiCapNhat]  DEFAULT ('admin') FOR [nguoiCapNhat]
GO
/****** Object:  Default [DF_SinhVien_ngayTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_ngayTao]  DEFAULT (getdate()) FOR [ngayTao]
GO
/****** Object:  Default [DF_SinhVien_ngayCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_ngayCapNhat]  DEFAULT (getdate()) FOR [ngayCapNhat]
GO
/****** Object:  Default [DF_SinhVien_nguoiTao]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_nguoiTao]  DEFAULT ('admin') FOR [nguoiTao]
GO
/****** Object:  Default [DF_SinhVien_nguoiCapNhat]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_nguoiCapNhat]  DEFAULT ('admin') FOR [nguoiCapNhat]
GO
/****** Object:  ForeignKey [FK_Diem_GiangVien]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_GiangVien] FOREIGN KEY([maGiangVien])
REFERENCES [dbo].[GiangVien] ([maGiangVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_GiangVien]
GO
/****** Object:  ForeignKey [FK_Diem_MonHoc]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
/****** Object:  ForeignKey [FK_Diem_SinhVien]    Script Date: 08/19/2021 15:48:43 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
