drop database VEXE
go
create database VEXE
go
use VEXE
go
SET DATEFORMAT DMY
go


Create table KhachHang
(
	MaKH char(10) primary key,
	TenKH nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50)
)
go
create table ChucVu
(
	MaCV char(10) primary key,
	TenCV nchar(15),
)
go
create table Nhanvien
(
	MaNV varchar(20) primary key,
	MatKhau varchar(20) default '',
	TenNV nvarchar(50),
	NgaySinhNV date,
	DiaChiNV nvarchar(50),
	MaCV char(10),
	constraint FK_NV_CV foreign key(MACV) references ChucVu(MaCV)
)
go
Create table TuyenXe
(
	MaTuyen char(10) primary key,
	TenTuyen nvarchar(30),
	GiaVe int
)
go
create table Xe
(
	MaXe char(10) primary key,	
	TTXe varchar(30),
	MaTX varchar(20),
	constraint FK_XE_NV foreign key(MaTX) references Nhanvien(MaNV)
)
go
create table ChuyenXe
(
	MaChuyen char(10) primary key,
	TenChuyen nvarchar(50),
	MaTuyen char(10),
	MaXe char(10),
	GioXuatPhat char(5),
	constraint FK_CX_TX foreign key (MaTuyen) references TuyenXe(MaTuyen),
	constraint FK_CX_XE foreign key (MaXe) references Xe(MaXe)
)
go
create table VeXe
(
	MaVe int identity(1,1),
	MaKH char(10),
	MaChuyen char(10),
	NgayDi date,
	ViTri char(3) ,
	constraint PK_VEXE primary key(MaVe,MaKH),
	constraint FK_VE_CX foreign key(MaChuyen) references ChuyenXe(MaChuyen)	
)

go
alter table VeXe
add constraint FK_VE_KH foreign key(MaKH) references KhachHang(MaKH)
go
insert into KhachHang
values('KH001',N'Nguyễn Văn A','23/03/1989',N'140 Lê Trọng Tấn'),
		('KH002',N'Nguyễn Văn B','13/07/1991',N'335 Nguyễn Du'),
		('KH003',N'Nguyễn Văn C','03/05/1987',N'115/25 Quang Trung'),
		('KH004',N'Nguyễn Văn D','30/06/1992',N'63 Nguyễn Thái Học'),
		('KH005',N'Nguyễn Văn E','12/08/1994',N' 417 Bà Hom'),
		('KH006',N'Nguyễn Văn F','11/08/1992',N' 366 Lê Lai'),
		('KH007',N'Nguyễn Văn G','14/04/1997',N' 213 Đường số 3'),
		('KH008',N'Nguyễn Văn H','27/07/1995',N' 899 Phù Đổng Thiên Vương'),
		('KH009',N'Nguyễn Văn I','22/05/1981',N' 312 Tô Hiệu'),
		('KH010',N'Nguyễn Văn L','18/08/1990',N' 13 Phạm Thế Hiển'),
		('KH011',N'Nguyễn Văn K','09/01/1995',N' 453 Tân Phú')

go
insert into ChucVu
values('ADMIN',N'ADMIN'),('NV',N'Nhân viên'),('TX',N'Tài xế')
go
insert into Nhanvien
values('ADMIN','admin',N'Trần Văn A','20/04/1992',N'36 Tây Thạnh','ADMIN'),
		('NV001','1234',N'Nguyễn Thị B','14/07/1987',N'145 Lê Lợi','NV'),
		('NV002','1234',N'Trịnh Thị M','18/03/1993',N'137 Tây Sơn','NV'),
		('NV003','1234',N'Nguyễn Quang P','21/10/1989',N'63 Tân Thắng','NV'),
		('TX001','',N'Nguyễn Quốc C','31/05/1983',N'48 Bình Lợi','TX'),
		('TX002','',N'Lê Anh D','07/11/1990',N'128 Cầu Giấy','TX'),
		('TX003','',N'Trần Minh E','20/05/1984',N'45 Nguyễn Trãi','TX'),
		('TX004','',N'Nguyễn Văn F','30/08/1986',N'23 Đông Hưng','TX'),
		('TX005','',N'Nguyễn Anh G','20/09/1991',N'1137 Lê Đức Thọ','TX'),
		('TX006','',N'Đỗ Quốc H','03/02/1989',N'366 Quang Trung','TX'),
		('TX007','',N'Trần Văn K','27/06/1981',N'29/2 Nguyễn Văn Quá',N'TX')
go		
insert into TuyenXe
values('SGVT',N'Sài Gòn - Vũng Tàu',150),
		('SGBT',N'Sài Gòn - Bình Thuận',250),
		('SGNT',N'Sài Gòn - Ninh Thuận',300),
		('SGNTR',N'Sài Gòn - Nha Trang',350)
go
insert into Xe
values('X001','BS 51F-000.01','TX001'),
		('X002','BS 51F-000.02','TX002'),
		('X003','BS 51F-000.03','TX003'),
		('X004','BS 51F-000.04','TX004'),
		('X005','BS 51F-000.05','TX005'),
		('X006','BS 51F-000.06','TX006')
go
insert into ChuyenXe
values('SGVT16H',N'Sài Gòn - Vũng Tàu 16h','SGVT','X001','16h'),
		('SGVT17H',N'Sài Gòn - Vũng Tàu 17h','SGVT','X002','17h'),
		('SGBT16H',N'Sài Gòn - Bình Thuận 16h','SGBT','X003','16h'),
		('SGNT17H',N'Sài Gòn - Ninh Thuận 17h','SGNT','X004','17h'),
		('SGNT18H',N'Sài Gòn - Ninh Thuận 18h','SGNT','X005','18h'),
		('SGNTR14H',N'Sài Gòn - Nha Trang 14h','SGNTR','X006','14h')
go
insert into VeXe
values('KH002','SGVT17H','19/12/2022','A1'),
		('KH003','SGVT17H','19/12/2022','A3'),
		('KH004','SGBT16H','21/12/2022','A2'),
		('KH005','SGNT17H','20/12/2022','A1'),
		('KH006','SGNT17H','22/12/2022','A1'),
		('KH007','SGNTR14H','18/12/2022','A2'),
		('KH008','SGNTR14H','18/12/2022','A3'),
		('KH011','SGVT17H','20/12/2022','A5')
go

