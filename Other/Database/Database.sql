create database DataTranslate
go
use DataTranslate
go
create table Quyen
(
	MaQuyen int identity(1,1) primary key,
	TenQuyen nvarchar(100) not null,
	SoLuong int default(0),
)
go
insert into Quyen(TenQuyen, SoLuong) values(N'BanQuanTri', 2);
insert into Quyen(TenQuyen, SoLuong) values(N'Thành Viên', 2);
go
create table NguoiDung
(
	TaiKhoan varchar(50) primary key,
	MatKhau varchar(50) not null,
	HoVaTen varchar(100) not null,
	TrangThai int default(0),
	MaQuyen int,

	foreign key(MaQuyen) references Quyen(MaQuyen),
)
go
insert into NguoiDung(TaiKhoan, MatKhau, HoVaTen, TrangThai, MaQuyen) values('Admin', 'abc123', N'Ban Quản Trị', 0, 1);
insert into NguoiDung(TaiKhoan, MatKhau, HoVaTen, TrangThai, MaQuyen) values('hoang', 'abc123', N'Chung Hoàng', 0, 1);
insert into NguoiDung(TaiKhoan, MatKhau, HoVaTen, TrangThai, MaQuyen) values('minh', 'abc123', N'Nhật Minh', 0, 1);
insert into NguoiDung(TaiKhoan, MatKhau, HoVaTen, TrangThai, MaQuyen) values('chung', 'abc123', N'Hoàng Chung', 0, 1);
go
create table NgonNgu
(
	MaNgonNgu int identity(1,1) primary key,
	TenNgonNgu nvarchar(100) not null,
)
go
insert into NgonNgu(TenNgonNgu) values(N'Tiếng Việt');
insert into NgonNgu(TenNgonNgu) values(N'Tiếng Anh');
insert into NgonNgu(TenNgonNgu) values(N'Tiếng Pháp');
insert into NgonNgu(TenNgonNgu) values(N'Tiếng Trung');
go
create table TuVung
(
	MaTu int identity(1,1) primary key,
	TenTu nvarchar(max) not null,
	API nvarchar(200)null default(null),
	TaiKhoan varchar(50) null,

	foreign key(TaiKhoan) references NguoiDung(TaiKhoan),
)
go
insert into TuVung(TenTu, API, TaiKhoan) values(N'Xin Chào', );
go
create table Nghia
(
	MaNghia int identity(1,1) primary key,
	Nghia nvarchar(50) not null,
	MaTu int,
	MaNgonNgu int,

	foreign key(MaTu) references TuVung(MaTu),
	foreign key(MaNgonNgu) references NgonNgu(MaNgonNgu),
)
go
create table LichSuTraTu
(
	TaiKhoan varchar(50),
	MaTu int,
	primary key(TaiKhoan, MaTu),
	NgayTra datetime null,
	
	foreign key(TaiKhoan) references NguoiDung(TaiKhoan),
	foreign key(MaTu) references TuVung(MaTu),
)
go
create table YeuThich
(
	TaiKhoan varchar(50),
	MaTu int,
	primary key(TaiKhoan, MaTu),
	Ngay datetime null,
	
	foreign key(TaiKhoan) references NguoiDung(TaiKhoan),
	foreign key(MaTu) references TuVung(MaTu),
)