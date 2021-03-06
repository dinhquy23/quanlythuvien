create database QLTV
USE [QLTV]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 17/08/2021 15:29:22 ******/
--Thu thu nha cc
CREATE TABLE DocGia(
	maDG varchar(10) primary key NOT NULL,
	tenDangNhap varchar(30) NULL,
	matKhau varchar(30) NULL,
	hoTen nvarchar(30) NULL,
	diaChi nvarchar(50) NULL,
	sdt int NULL,
	maThe varchar(10) NULL,
	IDTinhTrang nvarchar(50) NULL,
)
/****** Object:  Table [dbo].[LyDoVP]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE LyDoVP(
	IDLyDo nvarchar(50) primary key NOT NULL,
	LyDo nvarchar(500) NULL,
 )
/****** Object:  Table [dbo].[NhaCC]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE NhaCC(
	maNCC varchar(10) primary key NOT NULL,
	[tenNCC] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
)
insert into NhaCC values('NCC1', N'Thu Huonwg','Vinh Phuc', '09765344')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE ThuThu(
	maTT varchar(10) primary key NOT NULL,
	tenDangNhap varchar(30) NULL,
	matKhau varchar(30) NULL,
	hoTenTT nvarchar(30) NULL,
	diaChi nvarchar(50) NULL,
	sdt int NULL,
)

CREATE TABLE NhanVien(
	maNV varchar(10) primary key NOT NULL,
	hoTenNV nvarchar(30) NULL,
	tenDangNhap varchar(30) NULL,
	matKhau varchar(30) NULL,
	NgaySinh datetime,
	diaChi nvarchar(50) NULL,
	sdt varchar(30) NULL,
	quanLy varchar(10) NULL
	constraint FK_NV_ThuThu foreign key (quanLy) references ThuThu(maTT)
)

CREATE TABLE Sach(
	maSach varchar(10) primary key NOT NULL,
	tenSach nvarchar(30) NULL,
	tinhTrang nvarchar(10) NULL,
	soLuongNhap int NULL,
	gia int NULL,
	namXB int NULL,
	tacGia nvarchar(30) NULL,
	nhaXB nvarchar(30) NULL,
	maNCC varchar(10) NULL,
	nguoiNhap varchar(10) NULL
	constraint FK_Sach_NCC foreign key (maNCC) references NhaCC(maNCC),
	constraint FK_Sach_NV foreign key (nguoiNhap) references ThuThu(maTT),
)
insert into Sach values('S1','s1','s1',1,1,1,'s1','s1','s1','s1')
insert into Sach values('S001', N'Sach', N'1', 12, 20000,N'TG',N'XB','NCC1','123')

GO
insert into NhanVien values('NV1','asdf','ad','123','1/2/2020','12','0987','21s')

CREATE TABLE TinhTrangSach(
	IDTinhTrangSach nvarchar(50) primary key NOT NULL,
	TinhTrangSach nvarchar(50) NULL,
	)

CREATE TABLE TrangThai(
	IDTrangThai nvarchar(50) primary key NOT NULL,
	TrangThai nvarchar(500) NULL,
)

CREATE TABLE PhieuMuonTra(
	maPhieu varchar(10) primary key NOT NULL,
	ngayMuon datetime NULL,
	ngayTra datetime NULL,
	soLuong int NULL,
	IDTinhTrangSach nvarchar(50) NULL,
	maDG varchar(10) NULL,
	nguoiLap varchar(10) NULL,
	maSach varchar(10) NULL,
	IDTrangThai nvarchar(50) NULL,
)
/****** Object:  Table [dbo].[Sach]    Script Date: 17/08/2021 15:29:22 ******/



/****** Object:  Table [dbo].[TheTV]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE TheTV(
	maThe varchar(10) primary key NOT NULL,
	hoTen nvarchar(30) NULL,
	gioiTinh nvarchar(10) NULL,
	sdt int NULL,
	ngayCap datetime NULL,
	hanSd datetime NULL,
)
/****** Object:  Table [dbo].[ThuThu]    Script Date: 17/08/2021 15:29:22 ******/


