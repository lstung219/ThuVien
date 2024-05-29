IF EXISTS(SELECT 1 FROM sys.databases WHERE name ='QLTHUVIEN')
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
	anh image
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
    MACTPM NVARCHAR(25) not null,
    MAPHIEUMUON NVARCHAR(25) not null,
    MASACH NVARCHAR(25) not null,
	PRIMARY KEY (MACTPM,MAPHIEUMUON,MASACH),
    FOREIGN KEY (MAPHIEUMUON) REFERENCES PHIEUMUON(MAPHIEUMUON),
    FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
)

CREATE TABLE PHIEUTRA(
    MAPHIEUTRA NVARCHAR(25) PRIMARY KEY,
    NGAYLAPPHIEUTRA DATE,
    MAQT NVARCHAR(25) not null,
    FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)
)

CREATE TABLE CHITIETPHIEUTRA(
    MACTPT NVARCHAR(25) not null,
    MAPHIEUTRA NVARCHAR(25)not null,
	MAPHIEUMUON NVARCHAR(25) not null,
    MASACH NVARCHAR(25) not null,
	PRIMARY KEY (MACTPT,MAPHIEUMUON,MASACH,MAPHIEUTRA),
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
go
CREATE TABLE USERR(
	USERNAME NVARCHAR(50) PRIMARY KEY,
	PASSWORD NVARCHAR(50),
	GMAIL NVARCHAR(100),
	UserType VARCHAR(20)
)
go
INSERT INTO USERR(USERNAME,PASSWORD,UserType)
SELECT USERNAME,PASS,'ADMIN' AS UserType
FROM ADMINN
INSERT INTO USERR(USERNAME,PASSWORD,GMAIL,UserType)
SELECT USERNAME,PASS,GMAIL,'QUANTHU' AS UserType
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
('CTPM005', 'PM005', 'S005')


INSERT INTO PHIEUTRA(MAPHIEUTRA, NGAYLAPPHIEUTRA, MAQT)
VALUES
('PT001', '2024-04-15', 'QT001'),
('PT002', '2024-04-16', 'QT002'),
('PT003', '2024-04-17', 'QT003'),
('PT004', '2024-04-18', 'QT004'),
('PT005', '2024-04-19', 'QT005');


INSERT INTO CHITIETPHIEUTRA(MACTPT, MAPHIEUTRA, MASACH, MAPHIEUMUON)
VALUES
('CTPT001', 'PT001', 'S001', 'PM001'),
('CTPT002', 'PT002', 'S002', 'PM002'),
('CTPT003', 'PT003', 'S003', 'PM003'),
('CTPT004', 'PT004', 'S004', 'PM004'),
('CTPT005', 'PT005', 'S005', 'PM005');

INSERT INTO PHIEUNHACNHO (MaDG, SoLanViPham)
VALUES 
('DG001', 1),
('DG002', 2),
('DG003', 3),
('DG004', 0),
('DG005', 4);

go
CREATE PROCEDURE [dbo].[usp_XoaPhieuMuon] 
    @MaPhieuMuon CHAR(10)
AS
BEGIN
    DELETE FROM CHITIETPHIEUTRA
    WHERE MAPHIEUMUON = @MaPhieuMuon;

    DELETE FROM PHIEUTRA
    WHERE MAPHIEUTRA IN (SELECT MAPHIEUMUON FROM CHITIETPHIEUTRA WHERE MAPHIEUMUON = @MaPhieuMuon);

    DELETE FROM CHITIETPHIEUMUON
    WHERE MAPHIEUMUON = @MaPhieuMuon;

    DELETE FROM PHIEUMUON
    WHERE MAPHIEUMUON = @MaPhieuMuon;
END;
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
go
select * from PHIEUTRA
SELECT TOP 10 S.MASACH, S.TENSACH, COUNT(*) AS SoLuotMuon
FROM Sach S
INNER JOIN CHITIETPHIEUMUON CT ON S.MASACH = CT.MASACH
INNER JOIN PHIEUMUON PM ON CT.MAPHIEUMUON = PM.MAPHIEUMUON
GROUP BY S.MASACH, S.TENSACH
ORDER BY SoLuotMuon DESC


SELECT c.MASACH,d.HOTEN,d.NGAYSINH,d.GIOITINH,d.SDT,d.DIACHI,S.TENSACH
FROM CHITIETPHIEUMUON c
JOIN PHIEUMUON pm ON c.MAPHIEUMUON = pm.MAPHIEUMUON
JOIN SACH S ON S.MASACH=C.MASACH
JOIN DOCGIA d ON pm.MADG = d.MADG
SELECT c.MASACH, d.HOTEN, d.SDT, d.DIACHI, S.TENSACH
FROM CHITIETPHIEUMUON c
JOIN PHIEUMUON pm ON c.MAPHIEUMUON = pm.MAPHIEUMUON
JOIN SACH S ON S.MASACH = c.MASACH
JOIN DOCGIA d ON pm.MADG = d.MADG
go
CREATE PROCEDURE usp_TimMaDGTiepTheo
    @MaDocGia NVARCHAR(10) OUT
AS
BEGIN
    DECLARE @MaDG NVARCHAR(10) = 'DG001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MADG FROM DOCGIA WHERE MADG = @MaDG)
    BEGIN
        SET @idx = @idx + 1
        SET @MaDG = 'DG' + REPLICATE('0', 3 - LEN(CAST(@idx AS VARCHAR))) + CAST(@idx AS VARCHAR)
    END

    SET @MaDocGia = @MaDG
END
go
CREATE PROCEDURE usp_TimMaPhieuMuonTiepTheo
    @MaPhieuMuon NVARCHAR(10) OUT
AS
BEGIN
    DECLARE @MaPM NVARCHAR(10) = 'PM001'
    DECLARE @idx INT = 1
    WHILE EXISTS (SELECT MAPHIEUMUON FROM PHIEUMUON WHERE MAPHIEUMUON = @MaPM)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPM = 'PM' + REPLICATE('0', 3 - LEN(CAST(@idx AS VARCHAR))) + CAST(@idx AS VARCHAR)
    END

    SET @MaPhieuMuon = @MaPM
END
go
CREATE PROCEDURE usp_TimMaChiTietPhieuMuonTiepTheo
    @MaCTPM NVARCHAR(10) OUT
AS
BEGIN
    DECLARE @MaPM NVARCHAR(10) = 'CTPM001'
    DECLARE @idx INT = 1
    WHILE EXISTS (SELECT MACTPM FROM CHITIETPHIEUMUON WHERE MACTPM = @MaPM)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPM = 'CTPM' + REPLICATE('0', 4 - LEN(CAST(@idx AS VARCHAR))) + CAST(@idx AS VARCHAR)
    END

    SET @MaCTPM = @MaPM
END

go
CREATE PROCEDURE usp_ThemPhieuMuon
    @MaQT NVARCHAR(10),
    @MaDocGia NVARCHAR(10),
    @result INT OUT
AS
BEGIN
    SET @result = 0;
    DECLARE @SoLanViPham INT = 0;

    IF EXISTS (SELECT * FROM PHIEUNHACNHO WHERE MADG = @MaDocGia)
    BEGIN
        SELECT @SoLanViPham = SoLanViPham FROM PHIEUNHACNHO WHERE MADG = @MaDocGia;
    END

    IF (@SoLanViPham < 5)
    BEGIN
        DECLARE @Mapm NVARCHAR(10);
        EXEC usp_TimMaPhieuMuonTiepTheo @Mapm OUT;

        INSERT INTO PHIEUMUON (MAPHIEUMUON, MAQT, MADG, NGAYLAPPHIEU)
        VALUES (@Mapm, @MaQT, @MaDocGia, GETDATE());

        SET @result = 1;
    END
END
go
CREATE PROCEDURE [dbo].[usp_ThemChiTietPhieuMuon] 
    @MaCTPM CHAR(10), 
    @MaSach CHAR(10), 
    @MaPhieuMuon CHAR(10)
AS
BEGIN
    INSERT INTO CHITIETPHIEUMUON(MaCTPM, MaSach, MaPhieuMuon)
    VALUES (@MaCTPM, @MaSach, @MaPhieuMuon);

    UPDATE SACH
    SET SLTON -= 1
    WHERE MASACH = @MaSach;
END
go

CREATE PROCEDURE usp_LayDanhSachTaiLieu
AS
BEGIN
    SELECT MASACH, TENSACH
    FROM SACH
    WHERE SLTON > 0;
END
go

CREATE PROCEDURE [dbo].[usp_LayMaTLCuaPM] 
    @MaPhieuMuon NVARCHAR(10)
AS
BEGIN
    SELECT s.MASACH, s.TENSACH 
    FROM PHIEUMUON pm
    INNER JOIN CHITIETPHIEUMUON ctpm ON ctpm.MAPHIEUMUON = pm.MAPHIEUMUON
    INNER JOIN SACH s ON s.MASACH = ctpm.MASACH
    WHERE pm.MAPHIEUMUON = @MaPhieuMuon;
END
go
CREATE PROCEDURE [dbo].[usp_LoadMaPhieuMuon]
AS
BEGIN
    SELECT pm.MAPHIEUMUON
    FROM PHIEUMUON pm
    WHERE NOT EXISTS (
        SELECT 1 
        FROM CHITIETPHIEUTRA ctpt
        WHERE ctpt.MAPHIEUMUON = pm.MAPHIEUMUON
    )
END
GO
CREATE PROCEDURE usp_LayMaPhieuMuonTheoMaDG
    @MaDocGia CHAR(10)
AS
BEGIN
    SELECT pm.MAPHIEUMUON
    FROM PHIEUMUON pm
    WHERE pm.MADG = @MaDocGia
    AND NOT EXISTS (
        SELECT 1
        FROM CHITIETPHIEUTRA ctpt
        WHERE ctpt.MAPHIEUMUON = pm.MAPHIEUMUON
    )
END
go

CREATE PROCEDURE usp_TimMaPhieuTraTiepTheo
    @MaPhieuTra NVARCHAR(10) OUT
AS
BEGIN
    DECLARE @MaPT NVARCHAR(10) = 'PT001'
    DECLARE @idx INT = 1
    WHILE EXISTS (SELECT MAPHIEUTRA FROM PHIEUTRA WHERE MAPHIEUTRA = @MaPT)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPT = 'PT' + REPLICATE('0', 3 - LEN(CAST(@idx AS VARCHAR))) + CAST(@idx AS VARCHAR)
    END

    SET @MaPhieuTra = @MaPT
END
go
CREATE PROCEDURE usp_TimMaChiTietPhieuTraTiepTheo
    @MaCTPT NVARCHAR(10) OUT
AS
BEGIN
    DECLARE @MaPM NVARCHAR(10) = 'CTPT001'
    DECLARE @idx INT = 1
    WHILE EXISTS (SELECT MACTPT FROM CHITIETPHIEUTRA WHERE MACTPT = @MaPM)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPM = 'CTPT' + REPLICATE('0', 4 - LEN(CAST(@idx AS VARCHAR))) + CAST(@idx AS VARCHAR)
    END

    SET @MaCTPT = @MaPM
END
go
CREATE PROCEDURE [dbo].[usp_LaySoSachCuaPM]
    @MaPhieuMuon CHAR(10),
    @SoSach INT OUT
AS
BEGIN
    SELECT @SoSach = COUNT(ctpm.MaSach)
    FROM PHIEUMUON pm
    INNER JOIN CHITIETPHIEUMUON ctpm ON ctpm.MaPhieuMuon = pm.MaPhieuMuon
    WHERE pm.MaPhieuMuon = @MaPhieuMuon;
END
go
CREATE PROCEDURE [dbo].[usp_LaySoNgayQuaHan]
    @MaPhieuMuon CHAR(10),
    @NQH INT OUT
AS
BEGIN
    SELECT @NQH = DATEDIFF(DAY, NGAYLAPPHIEU, GETDATE())
    FROM PHIEUMUON
    WHERE MaPhieuMuon = @MaPhieuMuon;
END
go
CREATE PROCEDURE [dbo].[usp_TangSoLanViPham]
    @MaDocGia NCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM PHIEUNHACNHO WHERE MADG = @MaDocGia)
    BEGIN
        UPDATE PHIEUNHACNHO
        SET SoLanViPham = SoLanViPham + 1
        WHERE MADG = @MaDocGia;
    END
    ELSE
    BEGIN
        INSERT INTO PHIEUNHACNHO (MADG, SoLanViPham)
        VALUES (@MaDocGia, 1);
    END
