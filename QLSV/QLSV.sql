USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[Diem]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[GiangVien]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[LoaiGioiTinh]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiGioiTinh](
	[MaGioTinh] [tinyint] NOT NULL,
	[TenGioiTinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiGioiTinh_1] PRIMARY KEY CLUSTERED 
(
	[MaGioTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[MonHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[SinhVien]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/2/2021 3:27:59 PM ******/
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
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (2, 4, 1851050001, 1, 1, NULL, CAST(N'2021-10-02 13:41:11.810' AS DateTime), NULL, N'4', 3, 1)
INSERT [dbo].[Diem] ([maMonHoc], [maGiangVien], [maSinhVien], [diemLan1], [diemLan2], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [maLopHoc], [diemtongket]) VALUES (4, 4, 1851050235, 5, 1, NULL, CAST(N'2021-10-02 14:30:34.087' AS DateTime), NULL, N'4', 6, 1)
SET IDENTITY_INSERT [dbo].[GiangVien] ON 

INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1, N'qưew', N'qưew', CAST(N'2016-06-07' AS Date), N'sè', 123456789, N'sdf', NULL, NULL, NULL, NULL, N'Nữ', NULL)
INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (3, N'Nguyễn Công', N'Thành', CAST(N'1995-06-13' AS Date), N'tp.HCM', 123456789, N'thanh@gmail.com', NULL, NULL, NULL, NULL, N'Nam', NULL)
INSERT [dbo].[GiangVien] ([maGiangVien], [ho], [ten], [namSinh], [diaChi], [soDienThoai], [email], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (4, N'Trần Thị Tuyết', N'Nhung', CAST(N'1995-06-13' AS Date), N'tp.HCM', 123456789, N'nhung@gmail.com', NULL, NULL, NULL, NULL, N'Nữ', NULL)
SET IDENTITY_INSERT [dbo].[GiangVien] OFF
INSERT [dbo].[LoaiGioiTinh] ([MaGioTinh], [TenGioiTinh]) VALUES (0, N'Nữ')
INSERT [dbo].[LoaiGioiTinh] ([MaGioTinh], [TenGioiTinh]) VALUES (1, N'Nam')
INSERT [dbo].[LoaiGioiTinh] ([MaGioTinh], [TenGioiTinh]) VALUES (3, N'Khác')
SET IDENTITY_INSERT [dbo].[LopHoc] ON 

INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (CAST(N'2021-09-25 13:36:17.187' AS DateTime), N'admin', CAST(N'2021-09-25 13:36:17.187' AS DateTime), N'admin', 1, 5, 4, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (CAST(N'2021-09-25 13:39:07.123' AS DateTime), N'admin', CAST(N'2021-09-25 13:39:07.123' AS DateTime), N'admin', 2, 1, 1, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (CAST(N'2021-09-25 13:40:40.893' AS DateTime), N'admin', CAST(N'2021-09-25 13:40:40.893' AS DateTime), N'admin', 3, 2, 4, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 4, 5, 3, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 5, 2, 3, 0)
INSERT [dbo].[LopHoc] ([ngayTao], [nguoiTao], [ngayCapNhat], [nguoiCapNhat], [maLopHoc], [maMonHoc], [maGiangVien], [daKetThuc]) VALUES (NULL, NULL, NULL, NULL, 6, 4, 4, 0)
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (1, N'Cơ Sở Lập Trình', 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (2, N'Kỹ Thuật Lập Trình', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (4, N'Kiến Trúc Máy Tính', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (5, N'Thiết Kế Web', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat]) VALUES (6, N'Hệ Điều Hành', 3, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050001, N'Nguyễn Trần Khánh', N'An', CAST(N'2000-03-01' AS Date), N'Hà Nội', 889342743, N'Hồ Chí Minh', NULL, NULL, NULL, NULL, N'Nữ', N'123')
INSERT [dbo].[SinhVien] ([maSinhVien], [Ho], [Ten], [namSinh], [queQuan], [dienThoai], [diaChi], [ngayTao], [ngayCapNhat], [nguoiTao], [nguoiCapNhat], [gioiTinh], [matKhau]) VALUES (1851050235, N'Lê Ngô Nguyệt', N'Ảnh', CAST(N'2000-06-16' AS Date), N'Kiên Giang', 0, N'Hồ Chí Minh', NULL, NULL, NULL, NULL, N'Nữ', N'123')
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
/****** Object:  StoredProcedure [dbo].[chamdiem]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[chamdiem]
	@magiangvien int, -- ai chấm <-> nguoif cập nhật trong bảng
	@malop int, -- lớp nào
	@masinhvien int,-- chấm cho ai
	@diemlan1 float,--điểm lần 1 là bnhiu
	@diemlan2 float,--điểm lần 2 là bao nhiu
	@diemtrongket float,
	@trangThai int output
as
begin
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
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






 create proc [dbo].[dangnhap]
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
			select @dem = COUNT(*) from GiangVien where cast(maGiangVien as varchar(50)) = @taikhoan and @matkhau = @matkhau
		else select @dem = COUNT(*) from SinhVien where masinhvien = @taikhoan and matkhau = @matkhau ;
	
end
GO
/****** Object:  StoredProcedure [dbo].[DSSVTheoLop]    Script Date: 10/2/2021 3:27:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[HienThiLopTheoGV]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[HienThiLopTheoGV]
	@magiangvien int
	
as
begin
	
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		count(d.masinhvien) as siso
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
end



GO
/****** Object:  StoredProcedure [dbo].[insertlophoc]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[insertlophoc]
	
	@magiaovien int,
	@mamonhoc int
as
begin
	insert into LopHoc(mamonhoc,maGiangVien)
	values(@mamonhoc,@magiaovien);
	if @@ROWCOUNT > 0 return 1 else return 0;
end



GO
/****** Object:  StoredProcedure [dbo].[ketthuchocphan]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[ketthuchocphan]
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
/****** Object:  StoredProcedure [dbo].[selectALLLopHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[selectALLLopHoc]
	
as
begin
	select
		m.tenMonHoc,
		g.ten,
		l.maLopHoc
	from LopHoc l
	inner join GiangVien g on l.maGiangVien = g.maGiangVien
	inner join MonHoc m on l.mamonhoc = m.mamonhoc
	
end
--drop proc selectlophoc


GO
/****** Object:  StoredProcedure [dbo].[selectLopHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectLopHoc]
	@malophoc bigint
as
begin
	select
		m.tenmonhoc,
		g.maGiangVien,
		l.mamonhoc
	from LopHoc l
	inner join GiangVien g on l.maGiangVien = g.maGiangVien
	inner join MonHoc m on l.mamonhoc = m.mamonhoc
	where malophoc = @malophoc;
end
--drop proc selectlophoc


GO
/****** Object:  StoredProcedure [dbo].[TraCuuGiangVien]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






create procedure [dbo].[TraCuuGiangVien]
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
	where lower(ho) like '%'+@tukhoa+'%'
	or lower(gioiTinh) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%'
	or lower(diaChi) like '%'+@tukhoa+'%'
	or lower(email) like '%'+@tukhoa+'%'
	or lower(maGiangVien) like '%'+@tukhoa+'%'
	or lower(soDienThoai) like '%'+@tukhoa+'%'
	order by ten;



GO
/****** Object:  StoredProcedure [dbo].[TraCuuLopHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[TraCuuLopHoc]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maLopHoc,
		maMonHoc,
		maGiangVien
		
		
		
	from LopHoc
	where lower(maMonHoc) like '%'+@tukhoa+'%'
	or lower(maGiangVien) like '%'+@tukhoa+'%'
	or lower(maMonHoc) like '%'+@tukhoa+'%'
	
	order by maLopHoc;



GO
/****** Object:  StoredProcedure [dbo].[TraCuuMonHoc]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[TraCuuMonHoc]
	@tukhoa nvarchar(50)
as
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maMonHoc,
		tenMonHoc,
		soTinChi
		
	from MonHoc
	where lower(maMonHoc) like '%'+@tukhoa+'%'
	or lower(tenMonHoc) like '%'+@tukhoa+'%'
	or lower(soTinChi) like '%'+@tukhoa+'%'
	
	order by tenMonHoc;



GO
/****** Object:  StoredProcedure [dbo].[TraCuuSinhVien]    Script Date: 10/2/2021 3:27:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[TraCuuSinhVien]
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
		--maSinhVien,
		--ho,ten
		--else concat(ho,' ',tendem,' ',ten) end as hoten,
		--convert(varchar(10),ngaysinh,103) as nsinh,
		--case when gioitinh = 1 then 'Nam' else N'Nữ' end as gt,
		--quequan,diachi,dienthoai,email
	from SinhVien
	where lower(ho) like '%'+@tukhoa+'%'
	or lower(gioiTinh) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%'
	or lower(diaChi) like '%'+@tukhoa+'%'
	or lower(queQuan) like '%'+@tukhoa+'%'
	or lower(maSinhVien) like '%'+@tukhoa+'%'
	order by ten;


GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
