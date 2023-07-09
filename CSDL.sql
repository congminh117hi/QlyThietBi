CREATE TABLE TaiKhoan(
	Mataikhoan INT IDENTITY PRIMARY KEY NOT NULL,
	Tentaikhoan NVARCHAR(50) NOT NULL,
	Tendangnhap NVARCHAR(50) NOT NULL,
	Matkhau NVARCHAR(50) NOT NULL,
	Manhanvien INT NOT NULL
)
GO

CREATE TABLE NhanVien(
	Manhanvien INT IDENTITY PRIMARY KEY NOT NULL,
	Tennhanvien NVARCHAR(50) NOT NULL,
	Chucvu NVARCHAR(20) NOT NULL,
	Sdtnhanvien NVARCHAR(10) NOT NULL,
	Emailnhanvien NVARCHAR(50) NOT NULL,
	Madonvi INT NOT NULL
)
GO

ALTER TABLE dbo.NhanVien ADD FOREIGN KEY (Madonvi) REFERENCES dbo.DonVi(Madonvi)
GO 

ALTER TABLE dbo.TaiKhoan ADD FOREIGN KEY (Manhanvien) REFERENCES dbo.NhanVien(Manhanvien)
GO 

CREATE TABLE LoaiThietBi(
	Maloaithietbi INT IDENTITY PRIMARY KEY NOT NULL,
	Tenloaithietbi NVARCHAR(50)NOT NULL
)
GO

CREATE TABLE ThietBi(
	Mathietbi INT IDENTITY PRIMARY KEY NOT NULL,
	Tenthietbi NVARCHAR(50) NOT NULL,
	Donvitinh NVARCHAR(20)NOT NULL,
	Ghichu NVARCHAR(100),
	Maloaithietbi INT NOT NULL
)
GO

ALTER TABLE dbo.ThietBi ADD FOREIGN KEY (Maloaithietbi) REFERENCES dbo.LoaiThietBi(Maloaithietbi)
GO 

CREATE TABLE ThietBiSuDung(
	Mathietbisudung INT IDENTITY PRIMARY KEY NOT NULL,
	Tenthietbisudung NVARCHAR(50) NOT NULL,
	Mathietbi INT NOT NULL,
	Dongianhap FLOAT NOT NULL,
	Ngaynhap DATE NOT NULL,
	Tinhtrangthietbi NVARCHAR(50) NOT NULL,
	Ghichu NVARCHAR(100)
)
GO

ALTER TABLE dbo.ThietBiSuDung ADD FOREIGN KEY (Mathietbi) REFERENCES dbo.ThietBi(Mathietbi)
GO 

CREATE TABLE TheoDoiThietBi(
	Matheodoithietbi INT IDENTITY PRIMARY KEY NOT NULL,
	Mathietbisudung INT NOT NULL,
	Madonvi INT NOT NULL,
	Ngaybatdausudung DATE NOT NULL,
	Ngaytrathietbi DATE,
	Tinhtrangthietbi NVARCHAR(50) NOT NULL,
	Ghichu NVARCHAR(100)
)
GO


ALTER TABLE dbo.TheoDoiThietBi ADD FOREIGN KEY (Mathietbisudung) REFERENCES dbo.ThietBiSuDung(Mathietbisudung)
GO 

CREATE TABLE DonVi(
	Madonvi INT IDENTITY PRIMARY KEY NOT NULL,
	Tendonvi NVARCHAR(50)NOT NULL,
	Sdtdonvi NVARCHAR(10)NOT NULL,
	Emaildonvi NVARCHAR(50) NOT NULL
)
GO

ALTER TABLE dbo.TheoDoiThietBi ADD FOREIGN KEY (Madonvi) REFERENCES dbo.DonVi(Madonvi)
GO 

CREATE TABLE PhieuDeXuat(
	Maphieudexuat INT IDENTITY PRIMARY KEY NOT NULL,
	Manhanvien INT NOT NULL, 
	Madonvi INT NOT NULL,
	Ngaydexuat DATE NOT NULL,
	Ghichu NVARCHAR(100)
)
GO

ALTER TABLE dbo.PhieuDeXuat ADD FOREIGN KEY (Manhanvien) REFERENCES dbo.NhanVien(Manhanvien)
GO 

ALTER TABLE dbo.PhieuDeXuat ADD FOREIGN KEY (Madonvi) REFERENCES dbo.DonVi(Madonvi)
GO 

CREATE TABLE ChiTietPhieuDeXuat(
	Machitietphieudexuat INT IDENTITY PRIMARY KEY NOT NULL,
	Maphieudexuat INT NOT NULL,
	Mathietbi INT NOT NULL,
	Soluong INT NOT NULL
)
GO