END
go
CREATE PROCEDURE [dbo].[usp_GiamSoLanViPham]
    @MaDocGia NCHAR(10)
AS
BEGIN
        UPDATE PHIEUNHACNHO
        SET SoLanViPham = SoLanViPham - 1
        WHERE MADG = @MaDocGia;
END

go
CREATE PROCEDURE [dbo].[usp_LayMaDocGiaDePhat]
    @MaPhieuMuon NCHAR(10),
    @MaDocGia NCHAR(10) OUT
AS
BEGIN
    SELECT @MaDocGia = MADG
    FROM PHIEUMUON
    WHERE MaPhieuMuon = @MaPhieuMuon;
END
go
CREATE PROCEDURE [dbo].[usp_ThemPhieuTra]
    @MaPhieuTra NCHAR(10),
    @MaNVLapPhieuTra NCHAR(10)
AS
BEGIN
    INSERT INTO PHIEUTRA (MaPhieuTra, MAQT, NGAYLAPPHIEUTRA)
    VALUES (@MaPhieuTra, @MaNVLapPhieuTra, GETDATE());
END
go
CREATE PROCEDURE [dbo].[usp_ThemChiTietPhieuTra]
    @MaCTPT NCHAR(10),
    @MaPhieuTra NCHAR(10),
    @MaPhieuMuon NCHAR(10),
    @MaSach NCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT * FROM PHIEUTRA pt, SACH s WHERE pt.MaPhieuTra = @MaPhieuTra AND s.MaSach = @MaSach)
    BEGIN
        INSERT INTO CHITIETPHIEUTRA (MaCTPT, MaPhieuTra, MaPhieuMuon, MaSach)
        VALUES (@MaCTPT, @MaPhieuTra, @MaPhieuMuon, @MaSach);

        UPDATE SACH
        SET SLTON += 1
        WHERE MaSach = @MaSach;
    END
END
go
CREATE PROCEDURE usp_XoaPhieuNhacNho
    @MaDocGia NCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM PHIEUNHACNHO WHERE MADG = @MaDocGia)
    BEGIN

        DELETE FROM PHIEUNHACNHO WHERE MADG = @MaDocGia;
        RETURN 1; 
    END
    ELSE
    BEGIN
        RETURN 0; 
    END
END



