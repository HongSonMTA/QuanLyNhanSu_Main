USE QuanLyNhanSu
GO 
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL02',3800000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL03',3900000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL04',3850000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL05',3950000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL06',4000000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL07',4050000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL08',4100000,1,1)
INSERT dbo.Luong ( BacLuong , LuongCoBan ,HeSoLuong , HeSoPhuCap )
VALUES  ('BL09',4200000,1,1)


GO
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD01',N'Đại học',N'Công nghệ thông tin' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD02',N'Cao học',N'Cơ khí' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD03',N'Cao đẳng',N'Kế toán' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD04',N'Trung cấp',N'Công nghệ thông tin' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD05',N'Kỹ sư',N'Cầu đường' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD06',N'Thạc sỹ',N'Công nghệ thông tin' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD07',N'Tiến sỹ',N'Cơ khí' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD08',N'Giáo sư',N'Công nghệ thông tin' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD09',N'Phó giáo sư',N'Hóa phân tích' )
INSERT dbo.TrinhDoHocVan
VALUES  ( 'TD10',N'Phó tiến sỹ',N'Công nghệ thông tin' )

GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV01' , -- MaNV - varchar(10)
          N'Nguyễn Văn Quang' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0987654567' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1995-04-03' , -- NgaySinh - date
          'TD01' , -- MaTDHV - varchar(10)
          'PB02' , -- MaPB - varchar(10)
          'BL02'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV02' , -- MaNV - varchar(10)
          N'Nguyễn Văn Minh' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0987654987' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1994-04-03' , -- NgaySinh - date
          'TD01' , -- MaTDHV - varchar(10)
          'PB02' , -- MaPB - varchar(10)
          'BL02'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV03' , -- MaNV - varchar(10)
          N'Trần Thị Hòa' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '0988964987' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1993-10-03' , -- NgaySinh - date
          'TD03' , -- MaTDHV - varchar(10)
          'PB01' , -- MaPB - varchar(10)
          'BL03'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV04' , -- MaNV - varchar(10)
          N'Lê Thị Hải' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '0987656787' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1992-04-20' , -- NgaySinh - date
          'TD03' , -- MaTDHV - varchar(10)
          'PB04' , -- MaPB - varchar(10)
          'BL01'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV05' , -- MaNV - varchar(10)
          N'Nguyễn Thị Hồng' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '0988934787' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1994-10-20' , -- NgaySinh - date
          'TD03' , -- MaTDHV - varchar(10)
          'PB04' , -- MaPB - varchar(10)
          'BL01'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV06' , -- MaNV - varchar(10)
          N'Phí Thị Khánh Văn' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '0987689347' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1993-08-10' , -- NgaySinh - date
          'TD01' , -- MaTDHV - varchar(10)
          'PB03' , -- MaPB - varchar(10)
          'BL04'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV07' , -- MaNV - varchar(10)
          N'Đào Bá Hùng' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0989023787' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1992-06-20' , -- NgaySinh - date
          'TD03' , -- MaTDHV - varchar(10)
          'PB04' , -- MaPB - varchar(10)
          'BL01'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV08' , -- MaNV - varchar(10)
          N'Trần Văn Quyết' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0980233787' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1992-07-25' , -- NgaySinh - date
          'TD03' , -- MaTDHV - varchar(10)
          'PB01' , -- MaPB - varchar(10)
          'BL01'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV09' , -- MaNV - varchar(10)
          N'Nguyễn Hải Nam' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0989920387' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1993-02-29' , -- NgaySinh - date
          'TD02' , -- MaTDHV - varchar(10)
          'PB04' , -- MaPB - varchar(10)
          'BL04'  -- BacLuong - varchar(10)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          HoTen ,
          DanToc ,
          GioiTinh ,
          SDT ,
          QueQuan ,
          NgaySinh ,
          MaTDHV ,
          MaPB ,
          BacLuong
        )
VALUES  ( 'NV10' , -- MaNV - varchar(10)
          N'Nguyễn Khắc Huy' , -- HoTen - nvarchar(50)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '0990383787' , -- SDT - char(15)
          N'Hà Nội' , -- QueQuan - nvarchar(50)
          '1994-05-19' , -- NgaySinh - date
          'TD02' , -- MaTDHV - varchar(10)
          'PB01' , -- MaPB - varchar(10)
          'BL05'  -- BacLuong - varchar(10)
        )


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
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV07','CV01','04/20/2013')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV08','CV02','04/20/2013')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV09','CV03','04/20/2013')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV10','CV01','04/20/2013')



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

----Phòng Ban----
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB01', N'Hành Chính','NV01', N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB02', N'Kế Toán','NV02', N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB03', N'Bảo vệ ','NV03', N'Khu Nhà E','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB04', N'Hội Đồng','NV04', N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB05', N'Tiếp Tân','NV05', N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB06', N'Giám Đốc',NULL, N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB07', N'Phó Giám Đốc',NULL, N'Khu Nhà A','09811777888' )
INSERT INTO dbo.PhongBan
        ( MaPB, TenPB, MaTP, DiaChi, SDT )
VALUES  ( 'PB08', N'Y Tế','NV01', N'Khu Nhà B','09811777888' )