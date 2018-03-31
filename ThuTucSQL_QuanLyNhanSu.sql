use QuanLyNhanSu
GO

--Sơn--Phòng Ban

--Thêm Phòng Ban
CREATE PROC Them_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	INSERT INTO dbo.PhongBan( MaPB, TenPB,MaTP, DiaChi, SDT )
	VALUES  (@MaPb,@TenPB,@MaTP,@DiaChi,@Sdt )
END

GO
--Sửa Phòng ban
CREATE PROC Sua_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	UPDATE dbo.PhongBan
	SET TenPB = @TenPB,MaTP = @MaTP,DiaChi = @DiaChi,SDT=@Sdt
	WHERE MaPB = @MaPb
END

GO 
--xóa Phòng Ban
CREATE PROC Xoa_PB (@Ma varchar(10))
AS
BEGIN
		DELETE dbo.PhongBan WHERE MaPB = @Ma
END

GO
--Hiển Thị dữ liệu
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

-- Ánh- Thủ tục Nhân Viên
-- Hiện ra danh sách Nhân Viên
GO
CREATE PROC NV_SelectAll 
AS
BEGIN
	SELECT * FROM dbo.NhanVien
END

go
EXEC dbo.NV_SelectAll

--
GO
CREATE PROC NV_SelectByID (@MaNV varchar(10))
AS
BEGIN
		SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV
END

GO
EXEC dbo.NV_SelectByID @MaNV = 'nv01' -- varchar(10)

-- Thêm Nhân Viên
GO
CREATE PROC ThemNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh BIT, @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong INT)
AS
BEGIN
INSERT INTO dbo.NhanVien( MaNV , HoTen ,DanToc ,GioiTinh ,SDT ,QueQuan ,NgaySinh ,MaTDHV ,MaPB ,BacLuong)
VALUES  ( @MaNV,@HoTen,@DanToc,@GioiTinh,@SDT,@QueQuan,@NgaySinh,@MaTDHV,@MaPB,@BacLuong)
END

-- Sửa Nhân Viên
GO
CREATE PROC SuaNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh BIT, @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong INT)
AS
BEGIN
UPDATE dbo.NhanVien
SET MaNV=@MaNV,HoTen=@HoTen,DanToc=@DanToc,GioiTinh=@GioiTinh,SDT=@SDT,QueQuan=@QueQuan,NgaySinh=@NgaySinh,MaTDHV=@MaTDHV,MaPB=@MaPB,BacLuong=@BacLuong
END

-- Xóa Nhân Viên
GO
CREATE PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
DELETE dbo.NhanVien
WHERE MaNV=@MaNV
END