ALTER TABLE dbo.ChiTietPhieuDeXuat ADD FOREIGN KEY (Maphieudexuat) REFERENCES dbo.PhieuDeXuat(Maphieudexuat)
GO 

ALTER TABLE dbo.ChiTietPhieuDeXuat ADD FOREIGN KEY (Mathietbi) REFERENCES dbo.ThietBi(Mathietbi)
GO 

CREATE TABLE PhieuNhapThietBi(
	Maphieunhap INT IDENTITY PRIMARY KEY NOT NULL,
	Ngaynhap DATE NOT NULL,
	Manhanvien INT NOT NULL,
	Madonvi INT NOT NULL,
	TongTien FLOAT NOT NULL,
	Ghichu NVARCHAR(100)
)
GO

ALTER TABLE dbo.PhieuNhapThietBi ADD FOREIGN KEY (Manhanvien) REFERENCES dbo.NhanVien(Manhanvien)
GO 

ALTER TABLE dbo.PhieuNhapThietBi ADD FOREIGN KEY (Madonvi) REFERENCES dbo.DonVi(Madonvi)
GO 

CREATE TABLE ChiTietPhieuNhap(
	Machitietphieunhap INT IDENTITY PRIMARY KEY NOT NULL,
	Maphieunhap INT NOT NULL,
	Mathietbisudung INT NOT NULL,
	Dongianhap FLOAT NOT NULL, 
	Soluongnhap INT NOT NULL,
	Thanhtiennhap FLOAT NOT NULL
)
GO

ALTER TABLE dbo.ChiTietPhieuNhap ADD FOREIGN KEY (Maphieunhap) REFERENCES dbo.PhieuNhapThietBi(Maphieunhap)
GO 

ALTER TABLE dbo.ChiTietPhieuNhap ADD FOREIGN KEY (Mathietbisudung) REFERENCES dbo.ThietBiSuDung(Mathietbisudung)
GO 


CREATE TABLE PhieuSuaChua(
	Maphieusuachua INT IDENTITY PRIMARY KEY NOT NULL,
	Manhanvien INT NOT NULL,
	Madonvi INT NOT NULL,
	Ngaysuachua DATE NOT NULL,
	Ghichu NVARCHAR(100) 
)
GO

ALTER TABLE dbo.PhieuSuaChua ADD FOREIGN KEY (Manhanvien) REFERENCES dbo.NhanVien(Manhanvien)
GO 

ALTER TABLE dbo.PhieuSuaChua ADD FOREIGN KEY (Madonvi) REFERENCES dbo.DonVi(Madonvi)
GO 

CREATE TABLE ChiTietPhieuSuaChua(
	Machitietphieusuachua INT IDENTITY PRIMARY KEY NOT NULL,
	Maphieusuachua INT NOT NULL,
	Mathietbisudung INT NOT NULL,
	Soluongsuachua INT NOT NULL
)
GO


SELECT * FROM dbo.PhieuSuaChua AS a, dbo.ChiTietPhieuSuaChua AS b WHERE a.Maphieusuachua = b.Maphieusuachua
SELECT a.Maphieusuachua, b.Machitietphieusuachua, a.Manhanvien, d.Tennhanvien, c.Madonvi, c.Tendonvi, a.Ngaysuachua, b.Mathietbisudung, e.Tenthietbisudung, b.Soluongsuachua FROM dbo.PhieuSuaChua AS a, dbo.ChiTietPhieuSuaChua AS b, dbo.DonVi AS c, dbo.NhanVien AS d, dbo.ThietBiSuDung AS e WHERE a.Maphieusuachua = b.Maphieusuachua AND a.Manhanvien = d.Manhanvien AND a.Madonvi = c.Madonvi AND b.Mathietbisudung = e.Mathietbisudung

ALTER TABLE dbo.ChiTietPhieuSuaChua ADD Mathietbisudung INT 

ALTER TABLE dbo.ChiTietPhieuSuaChua ADD FOREIGN KEY (Maphieusuachua) REFERENCES dbo.PhieuSuaChua(Maphieusuachua)
GO 

ALTER TABLE dbo.ChiTietPhieuSuaChua ADD FOREIGN KEY (Mathietbisudung) REFERENCES dbo.ThietBiSuDung(Mathietbisudung)
GO 

CREATE PROC USP_Login
@Tendangnhap NVARCHAR(50), @Matkhau NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE Tendangnhap = @Tendangnhap AND Matkhau = @Matkhau
END
GO
