CREATE DATABASE QuanLyXeKhach;
go 
use QuanLyXeKhach;
create table TaiKhoan(
	stt int Identity(1,1),
	MaNV char(5),
	TenNV nvarchar(50),
	ChucVu nvarchar(50), 
	TenTK varchar(50) not null primary key,
	MatKhau varchar(50)
)
create table NhanVien(
	stt int Identity(1,1) ,
	MaNV char(5) not null ,
	TenNV nvarchar(50),
	ChucVu nvarchar(50),
	GioiTinh bit,
	SDT char(20),
	NgaySinh datetime,
	NgayVaoLam datetime,
	primary key(MaNV)
)
create table KhachHang(
	stt int Identity(1,1) ,
	MaKH char(5) not null ,
	TenKH nvarchar(50), 
	Sdt char(20),
	GioiTinh bit, 

	primary key (MaKH)
)

CREATE TABLE XeKhach(
	stt int Identity(1,1) ,
	MaXe Char(5) not null ,
	MaTaiXe char(5),
	MaHDV char(5),
	primary key(MaXe),
	foreign key(MaTaiXe) references NhanVien(MaNV),
	foreign key(MaHDV) references NhanVien(MaNV)
)
CREATE TABLE PhieuVe(
	stt int Identity(1,1) ,
	MaPhieu char(5) not null  ,
	MaKH char(5) not null ,
	TenKH nvarchar(50),
	MaNVBV char(5) not null,
	TenNVBV nvarchar(50),
	SoTien int, 
	ChoNgoi char(50),
	MaChuyenxe char(5) not null,
	NgayKhoiHanh datetime,
	TenDD nvarchar(100),
	primary key(MaPhieu),
	foreign key(MaKH) references KhachHang(MaKH),
	foreign key(MaNVBV) references NhanVien(MaNV),

)
Create table DiaDiem
(
	MaDD char(5) not null ,
	TebDD nvarchar(100),
	GiaTien int,
	primary key(MaDD)
)

create table HuongDanVien
(
	MaHDV char(5) not null,
	TenHDV nvarchar(50),
	MaCX char(5),
	NgayBatDau datetime,
	NgayKetThuc datetime,
	primary key(MaHDV),
	foreign key(MaHDV) references NhanVien(MaNV)

)
create table TaiXe
(
	MaTX char(5) not null,
	TenTX nvarchar(50),
	MaCX char(5),
	NgayBatDau datetime,
	NgayKetThuc datetime,
	primary key(MaTX),
	foreign key(MaTX) references NhanVien(MaNV)

)
create table ThongTinChuyenDi(
	stt int identity(1,1),
	MaChuyen char(5) not null primary key,
	MaTX char(5),
	TenTX nvarchar(50),
	MaHDV char(5),
	TenHDV nvarchar(50),
	MaCX char(5),
	TenDD nvarchar(50),
	NgayBatDau datetime,
	NgayKetThuc datetime,

)


use QuanLyXeKhach;
 select * from TaiKhoan

 delete from TaiKhoan;

insert into TaiKhoan values ('admin','Nguyễn Xuân Thịnh','admin','thinhadmin','123')
insert into TaiKhoan values ('NV1','Ngô Hồng Xinh','nhân viên bán vé','xinhseller','123')
insert into TaiKhoan values ('NV2','Bùi Lê Hồng Duyên','nhân viên văn phòng','Duyenemployee','123')
--DESKTOP-ODSUTT5\SQLEXPRESS

SELECT * FROM NhanVien
delete from NhanVien 

insert into NhanVien values ('NV1','Ngô Hồng Xinh','nhân viên bán vé','0','0832802655','09-28-2000','10-10-2022')
insert into NhanVien values ('NV2','Bùi Lê Hồng Duyên','nhân viên văn phòng','0','0832802655','09-28-2000','10-10-2022')
insert into NhanVien values ('NV3','Ngô Hồng Kim','HDV','0','0832802655','09-28-2000','10-10-2022')
insert into NhanVien values ('NV4','Huỳnh Văn Thuận','TX','1','0832802655','09-28-2000','10-10-2022')
insert into NhanVien values ('NV5','Huỳnh Văn Thanh','TX','1','0832806755','07-17-2000','10-10-2021')
insert into NhanVien values ('NV6','Trần Công Minh','HDV','0','0832802655','09-28-2000','10-10-2022')

--Insert into HuongDanVien()

Insert into DiaDiem values('DD1','TPHCM- Cố Đô Huế','3000000')
Insert into DiaDiem values('DD2','Hà Nội- Nha Trang','1500000')



Insert into XeKhach(MaXe) values('XK1')
Insert into XeKhach(MaXe) values('XK2')
Insert into XeKhach(MaXe) values('XK3')
Insert into XeKhach(MaXe) values('XK4')

select * from PhieuVe

delete from KhachHang where MaKH='KH4'

select * from KhachHang
insert into KhachHang values('KH1','Trần Thành Tâm' ,'823743','1')


delete from PhieuVe 
insert into PhieuVe values ('MP1','KH1','Trần Thành Tâm','NV1','Ngô Hồng Xinh',3000000,'ghe 34','XK1','05-05-2020','TPHCM- Cố Đô Huế')