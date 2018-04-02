create database QuanLyNhanSu
go
use QuanLyNhanSu

go
create table ChucVu(
MaChucVu VARCHAR(10) primary key,
TenChucVu nvarchar(50))

go
create table Luong(
BacLuong int primary key,
LuongCoBan INT ,
HeSoLuong int,
HeSoPhuCap int)

GO
create table PhongBan(
MaPB VARCHAR(10) primary key,
TenPB nvarchar(50),
MaTP VARCHAR(10),
DiaChi nvarchar(50),
SDT char(15))

go
create table TrinhDoHocVan(
MaTDHV VARCHAR(10) primary key,
TenTrinhDo nvarchar(50),
ChuyenNganh nvarchar(50))

go
create table NhanVien(
MaNV varchar(10) primary key,
HoTen nvarchar(50),
DanToc nvarchar(50),
GioiTinh BIT,
SDT CHAR(15),
QueQuan nvarchar(50),
NgaySinh date,
MaTDHV VARCHAR(10) REFERENCES TrinhDoHocVan(MaTDHV),
MaPB VARCHAR(10) references PhongBan(MaPB),
BacLuong int references Luong(BacLuong)
)

GO
CREATE TABLE ThoiGianCongTac(
MaNV VARCHAR(10) REFERENCES NhanVien(MaNV),
MaCV VARCHAR(10) REFERENCES ChucVu(MaChucVu),
NgayNhanChuc DATE,
PRIMARY KEY (MaNV,MaCV))

GO
CREATE TABLE NguoiDung
(
	TaiKhoan NVARCHAR(30),
	MatKhau NVARCHAR(30)
)

GO
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( N'admin', -- TaiKhoan - nvarchar(30)
          N'admin'  -- MatKhau - nvarchar(30)
          )
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( N'user1', -- TaiKhoan - nvarchar(30)
          N'1'  -- MatKhau - nvarchar(30)
          )

go
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV01',N'Hoàng Thị Minh','kinh',1,'0976986543',N'Hà Nội','09-08-1990'),
('NV02',N'Nguyễn Quang Huy','kinh',0,'0973686583',N'Vĩnh Phúc','10-19-1990'),
('NV03',N'Ngô Hữu Huy','kinh',0,'0976639201',N'Hà Nam','03-20-1993'),
('NV04',N'Bùi Trung Kiên','kinh',0,'0976863496',N'Hà Nội','12-08-1992'),
('NV05',N'Nguyễn Thị Ngọc','kinh',1,'01647386289',N'Phú Thọ','02-08-1991'),
('NV06',N'Lê Bá Lộc','kinh',0,'0976963984',N'Ha Noi','01-08-1995')

INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV01','CV01','09/06/2013')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV02','CV05','02/21/2014')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV03','CV06','11/19/2012')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV04','CV02','05/11/2016')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV05','CV03','07/28/2015')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV06','CV04','04/20/2013')


DELETE FROM dbo.ThoiGianCongTac
DELETE FROM dbo.ChucVu
INSERT INTO dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV01',N'Giám Đốc')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV02',N'Trường Phòng')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV03',N'Phó Giám Đốc')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV04',N'Phó Phòng')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV05',N'Trường Nhóm')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV06',N'Phó Nhóm')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV07',N'Nhân Viên')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV08',N'Thư Ký')

GO
CREATE PROC SP_DangKi(@taikhoan NVARCHAR(30),@matkhau NVARCHAR(30))
AS
BEGIN
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( @taikhoan, -- TaiKhoan - nvarchar(30)
          @matkhau  -- MatKhau - nvarchar(30)
          )
END

GO


-- 2/4: Sửa CSDL bảng Nhân Viên: trường Giới Tính
ALTER TABLE dbo.NhanVien 
ALTER COLUMN GioiTinh NVARCHAR(5)