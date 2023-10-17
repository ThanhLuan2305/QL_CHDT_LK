USE [master]
GO

CREATE DATABASE [QLPKDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPKDT', FILENAME = '/home/vietquoc/SQL/QLPKDT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLPKDT_log', FILENAME = '/home/vietquoc/SQL/SQLQLPKDT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO


IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPKDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPKDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPKDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPKDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPKDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPKDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPKDT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLPKDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPKDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPKDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPKDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPKDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPKDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPKDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPKDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPKDT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLPKDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPKDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPKDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPKDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPKDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPKDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPKDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPKDT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLPKDT] SET  MULTI_USER 
GO
ALTER DATABASE [QLPKDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPKDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPKDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPKDT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLPKDT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLPKDT] SET QUERY_STORE = OFF
GO
USE [QLPKDT]
GO

-- ChiTietDonHang

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaCTDH] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [nvarchar](20) NULL,
	[MaSP] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- DonHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDTKH] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayMua] [datetime] NULL,
	[MaNV] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- KhoHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaSP] [nvarchar](20) NOT NULL,
	[Soluong] [int] NULL,
	[NgayNhap] [date] NULL,
	[TenSP] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- NhaCC
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [nvarchar](20) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDTLH] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- NhanVien
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [nvarchar](20) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Tentk] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- SanPham
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](20) NOT NULL,
	[MaNCC] [nvarchar](20) NULL,
	[TenSP] [nvarchar](50) NULL,
	[HangSP] [nvarchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[Giaban] [float] NULL,
	[TheLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- TaiKhoan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](30) NOT NULL,
	[MatKhau] [nvarchar](30) NOT NULL,
	[PhanQuyen] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP01', 320, CAST(N'2023-05-22' AS Date), N'Ốp tai thỏ')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP02', 700, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP03', 15252, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP04', 3289, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP05', 456, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP06', 8, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP07', 671, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP08', 520, CAST(N'2023-05-22' AS Date), N'Tai nghe')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP09', 293, CAST(N'2023-06-15' AS Date), N'Ốp lưng nhựa TPU')
INSERT [dbo].[KhoHang] ([MaSP], [Soluong], [NgayNhap], [TenSP]) VALUES (N'SP10', 171, CAST(N'2023-05-22' AS Date), N'Ốp tai mèo')
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC01', N'TuanBinh', N'tuanbinh@gmail.com', N'033322233')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC02', N'Anh Dũng', N'dunganh@gmail.com', N'033322232')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC03', N'Xiaomi Hoa Ban', N'xiaomihoaban@gmail.com', N'033322232')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC04', N'Hoàng Đào', N'hoangdao@gmail.com', N'033399999')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC05', N'Quang Huy', N'quanghuy@gmail.com', N'033388888')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC06', N'Anh Minh', N'minhanh@gmail.com', N'033322232')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC07', N'Lan Ngọc', N'lanngoc@gmail.com', N'033322232')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [Email], [SDTLH]) VALUES (N'NCC08', N'Nguyễn Vượng', N'nhatvuong@gmail.com', N'033322232')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV01', N'Huy', N'012345678', N'Hưng Yên', N'huy@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV02', N'Huy', N'012345678', N'Hưng Yên', N'huy@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV03', N'Huy', N'012345678', N'Hưng Yên', N'huy@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV04', N'Phan Văn Vũ', N'012345678', N'Hưng Yên', N'vancu@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV08', N'Huy', N'012345678', N'Hưng Yên', N'huy@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [QueQuan], [Email], [Tentk]) VALUES (N'NV1082', N'Nguyễn Thị Thùy Dung', N'987658902', N'Hà nội', N'dung@gmail.com', N'dung123')
GO
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP01', N'NCC02', N'Ốp tai thỏ', N'Oppo', N'Việt Nam', 30000, N'Ốp lưng')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP02', N'NCC03', N'Tai nghe', N'Nokia', N'Việt Nam', 35000, N'Củ Sạc')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP03', N'NCC05', N'Tai nghe', N'Oppo', N'Việt Nam', 30000, N'Loa Blutooth')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP04', N'NCC05', N'Tai nghe', N'Oppo', N'Việt Nam', 30000, N'Loa Blutooth')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP05', N'NCC03', N'Tai nghe', N'Nokia', N'Campuchia', 30000, N'Tai Nghe')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP06', N'NCC03', N'Tai nghe', N'Nokia', N'Campuchia', 30000, N'Tai Nghe')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP07', N'NCC05', N'Tai nghe', N'Oppo', N'Việt Nam', 30000, N'Loa Blutooth')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP08', N'NCC03', N'Tai nghe', N'Nokia', N'Campuchia', 30000, N'Tai Nghe')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP09', N'NCC05', N'Ốp lưng nhựa TPU', N'Oppo', N'Nhật', 38000, N'Ốp lưng')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP0999', N'NCC06', N'Tai nghe', N'Oppo', N'Việt Nam', 30000, N'Loa Blutooth')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP10', N'NCC08', N'Ốp tai mèo', N'Nokia', N'Việt Nam', 29999, N'Ốp lưng')
INSERT [dbo].[SanPham] ([MaSP], [MaNCC], [TenSP], [HangSP], [XuatXu], [Giaban], [TheLoai]) VALUES (N'SP11', N'NCC07', N'Cáp sạc Type C', N'Huawei', N'Thái Lan', 29999, N'Cáp Sạc')
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'1', N'1', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'a', N'a', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'Admin', N'123', N'Admin')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'bb', N'bb', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'd', N'd', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'dd', N'dd', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'dung123', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'e', N'e', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'h', N'h', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'huy1692003', N'1692003', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'huyok', N'ji', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'huyyy', N'okkkk', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'huyyyy', N'okkkk', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'j', N'j', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'k', N'k', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'l', N'l', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'll', N'll', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'nvquen', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'nhanvien', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'nhanvien123', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'ok', N'ok', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'ok1', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'okne', N'okne', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'tanh123', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'tinh123', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'thanhthao', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'veve', N'veve', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [PhanQuyen]) VALUES (N'vvvv', N'vvvv', N'Nhân Viên')
GO

ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([Tentk])
REFERENCES [dbo].[TaiKhoan] ([TaiKhoan])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
GO
USE [master]
GO
ALTER DATABASE [QLPKDT] SET  READ_WRITE 
GO
