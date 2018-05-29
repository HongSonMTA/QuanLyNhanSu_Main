USE QuanLyNhanSu
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
