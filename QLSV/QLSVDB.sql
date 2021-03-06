USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 11/4/2021 2:01:46 PM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLSV]
GO
/****** Object:  UserDefinedFunction [dbo].[SwapTonal]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SwapTonal] (@text nvarchar(max))
RETURNS nvarchar(max)
AS
BEGIN
    SET @text = LOWER(@text)
    DECLARE @textLen int = LEN(@text)
    IF @textLen > 0
    BEGIN
        DECLARE @index int = 1
        DECLARE @lPos int
        DECLARE @SIGN_CHARS nvarchar(100) = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýđð'
        DECLARE @UNSIGN_CHARS varchar(100) = 'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyydd'
 
        WHILE @index <= @textLen
        BEGIN
            SET @lPos = CHARINDEX(SUBSTRING(@text,@index,1),@SIGN_CHARS)
            IF @lPos > 0
            BEGIN
                SET @text = STUFF(@text,@index,1,SUBSTRING(@UNSIGN_CHARS,@lPos,1))
            END
            SET @index = @index + 1
        END
    END
    RETURN @text
END

GO
/****** Object:  Table [dbo].[Diem]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[maMonHoc] [int] NOT NULL,
	[maGiangVien] [int] NOT NULL,
	[maSinhVien] [int] NOT NULL,
	[diemLan1] [float] NOT NULL CONSTRAINT [DF_Diem_diemLan1]  DEFAULT ((0)),
	[diemLan2] [float] NOT NULL CONSTRAINT [DF_Diem_diemLan2]  DEFAULT ((0)),
	[ngayTao] [datetime] NULL,
	[ngayCapNhat] [datetime] NULL,
	[nguoiTao] [nvarchar](50) NULL,
	[nguoiCapNhat] [nvarchar](50) NULL,
	[maLopHoc] [int] NULL,
	[diemtongket] [float] NULL CONSTRAINT [DF_Diem_diemtongket]  DEFAULT ((0)),
 CONSTRAINT [PK_Diem_1] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC,
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGiangVien] [int] IDENTITY(1,1) NOT NULL,
	[ho] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[namSinh] [date] NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[soDienThoai] [int] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngayTao] [datetime] NULL CONSTRAINT [DF_GiangVien_ngayTao]  DEFAULT (getdate()),
	[ngayCapNhat] [datetime] NULL CONSTRAINT [DF_GiangVien_ngayCapNhat]  DEFAULT (getdate()),
	[nguoiTao] [nvarchar](50) NULL CONSTRAINT [DF_GiangVien_nguoiTao]  DEFAULT ('admin'),
	[nguoiCapNhat] [nvarchar](50) NULL CONSTRAINT [DF_GiangVien_nguoiCapNhat]  DEFAULT ('admin'),
	[gioiTinh] [nvarchar](50) NULL,
	[matKhau] [nvarchar](50) NULL CONSTRAINT [DF_GiangVien_matKhau]  DEFAULT (N'("1234")'),
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ngayTao] [datetime] NULL CONSTRAINT [DF_lopHoc_ngaytao]  DEFAULT (getdate()),
	[nguoiTao] [varchar](30) NULL CONSTRAINT [DF_lopHoc_nguoitao]  DEFAULT ('admin'),
	[ngayCapNhat] [datetime] NULL CONSTRAINT [DF_lopHoc_ngaycapnhat]  DEFAULT (getdate()),
	[nguoiCapNhat] [varchar](30) NULL CONSTRAINT [DF_lopHoc_nguoicapnhat]  DEFAULT ('admin'),
	[maLopHoc] [int] IDENTITY(1,1) NOT NULL,
	[maMonHoc] [int] NULL,
	[maGiangVien] [int] NULL,
	[daKetThuc] [tinyint] NULL CONSTRAINT [DF_lopHoc_daketthuc]  DEFAULT ((0)),
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[maLopHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMonHoc] [int] IDENTITY(1,1) NOT NULL,
	[tenMonHoc] [nvarchar](50) NOT NULL,
	[soTinChi] [int] NULL,
	[ngayTao] [datetime] NULL CONSTRAINT [DF_MonHoc_ngayTao]  DEFAULT (getdate()),
	[ngayCapNhat] [datetime] NULL CONSTRAINT [DF_MonHoc_ngayCapNhat]  DEFAULT (getdate()),
	[nguoiTao] [nvarchar](50) NULL CONSTRAINT [DF_MonHoc_nguoiTao]  DEFAULT ('admin'),
	[nguoiCapNhat] [nvarchar](50) NULL CONSTRAINT [DF_MonHoc_nguoiCapNhat]  DEFAULT ('admin'),
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [int] NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[namSinh] [date] NULL,
	[queQuan] [nvarchar](50) NULL,
	[dienThoai] [int] NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[ngayTao] [datetime] NULL CONSTRAINT [DF_SinhVien_ngayTao]  DEFAULT (getdate()),
	[ngayCapNhat] [datetime] NULL CONSTRAINT [DF_SinhVien_ngayCapNhat]  DEFAULT (getdate()),
	[nguoiTao] [nvarchar](50) NULL CONSTRAINT [DF_SinhVien_nguoiTao]  DEFAULT ('admin'),
	[nguoiCapNhat] [nvarchar](50) NULL CONSTRAINT [DF_SinhVien_nguoiCapNhat]  DEFAULT ('admin'),
	[gioiTinh] [nvarchar](50) NULL,
	[matKhau] [nvarchar](50) NULL CONSTRAINT [DF_SinhVien_matKhau]  DEFAULT ((123)),
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tentaikhoan] [nvarchar](50) NULL,
	[matKhau] [nvarchar](50) NULL,
	[hoTen] [nvarchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (2, 4, 1851050001, 0, 0, NULL, NULL, N'1851050001', NULL, 3, 0)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (2, 3, 1851050010, 0, 0, NULL, NULL, N'1851050010', NULL, 5, 0)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (2, 3, 1851050235, 1, 1, NULL, NULL, NULL, NULL, 5, 1)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (4, 4, 1851050001, 0, 0, NULL, NULL, N'1851050001', NULL, 6, 0)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (4, 4, 1851050235, 5, 1, NULL, CAST(N'2021-10-02 14:30:34.087' AS DateTime), NULL, N'4', 6, 1)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (5, 4, 1851050001, 5, 8, NULL, CAST(N'2021-10-09 19:18:48.730' AS DateTime), N'1851050001', N'0', 1, 7.5)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (5, 4, 1851050010, 6, 7.3, NULL, CAST(N'2021-10-17 15:20:52.013' AS DateTime), N'1851050010', N'0', 1, 6.75)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (5, 4, 1851050235, 7.5, 6.5, NULL, CAST(N'2021-10-16 20:16:51.970' AS DateTime), N'1851050235', N'4', 1, 7)
SET IDENTITY_INSERT [dbo].[GiangVien] ON 

INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (3, N'Nguyễn Công', N'Thành', CAST(N'1995-06-13' AS Date), N'tp.HCM', 123456789, N'thanh@gmail.com', NULL, NULL, NULL, NULL, N'Nam', N'1234')
INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (4, N'Trần Thị Tuyết', N'Nhung', CAST(N'1995-06-13' AS Date), N'tp.HCM', 123456789, N'nhung@gmail.com', NULL, NULL, NULL, NULL, N'Nữ', N'1234')
INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (5, N'Nguyễn Phương', N'Hằng', CAST(N'1995-07-13' AS Date), N'Hồ Chí Minh', 976404568, N'hang.np@gmail.com', NULL, NULL, NULL, NULL, N'Nữ', N'1234')
INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (6, N'Huỳnh Trấn', N'Thành', CAST(N'1995-07-13' AS Date), N'Hà Nội', 123456789, N'HTT@gmail.com', NULL, NULL, NULL, NULL, N'Nam', N'1234')
SET IDENTITY_INSERT [dbo].[GiangVien] OFF
SET IDENTITY_INSERT [dbo].[LopHoc] ON 

INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (CAST(N'2021-09-25 13:36:17.187' AS DateTime), N'admin', CAST(N'2021-09-25 13:36:17.187' AS DateTime), N'admin', 1, 5, 4, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (CAST(N'2021-09-25 13:40:40.893' AS DateTime), N'admin', CAST(N'2021-10-09 19:28:00.867' AS DateTime), N'4', 3, 2, 4, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 4, 5, 3, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 5, 2, 3, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, CAST(N'2021-10-16 20:19:55.083' AS DateTime), N'4', 6, 4, 4, 1)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 7, 4, 4, 0)
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (1, N'Cơ Sở Lập Trình', 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (2, N'Kỹ Thuật Lập Trình', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (4, N'Kiến Trúc Máy Tính', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (5, N'Thiết Kế Web', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (6, N'Hệ Điều Hành', 3, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050001, N'Nguyễn Trần Khánh', N'An', CAST(N'2000-03-01' AS Date), N'Hà Nội', 889342743, N'Hồ Chí Minh', NULL, NULL, NULL, NULL, N'Nữ', N'123')
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050006, N'Nguyễn Văn Hoài ', N'Bảo', CAST(N'2000-07-06' AS Date), N'HCM', 888235641, N'HCM', NULL, NULL, NULL, NULL, N'Nam', N'123')
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050010, N'Đặng Hoàng ', N'Bửu', CAST(N'2000-02-01' AS Date), N'HCM', 3247586, N'HCM', NULL, NULL, NULL, NULL, N'Nam', N'123')
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050235, N'Lê Ngô Nguyệt', N'Ảnh', CAST(N'2000-06-16' AS Date), N'Kiên Giang', 3245687, N'Hồ Chí Minh', NULL, NULL, NULL, NULL, N'Nam', N'123')
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050987, N'Nguyễn Hương', N'Giang', CAST(N'2000-02-08' AS Date), N'Hà Nội', 987654321, N'Hồ Chí Minh', NULL, NULL, NULL, NULL, N'Nữ', N'123')
INSERT [dbo].[TaiKhoan] ([tentaikhoan], [matKhau], [hoTen]) VALUES (N'admin', N'admin', N'Nguyễn Bình')
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_lopHoc_GiangVien] FOREIGN KEY([maGiangVien])
REFERENCES [dbo].[GiangVien] ([maGiangVien])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_lopHoc_GiangVien]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_MonHoc] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_MonHoc]
GO
/****** Object:  StoredProcedure [dbo].[ChamDiem]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ChamDiem]
	@magiangvien int, -- ai chấm <-> nguoif cập nhật trong bảng
	@malop int, -- lớp nào
	@masinhvien int,-- chấm cho ai
	@diemlan1 float,--điểm lần 1 là bnhiu
	@diemlan2 float,--điểm lần 2 là bao nhiu
	@diemtrongket float,
	@trangThai int output
as
begin
	set @diemlan1 = round(@diemlan1,2)
	set @diemlan2 = round(@diemlan2,2)
	set @diemtrongket = round(@diemtrongket,2)
	update Diem
	set
		ngaycapnhat = getdate(),--getdate() là hàm lấy giờ hiện tại của hệ thống
		nguoicapnhat = @magiangvien,		
		diemLan1 = @diemlan1,
		diemLan2 = @diemlan2,
		diemtongket = @diemtrongket
	where malophoc = @malop and masinhvien = @masinhvien;
	if @@ROWCOUNT >0 set @trangThai = 1  -- nếu thực thi thành công trả về 1
	else set @trangThai = 0; -- ngược lại trả về 0
end




GO
/****** Object:  StoredProcedure [dbo].[DangKyMonHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE proc [dbo].[DangKyMonHoc]
		@masinhvien int,
		@malophoc int,
		@kq int output
	as
	begin
		--vì bảng điểm(Diem) chỉ có cột mã lớp học (khóa ngoại) liên kết tới bảng  lớp học(LopHoc) <-> không có thông tin môn học
		--> từ mã lớp cần tìm ra được mã môn học ( nằm trong LopHoc) dựa vào inner join --> khai báo 1 biến để lấy thông tin môn học, cụ thể là mã môn học
		--vì số lần học được tính tự động -> cần khai báo 1 biến để đếm số lần học trước đó
		declare 
				@v_mamonhoc int,
				@v_dadangky int,
				@v_maGiangVien int;
		-- lấy mã môn học dựa vào mã lớp
		select @v_mamonhoc = mamonhoc, @v_maGiangVien = maGiangVien
		from LopHoc
		where malophoc = @malophoc;

		

		-- kiểm tra xem sinh viên này hiện có đăng ký lớp khác học cùng 1 môn hay không
		select @v_dadangky = count(*)
		from Diem d
		inner join LopHoc l on d.malophoc = l.malophoc
		where l.daketthuc = 0 --> lớp đang mở
		and l.mamonhoc = @v_mamonhoc --> môn học này đã đăng ký
		and d.masinhvien = @masinhvien; --> sinh viên xác định

		--> nếu kết quả trả về v_dadangky > 0 --> có nghĩa hiện tại sinh viên này đã đăng ký 1 lớp học cùng môn học này rồi
		if @v_dadangky>0 
			begin
				set @kq = -1;
			end;
		else
			begin
			--> insert dữ liệu vào bảng điểm <-> đăng ký môn học
			insert into Diem(nguoitao,masinhvien,malophoc,maMonHoc,maGiangVien)
			values(@masinhvien,@masinhvien,@malophoc,@v_mamonhoc,@v_maGiangVien);--sinh viên đăng ký -> người tạo = mã sinh viên

			--kiểm tra thực thi câu lệnh sql
			if @@ROWCOUNT > 0 set @kq = 1 else set @kq = 0;
			end;
	end




GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






 CREATE proc [dbo].[DangNhap]
	@loaitaikhoan nvarchar(50),
	@taikhoan varchar(50),
	@matkhau varchar(50),
	@dem int output
as
begin
	
	 set @dem = 0;
	if @loaitaikhoan = 'admin' 
		select @dem = COUNT(*) from taikhoan where tentaikhoan = @taikhoan and matkhau = @matkhau
		else if @loaitaikhoan = 'gv' 
			select @dem = COUNT(*) from GiangVien where cast(maGiangVien as varchar(50)) = @taikhoan and matKhau = @matkhau
		else select @dem = COUNT(*) from SinhVien where masinhvien = @taikhoan and matKhau = @matkhau ;
	
end

GO
/****** Object:  StoredProcedure [dbo].[Diem1MonTheoSV]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[Diem1MonTheoSV]
	@masinhvien int,
	@mamon int
	
as
begin
	
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		
		d.diemLan1,
		d.diemLan2,
		d.diemtongket
	from
	(
		select 
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from LopHoc l
		inner join MonHoc m on l.mamonhoc = m.mamonhoc
		where daketthuc = 0
		
		
	) as tb inner join Diem d on d.maLopHoc = tb.malophoc
	where d.maSinhVien = @masinhvien and d.maMonHoc = @mamon
	
end






GO
/****** Object:  StoredProcedure [dbo].[DiemTatCaHKTheoSV]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE proc [dbo].[DiemTatCaHKTheoSV]
	@masinhvien int
	
as
begin
	
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		
		d.diemLan1,
		d.diemLan2,
		d.diemtongket
	from
	(
		select 
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from LopHoc l
		inner join MonHoc m on l.mamonhoc = m.mamonhoc
		
		
		
	) as tb inner join Diem d on d.maLopHoc = tb.malophoc
	where d.maSinhVien = @masinhvien
	
end







GO
/****** Object:  StoredProcedure [dbo].[DiemTatCaMonTheoSV]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[DiemTatCaMonTheoSV]
	@masinhvien int
	
as
begin
	
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		
		d.diemLan1,
		d.diemLan2,
		d.diemtongket
	from
	(
		select 
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from LopHoc l
		inner join MonHoc m on l.mamonhoc = m.mamonhoc
		where daketthuc = 0
		
		
	) as tb inner join Diem d on d.maLopHoc = tb.malophoc
	where d.maSinhVien = @masinhvien
	
end






GO
/****** Object:  StoredProcedure [dbo].[DSLopChuaDK]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[DSLopChuaDK]
	@masinhvien int
as
begin
	select
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi,
		concat(g.ho,' ',g.ten) as gvien
	from LopHoc l
	inner join GiangVien g on l.maGiangVien = g.maGiangVien
	inner join MonHoc m on l.mamonhoc = m.mamonhoc
	where l.daketthuc = 0 -- lấy các lớp đang mở
	and l.malophoc not in ( select malophoc from Diem where masinhvien = @masinhvien);
end



GO
/****** Object:  StoredProcedure [dbo].[DSLopTheoSinhVien]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[DSLopTheoSinhVien]
	@masinhvien int
	
as
begin
	
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		ISNULL( count(d.masinhvien),0 ) as siso
	from
	(
		select 
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from LopHoc l
		inner join MonHoc m on l.mamonhoc = m.mamonhoc
		where daketthuc = 0
		
		
	) as tb inner join Diem d on d.maLopHoc = tb.malophoc
	where d.maSinhVien = @masinhvien
	group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,
		tb.sotinchi;
end





GO
/****** Object:  StoredProcedure [dbo].[DSSVTheoLop]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[DSSVTheoLop]
	@malophoc int
	
as
begin
	
	select 
		d.masinhvien,
		
		concat(s.ho,' ',s.ten) -- nếu k có tên đệm thì nối họ + tên
		as hoten,
		
		d.diemlan1,
		d.diemlan2,
		d.diemtongket
	from Diem d
	inner join SinhVien s on d.masinhvien = s.masinhvien
	where d.malophoc = @malophoc -- chỉ lấy danh sách lớp tương ứng với 1 mã lớp được truyền vào
	
end




GO
/****** Object:  StoredProcedure [dbo].[DSTatCaLopHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[DSTatCaLopHoc]
	
as
begin
	select
		m.tenMonHoc,
		concat(g.ho, ' ' ,g.ten) as HoTenGiangVien,
		l.maLopHoc,
		g.maGiangVien,
		l.daKetThuc
	from LopHoc l
	inner join GiangVien g on l.maGiangVien = g.maGiangVien
	inner join MonHoc m on l.mamonhoc = m.mamonhoc
	
end
--drop proc selectlophoc



GO
/****** Object:  StoredProcedure [dbo].[HienThiLopTheoGV]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[HienThiLopTheoGV]
	@magiangvien int
	
as
begin
	if @magiangvien = 0 -- là admin truy cập
	begin
				select 
				tb.malophoc,
				tb.mamonhoc,
				tb.tenmonhoc,
				tb.sotinchi,
				ISNULL( count(d.masinhvien),0 ) as siso
			from
			(
				select 
					l.malophoc,
					l.mamonhoc,
					m.tenmonhoc,
					m.sotinchi
				from LopHoc l
				inner join MonHoc m on l.mamonhoc = m.mamonhoc
				where daketthuc = 0
		
		
			) as tb inner join Diem d on d.maLopHoc = tb.malophoc
			group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,
				tb.sotinchi;
	end;
	else -- giảng viên truy cập
	begin
		select 
			tb.malophoc,
			tb.mamonhoc,
			tb.tenmonhoc,
			tb.sotinchi,
			ISNULL( count(d.masinhvien),0 ) as siso
		from
		(
			select 
				l.malophoc,
				l.mamonhoc,
				m.tenmonhoc,
				m.sotinchi
			from LopHoc l
			inner join MonHoc m on l.mamonhoc = m.mamonhoc
			where daketthuc = 0
			and maGiangVien = @magiangvien
		
		) as tb inner join Diem d on d.maLopHoc = tb.malophoc
		group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,
			tb.sotinchi;

	end;
	
end




GO
/****** Object:  StoredProcedure [dbo].[HuyMon]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[HuyMon]
		@maSinhVien int,
		@maLop int,
		@kq int output
	
as
begin

	declare @dem int
	
	delete from Diem 
	where maSinhVien = @maSinhVien and maLopHoc = @maLop
	
	select @dem = COUNT( *)
	from Diem
	where maSinhVien =@maLop and maLopHoc = @maLop

	if @dem > 0 set @kq = 0 else set @kq = 1 --1 xóa thành công / 0 xóa thất bại 
	
end
--drop proc selectlophoc




GO
/****** Object:  StoredProcedure [dbo].[KetThucHocPhan]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[KetThucHocPhan]
	@magiangvien varchar(30), --người kết thúc
	@malop int, -- kết thúc lớp học phần nào
	@trangThai int output
as
begin
	update LopHoc
	set
		nguoicapnhat = @magiangvien,
		ngaycapnhat = getdate(),
		daketthuc = 1
	where malophoc = @malop;
	if @@ROWCOUNT>0 set @trangThai = 1 -- cập nhật thành công
	else set @trangThai = 0; -- thất bại
end



GO
/****** Object:  StoredProcedure [dbo].[ThongTinChiTietSV]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ThongTinChiTietSV]
	@masinhvien int
	
as
begin
	
	select 
		d.masinhvien,
		
		concat(d.Ho,' ',d.Ten) -- nếu k có tên đệm thì nối họ + tên
		as hoten,
		
		d.diaChi,
		d.namSinh,
		d.queQuan,
		d.dienThoai,
		d.matKhau
	from SinhVien d
	where d.maSinhVien = @masinhvien
	
	
end





GO
/****** Object:  StoredProcedure [dbo].[TraCuuGiangVien]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[TraCuuGiangVien]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maGiangVien,
		Ho,
		Ten,
		namSinh,
		gioiTinh,
		email,
		diaChi,
		soDienThoai
		
	from GiangVien
	where lower(ho) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(ho)) like '%'+@tukhoa+'%'
	or lower(gioiTinh) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(gioiTinh)) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(ten)) like '%'+@tukhoa+'%'
	or lower(diaChi) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(diaChi)) like '%'+@tukhoa+'%'
	or lower(email) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(email)) like '%'+@tukhoa+'%'
	or lower(maGiangVien) like '%'+@tukhoa+'%'
	or lower(soDienThoai) like '%'+@tukhoa+'%'
	order by ten;




GO
/****** Object:  StoredProcedure [dbo].[TraCuuLopHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TraCuuLopHoc]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select
		m.tenMonHoc,
		concat(g.ho, ' ' ,g.ten) as HoTenGiangVien,
		l.maLopHoc,
		g.maGiangVien,
		l.maMonHoc
	from LopHoc l
	inner join GiangVien g on l.maGiangVien = g.maGiangVien
	inner join MonHoc m on l.mamonhoc = m.mamonhoc 
	where lower(m.tenMonHoc) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(m.tenMonHoc)) like '%'+@tukhoa+'%'
	or lower(l.maGiangVien) like '%'+@tukhoa+'%'
	or lower(l.maLopHoc) like '%'+@tukhoa+'%'
	or lower(g.ho) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(g.ho)) like '%'+@tukhoa+'%'
	or lower(g.ten) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(g.ten)) like '%'+@tukhoa+'%'
	
	order by maLopHoc;




GO
/****** Object:  StoredProcedure [dbo].[TraCuuMonHoc]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TraCuuMonHoc]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maMonHoc,
		tenMonHoc,
		soTinChi
		
	from MonHoc
	where lower(maMonHoc) like '%'+@tukhoa+'%'
	or lower(tenMonHoc) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(tenMonHoc)) like '%'+@tukhoa+'%'
	or lower(soTinChi) like '%'+@tukhoa+'%'
	
	order by tenMonHoc;




GO
/****** Object:  StoredProcedure [dbo].[TraCuuSinhVien]    Script Date: 11/4/2021 2:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[TraCuuSinhVien]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maSinhVien,
		Ho,		
		Ten,		
		namSinh,
		gioiTinh,
		queQuan,
		diaChi,
		dienThoai
		
	from SinhVien
	where lower(ho) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(Ho)) like '%'+@tukhoa+'%'
	or lower(gioiTinh) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(gioiTinh)) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(ten)) like '%'+@tukhoa+'%'
	or lower(diaChi) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(diaChi)) like '%'+@tukhoa+'%'
	or lower(queQuan) like '%'+@tukhoa+'%' or lower(dbo.SwapTonal(queQuan)) like '%'+@tukhoa+'%'
	or lower(maSinhVien) like '%'+@tukhoa+'%'
	order by ten;

GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
