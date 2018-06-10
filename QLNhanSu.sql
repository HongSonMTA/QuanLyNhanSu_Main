create database QuanLyNhanSu
go
use QuanLyNhanSu

go
create table ChucVu(
MaChucVu VARCHAR(10) primary key,
TenChucVu nvarchar(50))

go
create table Luong(
BacLuong VARCHAR(10) primary key,
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
GioiTinh NVARCHAR(5) CHECK(GioiTinh IN (N'Nam',N'Nữ')),
SDT CHAR(15),
QueQuan nvarchar(50),
NgaySinh date,
MaTDHV VARCHAR(10) REFERENCES TrinhDoHocVan(MaTDHV),
MaPB VARCHAR(10) references PhongBan(MaPB),
BacLuong VARCHAR(10) references Luong(BacLuong)
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
INSERT INTO dbo.PhongBan 
        ( MaPB, TenPB, DiaChi, SDT, MaTP )
VALUES  ( 'PB01', -- MaPB - varchar(10)
          N'Hành Chính', -- TenPB - nvarchar(50)
          N'hà Nội', -- DiaChi - nvarchar(50)
          '111111111111111', -- SDT - char(15)
          'NV01'  -- MaTP - varchar(10)
          )


-- 2/4: Sửa CSDL bảng Nhân Viên: trường Giới Tính
ALTER TABLE dbo.NhanVien 
ALTER COLUMN GioiTinh NVARCHAR(5)