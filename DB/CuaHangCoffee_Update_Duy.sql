Create database CuaHangCoffe
Use CuaHangCoffe
Go
CREATE TABLE NhanVien
(
	MaNV CHAR(3) PRIMARY KEY,
	HoTen NVARCHAR(30),
	GioiTinh NVARCHAR(5),
)
CREATE TABLE KhachHang
(
	MaKH CHAR(3) PRIMARY KEY,
	HoTen NVARCHAR(30),
	GioiTinh NVARCHAR(5),
)
CREATE TABLE KhuyenMai (
    MaKM VARCHAR(20) PRIMARY KEY, 
    TenKM NVARCHAR(100),          
    GiaTriToiThieu DECIMAL(18,0), 
    PhanTramGiam FLOAT
)
CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(100) ,
    GiaBan DECIMAL(18,0)  
)
CREATE TABLE HoaDon (
    MaHD VARCHAR(20) PRIMARY KEY,
    NgayLap DATETIME DEFAULT CURRENT_TIMESTAMP,
    TongTien DECIMAL(18,0) DEFAULT 0,
    MaNV CHAR(3),
    MaKH CHAR(3),
    MaKM VARCHAR(20) NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM)
)
CREATE TABLE ChiTietHoaDon (
    MaHD VARCHAR(20),
    MaSP VARCHAR(20),
    SoLuong INT  CHECK (SoLuong > 0),
    GiaBanThucTe DECIMAL(18,0),
    PRIMARY KEY (MaHD, MaSP),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)
INSERT INTO NhanVien (MaNV, HoTen, GioiTinh) VALUES 
('NV1', N'Nguyễn Văn A', N'Nam'),
('NV2', N'Trần Thị B', N'Nữ'),
('NV3', N'Lê Minh C', N'Nam');

INSERT INTO KhachHang (MaKH, HoTen, GioiTinh) VALUES 
('KH1', N'Phạm Quang D', N'Nam'),
('KH2', N'Ngô Thị E', N'Nữ'),
('KH3', N'Vũ Ngọc F', N'Nữ');

INSERT INTO KhuyenMai (MaKM, TenKM, GiaTriToiThieu, PhanTramGiam) VALUES 
('KM01', N'Giảm 5% đơn từ 200k', 200000, 0.05),
('KM02', N'Giảm 10% đơn từ 500k', 500000, 0.10),
('KM03', N'Giảm 15% đơn từ 1 triệu', 1000000, 0.15);

INSERT INTO SanPham (MaSP, TenSP, GiaBan) VALUES 
('SP01', N'Cà phê đen đá', 20000),
('SP02', N'Cà phê sữa đá', 25000),
('SP03', N'Bạc xỉu', 30000),
('SP04', N'Trà đào cam sả', 40000),
('SP05', N'Sinh tố bơ', 45000);

INSERT INTO HoaDon (MaHD, NgayLap, TongTien, MaNV, MaKH, MaKM) VALUES 
('HD01', '2026-04-14 08:30:00', 237500, 'NV1', 'KH1', 'KM01'),
('HD02', '2026-04-14 09:15:00', 65000, 'NV2', 'KH2', NULL);

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, GiaBanThucTe) VALUES 
('HD01', 'SP04', 4, 40000),
('HD01', 'SP05', 2, 45000),

('HD02', 'SP02', 1, 25000),
('HD02', 'SP04', 1, 40000);
