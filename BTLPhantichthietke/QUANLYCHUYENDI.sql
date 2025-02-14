Create database QUANLYCHUYENDI
CREATE TABLE TAIKHOAN
(
	Tendangnhap nvarchar(50) not null primary key,
	Matkhau nvarchar(50),
	Sodienthoai Nvarchar(30),
	Hoten nvarchar (50),
	Ngaysinh date, 
	Diachi nvarchar (50),
)
select * from TAIKHOAN
Drop table TAIKHOAN
CREATE TABLE Ve
(	
	MaCD nvarchar (50) not null primary key,
	TenCD nvarchar (100),
	PT nvarchar (50),
	NGKH date,
	NGKT date,
	Giave int,
)
CREATE TABLE KhachHang(
	makh char(5) not null primary key,
	tenkhachhang nvarchar(30),
	sodienthoai varchar (15),
	diachi nvarchar(100),
	lichsudatve nvarchar(100),
	NHlienket nvarchar(50),
)
select * from KhachHang

Create table TheThanhVien(
	mathe char(5) not null primary key,
	diem int,
	ngaylap date,
);

create table NVQuanLi(
      
);
Drop table Ve
Drop table KhachHang
select * from Ve
Insert into Ve values 
('XK-102',N'Hà Ni - Nam Ðnh',N'Xe khách','20230523','20230524','245000'),
('XK-103',N'Hà Ni - Ninh Bình',N'Xe khách','20230523','20230524','240000'),
('XK-104',N'Hà Ni - Hi Phòng',N'Xe khách','20230523','20230524','210000'),
('XK-105',N'Hà Ni - Tuyên Quang',N'Xe khách','20230523','20230524','140000'),
('XK-106',N'Hà Ni - Sapa',N'Xe khách','20230523','20230524','300000'),
('MB-101',N'Sân bay Ni Bài - Sân bay Tân Sân Nht',N'Máy bay','20230523','20230524','1980000')


select * from khachhang
$"select MaKH as N'Mã khách hàng', Tenkhachhang as N'Tên khách hàng', SoDienThoai as N'Số điện thoại', DiaChi as N'Địa chỉ', lichsudatve as N'Lịch sử đặt vé', NHlienket as N'Ngân hàng liên kết' from KhachHang where sodienthoai = '{txbMaCanTim.Text}'";

select MaKH as N'Mã khách hàng', Tenkhachhang as N'Tên khách hàng', SoDienThoai as N'Số điện thoại', DiaChi as N'Địa chỉ', lichsudatve as N'Lịch sử đặt vé', NHlienket as N'Ngân hàng liên kết' from KhachHang