select * from ThuThu
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 17/08/2021 15:29:22 ******/
insert into ThuThu values('A001','admin','123',N'Trần Thị Thu Hương','Vinh phuc','098765432')
CREATE TABLE TinhTrangDG(
	IDTinhTrang nvarchar(50) primary key NOT NULL,
	TinhTrang nvarchar(50) NULL,
 )
/****** Object:  Table [dbo].[XuLiVP]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE XuLiVP(
	idPhat varchar(10) primary key NOT NULL,
	IDLyDo nvarchar(50) NULL,
	IDXuLy nvarchar(50) NULL,
	ngayXL datetime NULL,
	nguoiXL varchar(10) NULL,
	maThe varchar(10) NULL,
 )
/****** Object:  Table [dbo].[XuLy]    Script Date: 17/08/2021 15:29:22 ******/

CREATE TABLE XuLy(
	IDXuLy nvarchar(50) primary key NOT NULL,
	HinhThucXuLy nvarchar(500) NULL,
 )
INSERT INTO DocGia (maDG, tenDangNhap, matKhau, hoTen, diaChi, sdt, maThe, IDTinhTrang) VALUES (N'MDG01', N'abc123', N'123', N'Nguyễn Văn A', N'Thanh Hóa, Việt Nam', 156744, N'MT01', N'TT01')
INSERT INTO [dbo].[DocGia] ([maDG], [tenDangNhap], [matKhau], [hoTen], [diaChi], [sdt], [maThe], [IDTinhTrang]) VALUES (N'MDG02', N'abc1', N'123', N'Nguyễn Văn B', N'Hà Nội, Việt Nam', 214325, N'MT02', N'TT02')
INSERT INTO [dbo].[DocGia] ([maDG], [tenDangNhap], [matKhau], [hoTen], [diaChi], [sdt], [maThe], [IDTinhTrang]) VALUES (N'MDG03', N'abc23', N'123', N'Phạm Thị C', N'Bắc Giang, Việt Nam', 213234, N'MT03', N'TT03')
INSERT INTO [dbo].[DocGia] ([maDG], [tenDangNhap], [matKhau], [hoTen], [diaChi], [sdt], [maThe], [IDTinhTrang]) VALUES (N'MDG04', N'abc23', N'123', N'Phạm Thi C', N'Thanh Hóa', 213234, N'MT01', N'TT02')
INSERT INTO [dbo].[DocGia] ([maDG], [tenDangNhap], [matKhau], [hoTen], [diaChi], [sdt], [maThe], [IDTinhTrang]) VALUES (N'MDG05', N'abc23', N'123', N'Nguyễn Văn A', N'Thanh Hóa,VietNam', 213234, N'MT01', N'TT04')
GO
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD01', N'Mượn quá hạn lần 1')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD02', N'Trộm tài liệu')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD03', N'Vi phạm nội quy')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD04', N'Làm hỏng tài liệu mượn')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD05', N'Làm mất tài liệu mượn')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD06', N'Cho người khác mượn thẻ thư viện')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD07', N'Mang tài liệu về khi chưa được cho phép hoặc chưa mượn')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD08', N'Sao chép tài liệu thư viện khi chưa được đồng ý')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD09', N'Mang đồ ăn, nước uống vào thư viện')
INSERT INTO LyDoVP (IDLyDo, LyDo) VALUES (N'LD10', N'Mượn quá hạn nhiều lần')
GO
INSERT INTO NhaCC (maNCC, tenNCC, diaChi, sdt) VALUES (N'NCC01', N'Nhà xuất bản Giáo Dục', N'Hà Nội, Việt Nam', 972111141)
INSERT INTO NhaCC (maNCC, tenNCC, diaChi, sdt)  VALUES (N'NCC02', N'Nhà xuất bản trẻ', N'TP.HCM, Việt Nam', 911213131)
INSERT INTO NhaCC (maNCC, tenNCC, diaChi, sdt)  VALUES (N'NCC03', N'Nhà xuất bản Đại Học Sư Phạm', N'Hà Nội, Việt Nam', 913131411)
GO
INSERT INTO NhanVien (maNV, tenDangNhap, matKhau, hoTenNV, diaChi, sdt, quanLy) VALUES (N'NV01', N'dinhquy2312', N'123', N'Nguyễn Đình Quý', N'Thanh Hóa', 972236762, N'MTT01')
INSERT INTO NhanVien (maNV, tenDangNhap, matKhau, hoTenNV, diaChi, sdt, quanLy) VALUES (N'NV02', N'minhduc01', N'123', N'Phạm Minh Đức', N'Bắc Giang', 99142633, N'MTT02')
INSERT INTO NhanVien (maNV, tenDangNhap, matKhau, hoTenNV, diaChi, sdt, quanLy) VALUES (N'NV03', N'phamtuan24', N'123', N'Phạm Văn Tuấn', N'Hà Nội', 92536341, N'MTT03')
GO
INSERT INTO PhieuMuonTra (maPhieu, ngayMuon, ngayTra, soLuong, IDTinhTrangSach, maDG, nguoiLap, maSach, IDTrangThai) VALUES (N'PMT01', CAST(N'2021-05-06T00:00:00.000' AS DateTime), CAST(N'2021-08-08T00:00:00.000' AS DateTime), 1, N'TTS01', N'MDG01', N'NV01', N'MS01', N'TT1')
INSERT INTO PhieuMuonTra (maPhieu, ngayMuon, ngayTra, soLuong, IDTinhTrangSach, maDG, nguoiLap, maSach, IDTrangThai) VALUES (N'PMT02', CAST(N'2021-02-03T00:00:00.000' AS DateTime), CAST(N'2021-08-08T00:00:00.000' AS DateTime), 2, N'TTS02', N'MDG02', N'NV03', N'MS02', N'TT2')
INSERT INTO PhieuMuonTra (maPhieu, ngayMuon, ngayTra, soLuong, IDTinhTrangSach, maDG, nguoiLap, maSach, IDTrangThai) VALUES (N'PMT03', CAST(N'2021-03-07T00:00:00.000' AS DateTime), CAST(N'2021-08-08T00:00:00.000' AS DateTime), 1, N'TTS01', N'MDG03', N'NV03', N'MS03', N'TT4')
GO
INSERT INTO Sach (maSach, tenSach, tinhTrang, soLuongNhap, gia, namXB, tacGia, nhaXB, maNCC, nguoiNhap) VALUES (N'MS01', N'Doraemon', N'còn', 100, 50000, 2020, N'Fujiko Fujio', N'Nhà xuất bản trẻ', N'NCC02', N'MTT01')
INSERT INTO Sach (maSach, tenSach, tinhTrang, soLuongNhap, gia, namXB, tacGia, nhaXB, maNCC, nguoiNhap) VALUES (N'MS02', N'Lập trình căn bản', N'còn', 120, 30000, 2019, N'Nguyễn Văn A', N'Nhà xuất bản Giáo Dục', N'NCC01', N'MTT02')
INSERT INTO Sach (maSach, tenSach, tinhTrang, soLuongNhap, gia, namXB, tacGia, nhaXB, maNCC, nguoiNhap) VALUES (N'MS03', N'Toán cao cấp', N'còn', 50, 60000, 2020, N'Nguyễn Văn B', N'Nhà xuất bản Đại Học Sư Phạm', N'NCC03', N'MTT03')
GO

