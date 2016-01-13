create database CtyQuangVinh
USE [CtyQuangVinh]
GO
/****** Object:  Table [dbo].[VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatLieu](
	[MaVL] [int] IDENTITY(1,1) NOT NULL,
	[TenVL] [nvarchar](50) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[Donvi] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_VatLieu] PRIMARY KEY CLUSTERED 
(
	[MaVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[MaLKH] [int] IDENTITY(1,1) NOT NULL,
	[TenLKH] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_LoaiKH] PRIMARY KEY CLUSTERED 
(
	[MaLKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaCC] [varchar](50) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HDBH]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HDBH](
	[MaHDBH] [varchar](50) NOT NULL,
	[NgayHDBH] [datetime] NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_HDBH] PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [varchar](50) NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomQuyen]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomQuyen](
	[MaNhomQ] [int] NOT NULL,
	[NhomQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhomQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomQ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Sdt] [varchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[Sdt] [varchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[TenDN] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[HoTenuser] [nvarchar](50) NOT NULL,
	[MaNhomQ] [int] NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieudatVLCC]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieudatVLCC](
	[MaPDVLCC] [varchar](50) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[Ngaylap] [datetime] NOT NULL,
	[MaVL] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieudatVLCC] PRIMARY KEY CLUSTERED 
(
	[MaPDVLCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Luong](
	[MaLuong] [varchar](50) NOT NULL,
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[MaCC] [varchar](50) NOT NULL,
	[ThanhTien] [decimal](18, 0) NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNVL_SX]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNVL_SX](
	[MaPNVLSX] [varchar](50) NOT NULL,
	[Ngaylap] [datetime] NOT NULL,
	[MaVL] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNVL_SX] PRIMARY KEY CLUSTERED 
(
	[MaPNVLSX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HD_NVLCC]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HD_NVLCC](
	[MaHDNVL] [varchar](50) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[NgayHD] [datetime] NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HD_NVLCC] PRIMARY KEY CLUSTERED 
(
	[MaHDNVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[Sdt] [varchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[MaLKH] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoVL]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoVL](
	[MaKhoVL] [int] IDENTITY(1,1) NOT NULL,
	[MaVL] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[GhiChu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhoVL] PRIMARY KEY CLUSTERED 
(
	[MaKhoVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[LoaiSP] [int] NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXVL]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXVL](
	[MaPhieuXVL] [varchar](50) NOT NULL,
	[Ngayxuat] [datetime] NOT NULL,
	[MaVL] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXVL] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXSP]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXSP](
	[MaXSP] [varchar](50) NOT NULL,
	[Ngaylap] [datetime] NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXSP] PRIMARY KEY CLUSTERED 
(
	[MaXSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoSP]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoSP](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhoSP] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDH]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonDH](
	[MaDH] [varchar](50) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayDH] [datetime] NOT NULL,
	[NgayGH] [datetime] NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonDH] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD_NVLCC]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD_NVLCC](
	[MaHDNVL] [varchar](50) NOT NULL,
	[MaVL] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Thanhtien] [decimal](18, 0) NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CTHD_NVLCC] PRIMARY KEY CLUSTERED 
(
	[MaHDNVL] ASC,
	[MaVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD_BH]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD_BH](
	[MaHDBH] [varchar](50) NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Thanhtien] [decimal](18, 0) NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CTHD_BH] PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CongNoVatLieu]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongNoVatLieu](
	[MaCNVL] [varchar](50) NOT NULL,
	[MaHDNVL] [varchar](50) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[HanThanhToan] [datetime] NOT NULL,
	[Sotien] [decimal](18, 0) NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CongNoVatLieu] PRIMARY KEY CLUSTERED 
(
	[MaCNVL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CongNoBanHang]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongNoBanHang](
	[MaCNBH] [varchar](50) NOT NULL,
	[MaHDBH] [varchar](50) NOT NULL,
	[MaKH] [int] NOT NULL,
	[Hanthanhtoan] [datetime] NOT NULL,
	[Sotien] [decimal](18, 0) NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CongNoBanHang] PRIMARY KEY CLUSTERED 
(
	[MaCNBH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNSP]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNSP](
	[MaNSP] [varchar](50) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuNSP] PRIMARY KEY CLUSTERED 
(
	[MaNSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XLSC_HDNVL]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XLSC_HDNVL](
	[MaHDNVL] [varchar](50) NOT NULL,
	[MaVL] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XLSC_HDBH]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XLSC_HDBH](
	[MaHDBH] [varchar](50) NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XLSC_PNVLSX]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XLSC_PNVLSX](
	[MaPNVLSX] [varchar](50) NOT NULL,
	[MaVL] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XLSC_PNSP]    Script Date: 04/09/2015 18:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XLSC_PNSP](
	[MaNSP] [varchar](50) NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ghichu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_CongNoBanHang_HDBH]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CongNoBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CongNoBanHang_HDBH] FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HDBH] ([MaHDBH])
GO
ALTER TABLE [dbo].[CongNoBanHang] CHECK CONSTRAINT [FK_CongNoBanHang_HDBH]
GO
/****** Object:  ForeignKey [FK_CongNoBanHang_KhachHang]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CongNoBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CongNoBanHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[CongNoBanHang] CHECK CONSTRAINT [FK_CongNoBanHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_CongNoVatLieu_HD_NVLCC]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CongNoVatLieu]  WITH CHECK ADD  CONSTRAINT [FK_CongNoVatLieu_HD_NVLCC] FOREIGN KEY([MaHDNVL])
REFERENCES [dbo].[HD_NVLCC] ([MaHDNVL])
GO
ALTER TABLE [dbo].[CongNoVatLieu] CHECK CONSTRAINT [FK_CongNoVatLieu_HD_NVLCC]
GO
/****** Object:  ForeignKey [FK_CongNoVatLieu_NhaCungCap]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CongNoVatLieu]  WITH CHECK ADD  CONSTRAINT [FK_CongNoVatLieu_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[CongNoVatLieu] CHECK CONSTRAINT [FK_CongNoVatLieu_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_CTHD_BH_HDBH]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CTHD_BH]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_BH_HDBH] FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HDBH] ([MaHDBH])
GO
ALTER TABLE [dbo].[CTHD_BH] CHECK CONSTRAINT [FK_CTHD_BH_HDBH]
GO
/****** Object:  ForeignKey [FK_CTHD_BH_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CTHD_BH]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_BH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHD_BH] CHECK CONSTRAINT [FK_CTHD_BH_SanPham]
GO
/****** Object:  ForeignKey [FK_CTHD_NVLCC_HD_NVLCC]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CTHD_NVLCC]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_NVLCC_HD_NVLCC] FOREIGN KEY([MaHDNVL])
REFERENCES [dbo].[HD_NVLCC] ([MaHDNVL])
GO
ALTER TABLE [dbo].[CTHD_NVLCC] CHECK CONSTRAINT [FK_CTHD_NVLCC_HD_NVLCC]
GO
/****** Object:  ForeignKey [FK_CTHD_NVLCC_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[CTHD_NVLCC]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_NVLCC_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[CTHD_NVLCC] CHECK CONSTRAINT [FK_CTHD_NVLCC_VatLieu]
GO
/****** Object:  ForeignKey [FK_DonDH_KhachHang]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[DonDH]  WITH CHECK ADD  CONSTRAINT [FK_DonDH_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonDH] CHECK CONSTRAINT [FK_DonDH_KhachHang]
GO
/****** Object:  ForeignKey [FK_DonDH_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[DonDH]  WITH CHECK ADD  CONSTRAINT [FK_DonDH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DonDH] CHECK CONSTRAINT [FK_DonDH_SanPham]
GO
/****** Object:  ForeignKey [FK_HD_NVLCC_NhaCungCap]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[HD_NVLCC]  WITH CHECK ADD  CONSTRAINT [FK_HD_NVLCC_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HD_NVLCC] CHECK CONSTRAINT [FK_HD_NVLCC_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_KhachHang_LoaiKH]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
/****** Object:  ForeignKey [FK_KhoSP_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[KhoSP]  WITH CHECK ADD  CONSTRAINT [FK_KhoSP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[KhoSP] CHECK CONSTRAINT [FK_KhoSP_SanPham]
GO
/****** Object:  ForeignKey [FK_KhoVL_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[KhoVL]  WITH CHECK ADD  CONSTRAINT [FK_KhoVL_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[KhoVL] CHECK CONSTRAINT [FK_KhoVL_VatLieu]
GO
/****** Object:  ForeignKey [FK_Luong_ChamCong]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_ChamCong] FOREIGN KEY([MaCC])
REFERENCES [dbo].[ChamCong] ([MaCC])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_ChamCong]
GO
/****** Object:  ForeignKey [FK_Luong_NhanVien]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieudatVLCC_NhaCungCap]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieudatVLCC]  WITH CHECK ADD  CONSTRAINT [FK_PhieudatVLCC_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieudatVLCC] CHECK CONSTRAINT [FK_PhieudatVLCC_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_PhieudatVLCC_NhaCungCap1]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieudatVLCC]  WITH CHECK ADD  CONSTRAINT [FK_PhieudatVLCC_NhaCungCap1] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieudatVLCC] CHECK CONSTRAINT [FK_PhieudatVLCC_NhaCungCap1]
GO
/****** Object:  ForeignKey [FK_PhieudatVLCC_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieudatVLCC]  WITH CHECK ADD  CONSTRAINT [FK_PhieudatVLCC_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[PhieudatVLCC] CHECK CONSTRAINT [FK_PhieudatVLCC_VatLieu]
GO
/****** Object:  ForeignKey [FK_PhieuNSP_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieuNSP]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNSP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[PhieuNSP] CHECK CONSTRAINT [FK_PhieuNSP_SanPham]
GO
/****** Object:  ForeignKey [FK_PhieuNVL_SX_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieuNVL_SX]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNVL_SX_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[PhieuNVL_SX] CHECK CONSTRAINT [FK_PhieuNVL_SX_VatLieu]
GO
/****** Object:  ForeignKey [FK_PhieuXSP_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieuXSP]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXSP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[PhieuXSP] CHECK CONSTRAINT [FK_PhieuXSP_SanPham]
GO
/****** Object:  ForeignKey [FK_PhieuXVL_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[PhieuXVL]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXVL_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[PhieuXVL] CHECK CONSTRAINT [FK_PhieuXVL_VatLieu]
GO
/****** Object:  ForeignKey [FK_SanPham_LoaiSP]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([LoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
/****** Object:  ForeignKey [FK_XLSC_HDBH_HDBH]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_HDBH]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_HDBH_HDBH] FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HDBH] ([MaHDBH])
GO
ALTER TABLE [dbo].[XLSC_HDBH] CHECK CONSTRAINT [FK_XLSC_HDBH_HDBH]
GO
/****** Object:  ForeignKey [FK_XLSC_HDBH_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_HDBH]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_HDBH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[XLSC_HDBH] CHECK CONSTRAINT [FK_XLSC_HDBH_SanPham]
GO
/****** Object:  ForeignKey [FK_XLSC_HDNVL_HD_NVLCC]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_HDNVL]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_HDNVL_HD_NVLCC] FOREIGN KEY([MaHDNVL])
REFERENCES [dbo].[HD_NVLCC] ([MaHDNVL])
GO
ALTER TABLE [dbo].[XLSC_HDNVL] CHECK CONSTRAINT [FK_XLSC_HDNVL_HD_NVLCC]
GO
/****** Object:  ForeignKey [FK_XLSC_HDNVL_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_HDNVL]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_HDNVL_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[XLSC_HDNVL] CHECK CONSTRAINT [FK_XLSC_HDNVL_VatLieu]
GO
/****** Object:  ForeignKey [FK_XLSC_PNSP_PhieuNSP]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_PNSP]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_PNSP_PhieuNSP] FOREIGN KEY([MaNSP])
REFERENCES [dbo].[PhieuNSP] ([MaNSP])
GO
ALTER TABLE [dbo].[XLSC_PNSP] CHECK CONSTRAINT [FK_XLSC_PNSP_PhieuNSP]
GO
/****** Object:  ForeignKey [FK_XLSC_PNSP_SanPham]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_PNSP]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_PNSP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[XLSC_PNSP] CHECK CONSTRAINT [FK_XLSC_PNSP_SanPham]
GO
/****** Object:  ForeignKey [FK_XLSC_PNVLSX_PhieuNVL_SX]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_PNVLSX]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_PNVLSX_PhieuNVL_SX] FOREIGN KEY([MaPNVLSX])
REFERENCES [dbo].[PhieuNVL_SX] ([MaPNVLSX])
GO
ALTER TABLE [dbo].[XLSC_PNVLSX] CHECK CONSTRAINT [FK_XLSC_PNVLSX_PhieuNVL_SX]
GO
/****** Object:  ForeignKey [FK_XLSC_PNVLSX_VatLieu]    Script Date: 04/09/2015 18:29:20 ******/
ALTER TABLE [dbo].[XLSC_PNVLSX]  WITH CHECK ADD  CONSTRAINT [FK_XLSC_PNVLSX_VatLieu] FOREIGN KEY([MaVL])
REFERENCES [dbo].[VatLieu] ([MaVL])
GO
ALTER TABLE [dbo].[XLSC_PNVLSX] CHECK CONSTRAINT [FK_XLSC_PNVLSX_VatLieu]
GO
