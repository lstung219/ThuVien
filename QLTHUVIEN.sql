CREATE DATABASE QLTHUVIEN
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
	MADG NVARCHAR(25),
	MAAD NVARCHAR(25),
	MASACH NVARCHAR(25),
	MAPHIEU NVARCHAR(25)
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
	MAQT NVARCHAR(25) NULL
)
CREATE TABLE PHIEU(
	MAPHIEU NVARCHAR(25) PRIMARY KEY,
	NGAYMUON DATE,
	NGAYTRA DATE,
	LOAIPHIEU INT,
	MADG NVARCHAR(25),
	HOTEN NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(5),
	SDT NVARCHAR(10),
	DIACHI NVARCHAR(30),
	GMAIL NVARCHAR(100),
	MAQT NVARCHAR(25) NULL
)
ALTER TABLE QUANTHU ADD FOREIGN KEY (MAAD) REFERENCES ADMINN(MAAD)
ALTER TABLE QUANTHU ADD FOREIGN KEY (MADG) REFERENCES DOCGIA(MADG)
ALTER TABLE QUANTHU ADD FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
ALTER TABLE QUANTHU ADD FOREIGN KEY (MAPHIEU) REFERENCES PHIEU(MAPHIEU)
ALTER TABLE ADMINN ADD FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)
ALTER TABLE SACH ADD FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)
ALTER TABLE PHIEU ADD FOREIGN KEY (MADG) REFERENCES DOCGIA(MADG)
ALTER TABLE PHIEU ADD FOREIGN KEY (MAQT) REFERENCES QUANTHU(MAQT)


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
INSERT INTO SACH(MASACH, TENSACH, TACGIA, NHAXB, NXB, THELOAI, NGONNGU, SLTON, MAQT)
VALUES
('S001', N'Tiểu thuyết Bất đắc dĩ', N'Anh Khoa', N'NXB Kim Đồng', N'2023', N'Tiểu thuyết', N'Tiếng Việt', 20, NULL),
('S002', N'Dấu chân trên bãi cát', N'Nguyễn Nhật Ánh', N'NXB Trẻ', N'2022', N'Tiểu thuyết', N'Tiếng Việt', 15, NULL),
('S003', N'Nhà giả kim', N'Paulo Coelho', N'NXB Văn học', N'2020', N'Tiểu thuyết', N'Tiếng Anh', 25, NULL),
('S004', N'The Alchemist', N'Paulo Coelho', N'HarperOne', N'1988', N'Fiction', N'English', 30, NULL),
('S005', N'The Great Gatsby', N'F. Scott Fitzgerald', N'Scribner', N'1925', N'Fiction', N'English', 40, NULL),
('S006', N'1984', N'George Orwell', N'Signet Classics', N'1949', N'Fiction', N'English', 35, NULL),
('S007', N'The Hobbit', N'J.R.R. Tolkien', N'Allen & Unwin', N'1937', N'Fantasy', N'English', 55, NULL),
('S008', N'The Lord of the Rings', N'J.R.R. Tolkien', N'Allen & Unwin', N'1954', N'Fantasy', N'English', 60, NULL),
('S009', N'Đắc nhân tâm', N'Dale Carnegie', N'NXB Trẻ', N'1936', N'Non-fiction', N'Tiếng Việt', 50, NULL),
('S010', N'Think and Grow Rich', N'Napoleon Hill', N'Ballantine Books', N'1937', N'Self-help', N'English', 20, NULL),
('S011', N'Rich Dad Poor Dad', N'Robert Kiyosaki', N'Warner Books', N'1997', N'Finance', N'English', 30, NULL),
('S012', N'The Lean Startup', N'Eric Ries', N'Crown Business', N'2011', N'Business', N'English', 40, NULL);
INSERT INTO PHIEU(MAPHIEU, NGAYMUON, NGAYTRA, LOAIPHIEU, MADG, HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, GMAIL, MAQT)
VALUES
('PM001', '2024-04-20', '2024-04-25', 1, 'DG001', N'Trần Thị A', '1985-04-12', N'Nữ', '0987123456', N'24 Nguyễn Trãi', 'trantha@gmail.com', NULL),
('PM002', '2024-04-21', '2024-04-26', 1, 'DG002', N'Nguyễn Văn B', '1990-08-25', N'Nam', '0912345678', N'123 Lê Lợi', 'nguyenvanb@gmail.com', NULL),
('PM003', '2024-04-22', '2024-04-27', 2, 'DG003', N'Lê Văn C', '1973-11-01', N'Nam', '0923456789', N'56 Bà Triệu', 'levanc@gmail.com', NULL),
('PM004', '2024-04-23', '2024-04-28', 2, 'DG004', N'Phạm Thị D', '1982-03-15', N'Nữ', '0934567890', N'78 Lý Tự Trọng', 'phamthid@gmail.com', NULL),
('PM005', '2024-04-24', '2024-04-29', 1, 'DG005', N'Hồ Ngọc E', '1978-05-22', N'Nữ', '0945678901', N'60 Hai Bà Trưng', 'hongoce@gmail.com', NULL),
('PM006', '2024-04-25', '2024-04-30', 1, 'DG006', N'Võ Thị F', '1995-07-30', N'Nữ', '0956789012', N'234 Đồng Khởi', 'vothif@gmail.com', NULL),
('PM007', '2024-04-26', '2024-05-01', 2, 'DG007', N'Bùi Gia G', '1988-09-17', N'Nam', '0967890123', N'90 Thành Thái', 'buigiag@gmail.com', NULL),
('PM008', '2024-04-27', '2024-05-02', 2, 'DG008', N'Dương Văn H', '2000-01-05', N'Nam', '0978901234', N'12 Trần Hưng Đạo', 'duongvanh@gmail.com', NULL),
('PM009', '2024-04-28', '2024-05-03', 1, 'DG009', N'Trịnh Hồng I', '1981-12-12', N'Nữ', '0989012345', N'150 Nguyễn Văn Cừ', 'trinhhongi@gmail.com', NULL),
('PM010', '2024-04-29', '2024-05-04', 1, 'DG010', N'Nguyễn Khánh J', '1998-10-19', N'Nam', '0990123456', N'22 Lê Duẩn', 'nguyenkhanhj@gmail.com', NULL);