select * from Sach
select * from NhaCC
INSERT INTO TheTV (maThe, hoTen, gioiTinh, sdt, ngayCap, hanSd) VALUES (N'MT01', N'Nguyễn Văn A', N'Nam', 23456, CAST(N'2021-01-25T00:00:00.000' AS DateTime), CAST(N'2021-12-23T00:00:00.000' AS DateTime))
INSERT INTO TheTV (maThe, hoTen, gioiTinh, sdt, ngayCap, hanSd) VALUES (N'MT02', N'Nguyễn Văn B', N'Nam', 23453, CAST(N'2021-03-04T00:00:00.000' AS DateTime), CAST(N'2021-12-23T00:00:00.000' AS DateTime))
INSERT INTO TheTV (maThe, hoTen, gioiTinh, sdt, ngayCap, hanSd) VALUES (N'MT03', N'Phạm Thị C', N'Nữ', 12345, CAST(N'2021-07-06T00:00:00.000' AS DateTime), CAST(N'2021-12-23T00:00:00.000' AS DateTime))
GO
INSERT INTO ThuThu (maTT, tenDangNhap, matKhau, hoTenTT, diaChi, sdt) VALUES (N'MTT01', N'dinhquy2312', N'123', N'Nguyễn Đình Quý', N'Thanh Hóa', 972236762)

