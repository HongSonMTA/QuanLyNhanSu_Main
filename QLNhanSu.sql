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
GioiTinh NVARCHAR(5) CHECK(GioiTinh IN (N'Nam',N'Nữ')),
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
values ('NV01','Hoàng Thị Minh','kinh',N'Nữ','0976986543',N'Hà Nội','09-08-1990'),
('NV02',N'Nguyễn Quang Huy','kinh','Nam','0973686583',N'Vĩnh Phúc','10-19-1990'),
('NV03',N'Ngô Hữu Huy','kinh','Nam','0976639201',N'Hà Nam','03-20-1993'),
('NV04',N'Bùi Trung Kiên','kinh','Nam','0976863496',N'Hà Nội','12-08-1992'),
('NV05',N'Nguyễn Thị Ngọc','kinh',N'Nữ','01647386289',N'Phú Thọ','02-08-1991'),
('NV06',N'Lê Bá Lộc','kinh','Nam','0976963984',N'Ha Noi','01-08-1995')


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
CREATE PROC Them_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	INSERT INTO dbo.PhongBan( MaPB, TenPB,MaTP, DiaChi, SDT )
	VALUES  (@MaPb,@TenPB,@MaTP,@DiaChi,@Sdt )
END

GO
CREATE PROC Sua_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	UPDATE dbo.PhongBan
	SET TenPB = @TenPB,MaTP = @MaTP,DiaChi = @DiaChi,SDT=@Sdt
	WHERE MaPB = @MaPb
END

GO 
CREATE PROC Xoa_PB (@Ma varchar(10))
AS
BEGIN
		DELETE dbo.PhongBan WHERE MaPB = @Ma
END

GO
CREATE PROC PB_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.PhongBan
END

GO
CREATE PROC PB_SelectByID (@Ma varchar(10))
AS
BEGIN
		SELECT * FROM dbo.PhongBan WHERE MaPB = @Ma
END
GO

---- Thanh----Luong
CREATE PROC SP_ThemLuong (@BacLuong INT, @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	INSERT dbo.Luong( BacLuong ,LuongCoBan ,HeSoLuong ,HeSoPhuCap)
	VALUES  (@BacLuong, @LuongCoBan, @HeSoLuong, @HeSoPhuCap)
END 
EXEC SP_ThemLuong '1','6000000','1','1'

GO
CREATE PROC SP_SuaLuong (@BacLuong INT, @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	UPDATE dbo.Luong SET LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong, HeSoPhuCap = @HeSoPhuCap
	WHERE BacLuong = @BacLuong
END
EXEC SP_SuaLuong '1','6500000','1','1'

GO
CREATE PROC SP_XoaLuong(@BacLuong INT)
AS
BEGIN
	DELETE dbo.Luong WHERE BacLuong = @BacLuong
END 

GO
CREATE PROC SP_Luong_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.Luong
END

GO
CREATE PROC SP_Luong_SelectByID (@BacLuong INT )
AS
BEGIN
		SELECT * FROM dbo.Luong WHERE BacLuong = @BacLuong
END
GO
--Dương - thu tuc dang nhap
CREATE PROC DangNhap(@TaiKhoan NCHAR(50),@MatKhau NCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END