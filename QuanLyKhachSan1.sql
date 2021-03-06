USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[DanhSachSuDungDV]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhSachSuDungDV](
	[Ma] [varchar](5) NOT NULL,
	[MaDV] [varchar](5) NULL,
	[MaNhanPhong] [varchar](5) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [varchar](5) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](5) NOT NULL,
	[MaKH] [varchar](5) NULL,
	[MaNV] [varchar](5) NULL,
	[MaNhanPhong] [varchar](5) NULL,
	[MaSDDV] [varchar](5) NULL,
	[TienDV] [float] NULL,
	[HinhThucThanhToan] [nvarchar](5) NULL,
	[PhuThu] [float] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](5) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](4) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[CMND] [varchar](20) NULL,
	[SoDT] [varchar](12) NULL,
	[QuocTich] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDT] [varchar](12) NULL,
	[NgayVaoLam] [date] NULL,
 CONSTRAINT [PK__NhanVien__2725D70AF8F492E2] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhanPhong]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhanPhong](
	[MaNhanPhong] [varchar](5) NOT NULL,
	[MaPhong] [varchar](5) NULL,
	[MaKH] [varchar](5) NULL,
	[NgayNhan] [datetime] NULL,
	[NgayTra] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](5) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[TinhTrang] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[username] [varchar](20) NOT NULL,
	[pass] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaTB] [varchar](5) NOT NULL,
	[MaPhong] [varchar](5) NULL,
	[TenTB] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS01', N'DV01', N'MaN01', 1)
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS02', N'DV02', N'MaN03', 3)
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS03', N'DV01', N'MaN03', 2)
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS04', N'DV02', N'MaN02', 1)
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS05', N'DV03', N'MaN01', 2)
INSERT [dbo].[DanhSachSuDungDV] ([Ma], [MaDV], [MaNhanPhong], [SoLuong]) VALUES (N'DS06', N'DV02', N'MaN03', 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV01', N'Dịch vụ ăn uống', 100000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV02', N'Dịch vụ chăm sóc da mặt', 300000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV03', N'Dịch vụ cho thuê xe lái riêng', 400000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV04', N'Dịch vụ chăm sóc tóc', 500000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV06', N'Dịch vụ cho thuê xe có lái ( hoặc không lái ) ', 300000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV07', N'Dịch vụ cho thuê xe đạp đôi', 400000)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K1009', N'Nguyễn Thị Thúy', N'Nữ', N'Hà Nam', N'16540988', N'0987534422', N'Việt Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K1054', N'Hoàng Diệp Thúy', N'Nữ', N'Hà Nam', N'29870544', N'0987654356', N'Việt Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K1098', N'Trần Văn Bàng', N'Nam', N'Hà Nội', N'17049855', N'0977654234', N'Việt Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K2004', N'Lê Minh Hoàng', N'Nam', N'Hòa Bình ', N'13450976', N'0923284131', N'Việt Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K2005', N'Trần Thị Minh Ngọc', N'Nữ', N'Sơn La', N'13942312', N'0944211113', N'Việt Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [CMND], [SoDT], [QuocTich]) VALUES (N'K2009', N'Hoàng Vũ Diệp', N'Nữ', N'Hải Dương', N'14590875', N'0923587903', N'Việt Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV02', N'Trần Văn Bản', CAST(N'1900-01-13' AS Date), N'Nam', N'Hải Phòng', N'0943198766', CAST(N'1900-02-03' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV03', N'Trần Thị Hương', CAST(N'1900-01-10' AS Date), N'Nữ', N'Hà Nam', N'0977413311', CAST(N'1900-02-25' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV05', N'Trần Văn Hòa', CAST(N'1987-12-03' AS Date), N'Nam', N'Hải Dương', N'0965323231', CAST(N'2014-12-05' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV06', N'Nguyễn Văn A', CAST(N'1992-05-04' AS Date), N'Nữ', N'Hà Nội', N'096643543', CAST(N'2017-05-04' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV07', N'Trần Thị C', CAST(N'1990-05-04' AS Date), N'Nữ', N'Hà Nam', N'09766543123', CAST(N'2017-05-04' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV08', N'Nguyễn Thị D', CAST(N'1987-12-08' AS Date), N'Nữ', N'Nam Định', N'0243565436', CAST(N'2011-09-21' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV09', N'Hoàng Thị Ngọc ', CAST(N'1988-10-12' AS Date), N'Nữ', N'Ninh Thuận', N'0798665444', CAST(N'2009-09-10' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV10', N'Trần Hoàng Hà', CAST(N'1989-05-15' AS Date), N'Nữ', N'Hà Nội', N'08525244112', CAST(N'2010-05-15' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV11', N'Trần Thị B', CAST(N'1992-07-03' AS Date), N'Nữ', N'Nam Định', N'9942352524', CAST(N'2010-04-23' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV12', N'Nguyễn Văn C', CAST(N'1993-12-12' AS Date), N'Nam', N'Hà Nam', N'0987544432', CAST(N'2011-12-13' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV13', N'Nguyễn Văn Anh', CAST(N'1987-05-17' AS Date), N'Nữ', N'Hà Nam', N'09745646345', CAST(N'2017-05-17' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV14', N'Trần Thị Bắc', CAST(N'2017-05-17' AS Date), N'Nữ', N'Hà Tĩnh', N'098764322', CAST(N'2017-05-17' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV16', N'Hoàng Thị Ngọc', CAST(N'2017-05-17' AS Date), N'Nữ', N'Bắc Ninh', N'02482184124', CAST(N'2017-05-17' AS Date))
INSERT [dbo].[PhieuNhanPhong] ([MaNhanPhong], [MaPhong], [MaKH], [NgayNhan], [NgayTra]) VALUES (N'MaN01', N'H3409', N'K2009', CAST(N'1900-02-26 00:00:00.000' AS DateTime), CAST(N'1900-02-14 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuNhanPhong] ([MaNhanPhong], [MaPhong], [MaKH], [NgayNhan], [NgayTra]) VALUES (N'MaN02', N'H3509', N'K1054', CAST(N'1900-02-26 00:00:00.000' AS DateTime), CAST(N'1900-02-03 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuNhanPhong] ([MaNhanPhong], [MaPhong], [MaKH], [NgayNhan], [NgayTra]) VALUES (N'MaN03', N'H3508', N'K1098', CAST(N'1900-02-26 00:00:00.000' AS DateTime), CAST(N'1900-02-14 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuNhanPhong] ([MaNhanPhong], [MaPhong], [MaKH], [NgayNhan], [NgayTra]) VALUES (N'MaN04', N'H3507', N'K1009', CAST(N'1900-03-26 00:00:00.000' AS DateTime), CAST(N'1900-02-26 00:00:00.000' AS DateTime))
INSERT [dbo].[Phong] ([MaPhong], [TenLoaiPhong], [DonGia], [TinhTrang]) VALUES (N'H3409', N'Bình dân', 150000, N'Trong')
INSERT [dbo].[Phong] ([MaPhong], [TenLoaiPhong], [DonGia], [TinhTrang]) VALUES (N'H3507', N'Bình dân', 100000, N'Khong trong')
INSERT [dbo].[Phong] ([MaPhong], [TenLoaiPhong], [DonGia], [TinhTrang]) VALUES (N'H3508', N'Vip', 400000, N'300000')
INSERT [dbo].[Phong] ([MaPhong], [TenLoaiPhong], [DonGia], [TinhTrang]) VALUES (N'H3509', N'Bình dân', 100000, N'Trong')
INSERT [dbo].[Phong] ([MaPhong], [TenLoaiPhong], [DonGia], [TinhTrang]) VALUES (N'H5901', N'Vip', 1000000, N'Còn phòng')
INSERT [dbo].[TaiKhoan] ([username], [pass]) VALUES (N'bichthao@gmail.com', N'123456')
INSERT [dbo].[TaiKhoan] ([username], [pass]) VALUES (N'thanhtu12@gmail.com', N'123456')
INSERT [dbo].[TaiKhoan] ([username], [pass]) VALUES (N'ngocthu25@gmail.com', N'123456')
ALTER TABLE [dbo].[DanhSachSuDungDV]  WITH CHECK ADD FOREIGN KEY([MaNhanPhong])
REFERENCES [dbo].[PhieuNhanPhong] ([MaNhanPhong])
GO
ALTER TABLE [dbo].[DanhSachSuDungDV]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNhanPhong])
REFERENCES [dbo].[PhieuNhanPhong] ([MaNhanPhong])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__MaNV__267ABA7A] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__MaNV__267ABA7A]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaSDDV])
REFERENCES [dbo].[DanhSachSuDungDV] ([Ma])
GO
ALTER TABLE [dbo].[PhieuNhanPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[PhieuNhanPhong]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
/****** Object:  StoredProcedure [dbo].[DelNhanvien]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DelNhanvien]
@MaNV varchar(5)
as 
begin
	delete NhanVien where MaNV=@MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[pc_InsertNV]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pc_InsertNV]
(
  @MaNV varchar(5),
  @TenNV nvarchar(50),
  @NgaySinh datetime,
  @GioiTinh nvarchar(4),
  @DiaChi nvarchar(100),
  @SODT varchar(12),
  @NgayVaoLam datetime
)
as
begin 
	insert into NhanVien values(@MaNV,@TenNV,@NgaySinh,@GioiTinh,@DiaChi,@SODT,@NgayVaoLam)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaNV]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_SuaNV](@MaNV varchar(5),
                     @TenNV nvarchar(50),
					 @NgaySinh date,
					 @GioiTinh nvarchar(4),
					 @DiaChi varchar(100),
					 @SoDT varchar(12),
					 @NgayVaoLam date
)
as
begin 
update NhanVien
set MaNV=@MaNV ,TenNV=@TenNV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh,DiaChi=@DiaChi, SoDT=@SoDT, NgayVaoLam=@NgayVaoLam
where MaNV=@MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDLDichVu]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapDLDichVu]
(
@MaDV varchar(5),
@TenDV nvarchar(50),
@DonGia float
)
as begin insert into DichVu values(@MaDV,@TenDV,@DonGia) 
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDLKhachHang]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapDLKhachHang]
(
@makh varchar(5),
@TenKH nvarchar(50),
@GioiTinh nvarchar(4),
@DiaChi nvarchar(100),
@CMND varchar(20),
@SoDT varchar(12),
@QuocTich nvarchar(20)
)
as begin insert into KhachHang values(@makh,@TenKH,@GioiTinh,@DiaChi,@CMND,@SoDT,@QuocTich)
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDLNhanVien]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spNhapDLNhanVien]
(@manv varchar(5),
@TenNV nvarchar(50),
@NgaySinh datetime,
@GioiTinh nvarchar(4),
@DiaChi nvarchar(100),
@SoDT varchar(12),
@NgayVaoLam datetime
)

as begin insert into NhanVien values(@manv,@TenNV,@NgaySinh,@GioiTinh,@DiaChi,@SoDT,@NgayVaoLam)
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDLPhieuNhanPhong]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapDLPhieuNhanPhong]
(
@manhan varchar(5),
@maPhong varchar(5),
@maKH varchar(5),
@NgayNhan datetime,
@NgayTra datetime
)
as begin insert into PhieuNhanPhong values(@manhan,@maPhong,@maKH,@NgayNhan,@NgayTra)
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDLPhong]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapDLPhong]
(
@maphong varchar(5),
@TenLoaiPhong nvarchar(50),
@DonGia float,
@TinhTrang nvarchar(20)
)
as begin insert into Phong values(@maphong,@TenLoaiPhong,@DonGia,@TinhTrang)
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapDSSDDichVu]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapDSSDDichVu]
(
@ma varchar(5),
@MaDV varchar(5),
@MaNhanPhong varchar(5),
@Soluong int
)
as begin insert into DanhSachSuDungDV values(@ma,@MaDV,@MaNhanPhong,@Soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[spNhapThietBi]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spNhapThietBi]
(
@maTB varchar(5),
@MaPhong varchar(5),
@TenTB nvarchar(50),
@SoLuong int
)
as begin insert into ThietBi values(@maTB,@MaPhong,@TenTB,@SoLuong)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanvien]    Script Date: 5/23/2017 4:15:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[UpdateNhanvien]
@MaNV varchar(5),
@TenNV nvarchar(50),
@NgaySinh date,
@GioiTinh nvarchar(4),
@DiaChi nvarchar(100),
@SoDT varchar(12),
@NgayVaoLam date
as 
begin
	Update NhanVien 
	set TenNV=@TenNV,
		NgaySinh=@NgaySinh,
		GioiTinh=@GioiTinh,
		DiaChi=@DiaChi,
		SoDT=@SoDT,
		NgayVaoLam=@NgayVaoLam
	where MaNV=@MaNV
end
GO