GO
INSERT INTO TinhTrangDG (IDTinhTrang, TinhTrang) VALUES (N'TT01', N'Không mượn tài liệu')
INSERT INTO TinhTrangDG (IDTinhTrang, TinhTrang) VALUES (N'TT02', N'Đang mượn tài liệu')
INSERT INTO TinhTrangDG (IDTinhTrang, TinhTrang) VALUES (N'TT03', N'Đã quá hạn trả')
INSERT INTO TinhTrangDG (IDTinhTrang, TinhTrang) VALUES (N'TT04', N'Đang bị phạt')
GO
INSERT INTO XuLiVP (idPhat,IDLyDo, IDXuLy, ngayXL, nguoiXL, maThe) VALUES (N'P01', N'LD01', N'XL01', CAST(N'2021-08-13T11:03:48.703' AS DateTime), N'NV01', N'MT03')
INSERT INTO XuLiVP (idPhat,IDLyDo, IDXuLy, ngayXL, nguoiXL, maThe) VALUES (N'P02', N'LD02', N'XL02', CAST(N'2021-04-04T00:00:00.000' AS DateTime), N'NV02', N'MT02')
INSERT INTO XuLiVP (idPhat,IDLyDo, IDXuLy, ngayXL, nguoiXL, maThe) VALUES (N'P03', N'LD03', N'XL03', CAST(N'2021-08-03T10:44:35.000' AS DateTime), N'NV02', N'MT01')
GO
INSERT INTO XuLy (IDXuLy, HinhThucXuLy) VALUES (N'XL01', N'Cảnh cáo')
INSERT INTO XuLy (IDXuLy, HinhThucXuLy) VALUES (N'XL02', N'Khóa thể và tài khoản trong 3 tháng')
INSERT INTO XuLy (IDXuLy, HinhThucXuLy) VALUES (N'XL03', N'Khóa thẻ và tài khoản trong 6 tháng')
INSERT INTO XuLy (IDXuLy, HinhThucXuLy) VALUES (N'XL04', N'Bồi thường theo quy định của thư viện')
INSERT INTO XuLy (IDXuLy, HinhThucXuLy) VALUES (N'XL05', N'Hình thức xử lý khác')
GO
INSERT INTO TinhTrangSach (IDTinhTrangSach, TinhTrangSach) VALUES (N'TTS01', N'Sách mới')
INSERT INTO TinhTrangSach (IDTinhTrangSach, TinhTrangSach) VALUES (N'TTS02', N'Sách cũ')
GO
INSERT INTO TrangThai (IDTrangThai, TrangThai) VALUES (N'TT1', N'Đang mượn')
INSERT INTO TrangThai (IDTrangThai, TrangThai) VALUES (N'TT2', N'Đã trả')
INSERT INTO TrangThai (IDTrangThai, TrangThai) VALUES (N'TT4', N'Quá hạn')
GO
ALTER TABLE DocGia  WITH CHECK ADD  CONSTRAINT FK_DocGia_TinhTrang FOREIGN KEY(IDTinhTrang)
REFERENCES TinhTrangDG (IDTinhTrang)
GO
ALTER TABLE DocGia CHECK CONSTRAINT FK_DocGia_TinhTrang
GO
ALTER TABLE DocGia  WITH CHECK ADD  CONSTRAINT fk_maThe1 FOREIGN KEY(maThe)
REFERENCES TheTV (maThe)
GO
ALTER TABLE DocGia CHECK CONSTRAINT fk_maThe
GO
ALTER TABLE NhanVien  WITH CHECK ADD  CONSTRAINT fk_quanLy FOREIGN KEY(quanLy)
REFERENCES ThuThu (maTT)
GO
ALTER TABLE NhanVien CHECK CONSTRAINT fk_quanLy
GO
ALTER TABLE PhieuMuonTra  WITH CHECK ADD  CONSTRAINT fk_maDG FOREIGN KEY(maDG)
REFERENCES DocGia (maDG)
GO
ALTER TABLE PhieuMuonTra CHECK CONSTRAINT fk_maDG
GO
ALTER TABLE PhieuMuonTra  WITH CHECK ADD  CONSTRAINT fk_nguoiLap FOREIGN KEY(nguoiLap)
REFERENCES NhanVien (maNV)
GO
ALTER TABLE PhieuMuonTra CHECK CONSTRAINT fk_nguoiLap
GO
ALTER TABLE PhieuMuonTra  WITH CHECK ADD  CONSTRAINT FK_PhieuMuonTra_Sach FOREIGN KEY(maSach)
REFERENCES Sach (maSach)
GO
ALTER TABLE PhieuMuonTra CHECK CONSTRAINT FK_PhieuMuonTra_Sach
GO
ALTER TABLE PhieuMuonTra  WITH CHECK ADD  CONSTRAINT FK_PhieuMuonTra_TinhTrangSach FOREIGN KEY(IDTinhTrangSach)
REFERENCES TinhTrangSach (IDTinhTrangSach)
GO
ALTER TABLE PhieuMuonTra CHECK CONSTRAINT FK_PhieuMuonTra_TinhTrangSach
GO
ALTER TABLE PhieuMuonTra  WITH CHECK ADD  CONSTRAINT FK_PhieuMuonTra_TrangThai FOREIGN KEY(IDTrangThai)
REFERENCES TrangThai (IDTrangThai)
GO
ALTER TABLE PhieuMuonTra CHECK CONSTRAINT FK_PhieuMuonTra_TrangThai
GO
ALTER TABLE Sach  WITH CHECK ADD  CONSTRAINT fk_maNCC FOREIGN KEY(maNCC)
REFERENCES NhaCC (maNCC)
GO
ALTER TABLE Sach CHECK CONSTRAINT fk_maNCC
GO
ALTER TABLE Sach  WITH CHECK ADD  CONSTRAINT fk_nguoiNhap FOREIGN KEY(nguoiNhap)
REFERENCES ThuThu (maTT)
GO
ALTER TABLE Sach CHECK CONSTRAINT fk_nguoiNhap
GO
ALTER TABLE XuLiVP  WITH CHECK ADD  CONSTRAINT fk_maThe1 FOREIGN KEY(maThe)
REFERENCES TheTV (maThe)
GO
ALTER TABLE XuLiVP CHECK CONSTRAINT fk_maThe1
GO
ALTER TABLE XuLiVP  WITH CHECK ADD  CONSTRAINT fk_nguoiXL FOREIGN KEY(nguoiXL)
REFERENCES NhanVien (maNV)
GO
ALTER TABLE XuLiVP CHECK CONSTRAINT fk_nguoiXL
GO
ALTER TABLE XuLiVP  WITH CHECK ADD  CONSTRAINT FK_XuLiVP_LyDoVP FOREIGN KEY(IDLyDo)
REFERENCES LyDoVP (IDLyDo)
GO
ALTER TABLE XuLiVP CHECK CONSTRAINT FK_XuLiVP_LyDoVP
GO
ALTER TABLE XuLiVP  WITH CHECK ADD  CONSTRAINT FK_XuLiVP_XuLy FOREIGN KEY(IDXuLy)
REFERENCES XuLy (IDXuLy)
GO
ALTER TABLE XuLiVP CHECK CONSTRAINT FK_XuLiVP_XuLy
GO
