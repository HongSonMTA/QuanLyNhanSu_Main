use QuanLyNhanSu
GO

--Sơn--Phòng Ban

--Thêm Phòng Ban
ALTER PROC Them_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	INSERT INTO dbo.PhongBan( MaPB, TenPB,MaTP, DiaChi, SDT )
	VALUES  (@MaPb,@TenPB,@MaTP,@DiaChi,@Sdt )
END

GO
--Sửa Phòng ban
ALTER PROC Sua_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	UPDATE dbo.PhongBan
	SET TenPB = @TenPB,MaTP = @MaTP,DiaChi = @DiaChi,SDT=@Sdt
	WHERE MaPB = @MaPb
END

GO 
--xóa Phòng Ban
ALTER PROC Xoa_PB (@Ma varchar(10))
AS
BEGIN
		DELETE dbo.PhongBan WHERE MaPB = @Ma
END

GO
--Hiển Thị dữ liệu
ALTER PROC PB_SelectAll 
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
ALTER PROC SP_ThemLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	INSERT dbo.Luong( BacLuong ,LuongCoBan ,HeSoLuong ,HeSoPhuCap)
	VALUES  (@BacLuong, @LuongCoBan, @HeSoLuong, @HeSoPhuCap)
END 
GO 
EXEC SP_ThemLuong '1','6000000','1','1'

GO
ALTER PROC SP_SuaLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	UPDATE dbo.Luong SET LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong, HeSoPhuCap = @HeSoPhuCap
	WHERE BacLuong = @BacLuong
END
GO 
EXEC SP_SuaLuong '1','6500000','1','1'

GO
ALTER PROC SP_XoaLuong(@BacLuong VARCHAR(10))
AS
BEGIN
	DELETE dbo.Luong WHERE BacLuong = @BacLuong
END 

GO
ALTER PROC SP_Luong_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.Luong
END

GO
ALTER PROC SP_Luong_SelectByID (@BacLuong VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.Luong WHERE BacLuong = @BacLuong
END
GO
--Dương - thu tuc dang nhap
ALTER PROC DangNhap(@TaiKhoan NCHAR(50),@MatKhau NCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO

CREATE PROC SP_TDHV_SelectAll
AS
BEGIN
SELECT * FROM dbo.TrinhDoHocVan
END
GO
CREATE PROC SP_TDHV_SelectByID (@MaTDHV INT )
AS
BEGIN
		SELECT * FROM dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END
GO

CREATE PROC SP_Them_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	INSERT dbo.TrinhDoHocVan
	VALUES  ( @MaTDHV, @TenTDHV,@ChuyenNganh)
END

GO
CREATE PROC SP_Sua_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.TrinhDoHocVan
	SET TenTrinhDo =@TenTDHV,ChuyenNganh=@ChuyenNganh
	WHERE MaTDHV=@MaTDHV
END

GO 
CREATE PROC SP_Xoa_TDHV (@MaTDHV varchar(10))
AS
BEGIN
		DELETE dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END

GO
-- Ánh- Thủ tục Nhân Viên
-- Hiện ra danh sách Nhân Viên
GO
ALTER PROC NV_SelectAll 
AS
BEGIN
	SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,MaTDHV,TenPB, TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong
END

go
EXEC dbo.NV_SelectAll

--
GO
ALTER PROC NV_SelectByID (@MaNV varchar(10))
AS
BEGIN
		SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV
END

GO
EXEC dbo.NV_SelectByID @MaNV = 'nv01' -- varchar(10)

-- Thêm Nhân Viên
GO
ALTER PROC ThemNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @TenPB NVARCHAR(50), @BacLuong VARCHAR(10))
AS
BEGIN
DECLARE @MaPB VARCHAR(10)
SELECT @MaPB=MaPB
FROM dbo.PhongBan
WHERE TenPB=@TenPB
INSERT INTO dbo.NhanVien( MaNV , HoTen ,DanToc ,GioiTinh ,SDT ,QueQuan ,NgaySinh ,MaTDHV ,MaPB ,BacLuong)
VALUES  ( @MaNV,@HoTen,@DanToc,@GioiTinh,@SDT,@QueQuan,@NgaySinh,@MaTDHV,@MaPB,@BacLuong)
END


-- Sửa Nhân Viên
GO
ALTER PROC SuaNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong VARCHAR(10))
AS
BEGIN
UPDATE dbo.NhanVien
SET HoTen=@HoTen,DanToc=@DanToc,GioiTinh=@GioiTinh,SDT=@SDT,QueQuan=@QueQuan,NgaySinh=@NgaySinh,MaTDHV=@MaTDHV,MaPB=@MaPB,BacLuong=@BacLuong
WHERE MaNV=@MaNV
END

-- Xóa Nhân Viên
GO
ALTER PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
DELETE dbo.NhanVien
WHERE MaNV=@MaNV
END


--Cường---
--Thủ tục thời gian công tác--
CREATE PROC SPTGCTSELECTAll1
AS
BEGIN
SELECT * FROM dbo.ThoiGianCongTac
END
GO
CREATE PROC SPTGCTSELECTBYID (@manv VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.ThoiGianCongTac WHERE MaNV = @manv
END
GO

CREATE PROC SPTHEMTGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	INSERT dbo.ThoiGianCongTac
	        ( MaNV, MaCV, NgayNhanChuc )
	VALUES  ( @manv,@macv,@ngaynhanchuc)
	
END

GO
CREATE PROC SPSUATGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	UPDATE dbo.ThoiGianCongTac
	SET MaCV=@macv,NgayNhanChuc=@ngaynhanchuc
	WHERE MaNV=@manv
END

GO 
CREATE PROC SPXOATGCT (@manv varchar(10))
AS
BEGIN
		DELETE dbo.ThoiGianCongTac WHERE MaNV=@manv
END

GO

--Thủ tục chức vụ--
CREATE PROC SPCVSELECTAll
AS
BEGIN
SELECT * FROM dbo.ChucVu
END
GO
CREATE PROC SPCVSELECTBYID (@machucvu VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.ChucVu WHERE MaChucVu = @machucvu
END
GO

CREATE PROC SPTHEMCV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	INSERT dbo.ChucVu
	        ( MaChucVu, TenChucVu )
	VALUES  ( @machucvu,@tenchucvu)
	
END

GO
CREATE PROC SPSUACV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.ChucVu
	SET TenChucVu=@tenchucvu
	WHERE MaChucVu=@machucvu
END

GO 
CREATE PROC SPXOACV (@machucvu varchar(10))
AS
BEGIN
		DELETE dbo.ChucVu WHERE MaChucVu=@machucvu
END

GO

SELECT * FROM dbo.TrinhDoHocVan