INSERT INTO ADMINN(MAAD, USERNAME, PASS, MAQT)
VALUES
('AD001', 'admin1', 'adminpass1', NULL),
('AD002', 'admin2', 'adminpass2', NULL);


INSERT INTO QUANTHU(MAQT, HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, GMAIL, USERNAME, PASS, MADG, MAAD, MASACH, MAPHIEU)
VALUES
('QT001', N'Nguyễn Thị A', '1985-04-12', N'Nữ', '0987123456', N'24 Nguyễn Trãi', 'nguyenthia@gmail.com', 'userA', 'passA', 'DG001', 'AD001', 'S001', 'PM001'),
('QT002', N'Phạm Văn B', '1990-08-25', N'Nam', '0912345678', N'123 Lê Lợi', 'phamvanb@gmail.com', 'userB', 'passB', 'DG002', 'AD002', 'S002', 'PM002'),
('QT003', N'Lê Thị C', '1973-11-01', N'Nam', '0923456789', N'56 Bà Triệu', 'lethic@gmail.com', 'userC', 'passC', 'DG003', 'AD001', 'S003', 'PM003'),
('QT004', N'Hoàng Minh D', '1982-03-15', N'Nữ', '0934567890', N'78 Lý Tự Trọng', 'hoangminhd@gmail.com', 'userD', 'passD', 'DG004', 'AD001', 'S004', 'PM004'),
('QT005', N'Trần Ngọc E', '1978-05-22', N'Nữ', '0945678901', N'60 Hai Bà Trưng', 'trannogce@gmail.com', 'userE', 'passE', 'DG005', 'AD001', 'S005', 'PM005');

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

