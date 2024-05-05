﻿IF EXISTS(SELECT 1 FROM sys.databases WHERE name ='QLTHUVIEN')
	DROP DATABASE QLTHUVIEN
GO

Create database QLTHUVIEN
GO

use QLTHUVIEN
GO
USE QLTHUVIEN
CREATE TABLE DOCGIA(
	MADG NVARCHAR(25) PRIMARY KEY,
	HOTEN NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(5),
	SDT NVARCHAR(10),
	DIACHI NVARCHAR(30),
	GMAIL NVARCHAR(100)
)
CREATE TABLE QUANTHU(
	MAQT NVARCHAR(25) PRIMARY KEY,
	HOTEN NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(5),
	SDT NVARCHAR(10),
	DIACHI NVARCHAR(30),
	GMAIL NVARCHAR(100),
	USERNAME NVARCHAR(30),
	PASS NVARCHAR(30),
)
CREATE TABLE ADMINN(
	MAAD NVARCHAR(25) PRIMARY KEY,
	USERNAME NVARCHAR(30),
	PASS NVARCHAR(30),
	MAQT NVARCHAR(25) NULL
)
CREATE TABLE SACH(
	MASACH NVARCHAR(25) PRIMARY KEY,
	TENSACH NVARCHAR(50),
	TACGIA NVARCHAR(50),
	NHAXB NVARCHAR(50),
	NXB NVARCHAR(10),
	THELOAI NVARCHAR(20),
	NGONNGU NVARCHAR(20),
	SLTON INT,
)
CREATE TABLE PHIEUMUON(
    MAPHIEUMUON NVARCHAR(25) PRIMARY KEY,
    NGAYLAPPHIEU DATE,
    MADG NVARCHAR(25),
    MAQT NVARCHAR(25),
    FOREIGN KEY (MADG) REFERENCES DOCGIA(MADG),
    FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)
)

CREATE TABLE CHITIETPHIEUMUON(
    MACTPM NVARCHAR(25) PRIMARY KEY,
    MAPHIEUMUON NVARCHAR(25),
    MASACH NVARCHAR(25),
    FOREIGN KEY (MAPHIEUMUON) REFERENCES PHIEUMUON(MAPHIEUMUON),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
)

CREATE TABLE PHIEUTRA(
    MAPHIEUTRA NVARCHAR(25) PRIMARY KEY,
    NGAYLAPPHIEUTRA DATE,
    MADG NVARCHAR(25),
    MAQT NVARCHAR(25),
    FOREIGN KEY (MADG) REFERENCES DOCGIA(MADG),
    FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)
)

CREATE TABLE CHITIETPHIEUTRA(
    MACTPT NVARCHAR(25) PRIMARY KEY,
    MAPHIEUTRA NVARCHAR(25),
	MAPHIEUMUON NVARCHAR(25),
    MASACH NVARCHAR(25),
    FOREIGN KEY (MAPHIEUTRA) REFERENCES PHIEUTRA(MAPHIEUTRA),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
	FOREIGN KEY (MAPHIEUMUON) REFERENCES PHIEUMUON(MAPHIEUMUON)
)
CREATE TABLE PHIEUNHACNHO(
	MADG NVARCHAR(25),
	SoLanViPham int DEFAULT 0
)




INSERT INTO DOCGIA(MADG, HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, GMAIL)
VALUES
('DG001', N'Trần Thị A', '1985-04-12', N'Nữ', '0987123456', N'24 Nguyễn Trãi', 'trantha@gmail.com'),
('DG002', N'Nguyễn Văn B', '1990-08-25', N'Nam', '0912345678', N'123 Lê Lợi', 'nguyenvanb@gmail.com'),
('DG003', N'Lê Văn C', '1973-11-01', N'Nam', '0923456789', N'56 Bà Triệu', 'levanc@gmail.com'),
('DG004', N'Phạm Thị D', '1982-03-15', N'Nữ', '0934567890', N'78 Lý Tự Trọng', 'phamthid@gmail.com'),
('DG005', N'Hồ Ngọc E', '1978-05-22', N'Nữ', '0945678901', N'60 Hai Bà Trưng', 'hongoce@gmail.com'),
('DG006', N'Võ Thị F', '1995-07-30', N'Nữ', '0956789012', N'234 Đồng Khởi', 'vothif@gmail.com'),
('DG007', N'Bùi Gia G', '1988-09-17', N'Nam', '0967890123', N'90 Thành Thái', 'buigiag@gmail.com'),
('DG008', N'Dương Văn H', '2000-01-05', N'Nam', '0978901234', N'12 Trần Hưng Đạo', 'duongvanh@gmail.com'),
('DG009', N'Trịnh Hồng I', '1981-12-12', N'Nữ', '0989012345', N'150 Nguyễn Văn Cừ', 'trinhhongi@gmail.com'),
('DG010', N'Nguyễn Khánh J', '1998-10-19', N'Nam', '0990123456', N'22 Lê Duẩn', 'nguyenkhanhj@gmail.com');
INSERT INTO SACH(MASACH, TENSACH, TACGIA, NHAXB, NXB, THELOAI, NGONNGU, SLTON)
VALUES
('S001', N'Tiểu thuyết Bất đắc dĩ', N'Anh Khoa', N'NXB Kim Đồng', N'2023', N'Tiểu thuyết', N'Tiếng Việt', 20 ),
('S002', N'Dấu chân trên bãi cát', N'Nguyễn Nhật Ánh', N'NXB Trẻ', N'2022', N'Tiểu thuyết', N'Tiếng Việt', 15),
('S003', N'Nhà giả kim', N'Paulo Coelho', N'NXB Văn học', N'2020', N'Tiểu thuyết', N'Tiếng Anh', 25),
('S004', N'The Alchemist', N'Paulo Coelho', N'HarperOne', N'1988', N'Fiction', N'English', 30),
('S005', N'The Great Gatsby', N'F. Scott Fitzgerald', N'Scribner', N'1925', N'Fiction', N'English', 40),
('S006', N'1984', N'George Orwell', N'Signet Classics', N'1949', N'Fiction', N'English', 35),
('S007', N'The Hobbit', N'J.R.R. Tolkien', N'Allen & Unwin', N'1937', N'Fantasy', N'English', 55),
('S008', N'The Lord of the Rings', N'J.R.R. Tolkien', N'Allen & Unwin', N'1954', N'Fantasy', N'English', 60),
('S009', N'Đắc nhân tâm', N'Dale Carnegie', N'NXB Trẻ', N'1936', N'Non-fiction', N'Tiếng Việt', 50),
('S010', N'Think and Grow Rich', N'Napoleon Hill', N'Ballantine Books', N'1937', N'Self-help', N'English', 20),
('S011', N'Rich Dad Poor Dad', N'Robert Kiyosaki', N'Warner Books', N'1997', N'Finance', N'English', 30),
('S012', N'The Lean Startup', N'Eric Ries', N'Crown Business', N'2011', N'Business', N'English', 40);

INSERT INTO ADMINN(MAAD, USERNAME, PASS, MAQT)
VALUES
('AD001', 'admin1', 'adminpass1', NULL),
('AD002', 'admin2', 'adminpass2', NULL);


INSERT INTO QUANTHU(MAQT, HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, GMAIL, USERNAME, PASS)
VALUES
('QT001', N'Nguyễn Thị A', '1985-04-12', N'Nữ', '0987123456', N'24 Nguyễn Trãi', 'nguyenthia@gmail.com', 'userA', 'passA'),
('QT002', N'Phạm Văn B', '1990-08-25', N'Nam', '0912345678', N'123 Lê Lợi', 'phamvanb@gmail.com', 'userB', 'passB'),
('QT003', N'Lê Thị C', '1973-11-01', N'Nam', '0923456789', N'56 Bà Triệu', 'lethic@gmail.com', 'userC', 'passC'),
('QT004', N'Hoàng Minh D', '1982-03-15', N'Nữ', '0934567890', N'78 Lý Tự Trọng', 'hoangminhd@gmail.com', 'userD', 'passD'),
('QT005', N'Trần Ngọc E', '1978-05-22', N'Nữ', '0945678901', N'60 Hai Bà Trưng', 'trannogce@gmail.com', 'userE', 'passE');

CREATE TABLE USERR(
	USERNAME NVARCHAR(50) PRIMARY KEY,
	PASSWORD NVARCHAR(50),
	UserType VARCHAR(20)
)
INSERT INTO USERR(USERNAME,PASSWORD,UserType)
SELECT USERNAME,PASS,'ADMIN' AS UserType
FROM ADMINN
INSERT INTO USERR(USERNAME,PASSWORD,UserType)
SELECT USERNAME,PASS,'QUANTHU' AS UserType
FROM QUANTHU

-- Thêm dữ liệu vào bảng PHIEUMUON
INSERT INTO PHIEUMUON(MAPHIEUMUON, NGAYLAPPHIEU, MADG, MAQT)
VALUES
('PM001', '2024-04-01', 'DG001', 'QT001'),
('PM002', '2024-04-02', 'DG002', 'QT002'),
('PM003', '2024-04-03', 'DG003', 'QT003'),
('PM004', '2024-04-04', 'DG004', 'QT004'),
('PM005', '2024-04-05', 'DG005', 'QT005');

-- Thêm dữ liệu vào bảng CHITIETPHIEUMUON
INSERT INTO CHITIETPHIEUMUON(MACTPM, MAPHIEUMUON, MASACH)
VALUES
('CTPM001', 'PM001', 'S001'),
('CTPM002', 'PM002', 'S002'),
('CTPM003', 'PM003', 'S003'),
('CTPM004', 'PM004', 'S004'),
('CTPM005', 'PM005', 'S005');

-- Thêm dữ liệu vào bảng PHIEUTRA
INSERT INTO PHIEUTRA(MAPHIEUTRA, NGAYLAPPHIEUTRA, MADG, MAQT)
VALUES
('PT001', '2024-04-15', 'DG001', 'QT001'),
('PT002', '2024-04-16', 'DG002', 'QT002'),
('PT003', '2024-04-17', 'DG003', 'QT003'),
('PT004', '2024-04-18', 'DG004', 'QT004'),
('PT005', '2024-04-19', 'DG005', 'QT005');

-- Thêm dữ liệu vào bảng CHITIETPHIEUTRA
-- Thêm dữ liệu vào bảng CHITIETPHIEUTRA
INSERT INTO CHITIETPHIEUTRA(MACTPT, MAPHIEUTRA, MASACH, MAPHIEUMUON)
VALUES
('CTPT001', 'PT001', 'S001', 'PM001'),
('CTPT002', 'PT002', 'S002', 'PM002'),
('CTPT003', 'PT003', 'S003', 'PM003'),
('CTPT004', 'PT004', 'S004', 'PM004'),
('CTPT005', 'PT005', 'S005', 'PM005');
go
CREATE PROCEDURE UpdateViolationCount
AS
BEGIN
    UPDATE PHIEUNHACNHO
    SET SoLanViPham = SoLanViPham + 1
    WHERE MADG IN (
        SELECT PM.MADG
        FROM PHIEUMUON PM
        INNER JOIN CHITIETPHIEUMUON CTPM ON PM.MAPHIEUMUON = CTPM.MAPHIEUMUON
        GROUP BY PM.MADG, PM.MAPHIEUMUON
        HAVING COUNT(DISTINCT CTPM.MASACH) <> (
            SELECT COUNT(*)
            FROM CHITIETPHIEUTRA CTPT
            WHERE CTPT.MAPHIEUTRA = PM.MAPHIEUMUON
        )
    );
END
go

CREATE PROCEDURE CheckAndIncrementViolation
AS
BEGIN
    UPDATE PHIEUNHACNHO
    SET SoLanViPham = SoLanViPham + 1
    WHERE MADG IN (
        SELECT MADG
        FROM (
            SELECT PM.MADG
            FROM PHIEUMUON PM
            INNER JOIN PHIEUTRA PT ON PM.MADG = PT.MADG
            WHERE DATEDIFF(day, PM.NGAYLAPPHIEU, PT.NGAYLAPPHIEUTRA) > 14
        ) AS LateReturns
    );
END;
go
CREATE PROCEDURE [dbo].[usp_XoaPhieuMuon] 
    @MaPhieuMuon CHAR(10)
AS
BEGIN
    DELETE FROM CHITIETPHIEUTRA
    WHERE MAPHIEUMUON = @MaPhieuMuon;

    DELETE FROM PHIEUTRA
    WHERE MAPHIEUTRA IN (SELECT MAPHIEUTRA FROM PHIEUTRA WHERE MADG = @MaPhieuMuon);

    DELETE FROM CHITIETPHIEUMUON
    WHERE MAPHIEUMUON = @MaPhieuMuon;

    DELETE FROM PHIEUMUON
    WHERE MAPHIEUMUON = @MaPhieuMuon;
END
go
CREATE PROCEDURE [dbo].[usp_SoSachDangMuon] 
    @MaDocGia CHAR(10), 
    @SoSachDangMuon INT OUT
AS
BEGIN
    DECLARE @SoSachMuon INT;

    SELECT @SoSachMuon = COUNT(DISTINCT ctpm.MASACH)
    FROM CHITIETPHIEUMUON ctpm
    INNER JOIN PHIEUMUON pm ON ctpm.MAPHIEUMUON = pm.MAPHIEUMUON
    WHERE pm.MADG = @MaDocGia;

    DECLARE @SoSachTra INT;

    SELECT @SoSachTra = COUNT(DISTINCT ctpt.MASACH)
    FROM CHITIETPHIEUTRA ctpt
    INNER JOIN PHIEUTRA pt ON ctpt.MAPHIEUTRA = pt.MAPHIEUTRA
    INNER JOIN PHIEUMUON pm ON ctpt.MAPHIEUMUON = pm.MAPHIEUMUON
    WHERE pm.MADG = @MaDocGia;

    SET @SoSachDangMuon = @SoSachMuon - @SoSachTra;
END
select * from PHIEUTRA