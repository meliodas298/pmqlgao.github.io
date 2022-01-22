create database QLGAO
Go
Use QLGAO
go
create table SANPHAM(
MaSP varchar(10) primary key,
TenSP nvarchar(30),
GiaTien int,
Donvi nvarchar(10),
TonKho int);
go
create table HOADON(
MaHD varchar(10) primary key,
TenKH nvarchar(30),
MaNV varchar(10),
NgayXuat datetime,
TongTien int,
NVVC nvarchar(30)
);
go
create table CTHD(
MaHD varchar(10),
MaSp varchar(10),
SoLuong int,
Donvi nvarchar(10),
ThanhTien int,
primary key(MaHD,MaSp));
go
create table NHANVIEN(
MaNV varchar(10) primary key,
HoTen nvarchar(30),
NgSinh date,
Sdt varchar(15),
CCCD varchar(15),
QueQuan nvarchar(30),
NgVL date,
ChucVu nvarchar(20),
);
create table TAIKHOAN
(
TaiKhoan varchar(30) primary key,
MatKhau varchar(30),
MaNV varchar(10),
NgayTao date
);
create table CHAMCONG
(
NgayCC date,
MaNV varchar(10),
Chamcong int,
LuongNgay int,
ThuongThem int,
UngTruoc int,
TongLuongThang int
primary key(NgayCC,MaNV)
);
go
alter table HOADON add constraint FK_HD_NV foreign key (MaNV) references NHANVIEN(MaNV)
alter table CTHD add constraint FK_CTHD_HD foreign key (MaHD) references HOADON(MaHD)
alter table CTHD add constraint FK_CTHD_SP foreign key (MaSP) references SANPHAM(MaSP)
alter table TAIKHOAN add constraint FK_TK_NV foreign key (MaNV) references NHANVIEN(MaNV)
alter table CHAMCONG add constraint FK_CC_NV foreign key (MaNV) references NHANVIEN(MaNV)
go

insert into SANPHAM values('GA1001',N'Gạo 64 Gò Công(70)',750000,'bao70',100)
insert into SANPHAM values('GA2001',N'Gạo 64 Gò Công(50)',550000,'bao50',30)
insert into SANPHAM values('GA1002',N'Gạo Đài Thơm 8(70)',1400000,'bao70',88)
insert into SANPHAM values('GA2002',N'Gạo Đài Thơm 8(50)',1000000,'bao50',150)
insert into SANPHAM values('GA1003',N'Nàng Thơm Chợ Đào(70)',1500000,'bao70',77)
insert into SANPHAM values('GA2003',N'Nàng Thơm Chợ Đào(50)',1150000,'bao50',50)
insert into SANPHAM values('GA1004',N'Gạo Nàng Xuân(70)',1400000,'bao70',50)
insert into SANPHAM values('GA2004',N'Gạo Nàng Xuân(50)',1000000,'bao50',30)
insert into SANPHAM values('GA1005',N'Gạo Lài Sữa(70)',1000000,'bao70',100)
insert into SANPHAM values('GA2006',N'Gạo ST5(50)',1100000,'bao50',200)
insert into SANPHAM values('GA2007',N'Gạo Jasmine 85(50)',650000,'bao50',150)
insert into SANPHAM values('GA2008',N'Gạo ST19(50)',900000,'bao50',150)
insert into SANPHAM values('GA2009',N'Gạo ST20(50)',1150000,'bao50',100)
insert into SANPHAM values('GA2010',N'Gạo ST24(50)',1600000,'bao50',150)
insert into SANPHAM values('GA2011',N'Gạo ST25(50)',1800000,'bao50',50)
insert into SANPHAM values('GA2012',N'Gạo Nàng Hoa 9(50)',750000,'bao50',50)
insert into SANPHAM values('GA2013',N'Gạo Trắng Hạt Dài 5451(50)',550000,'bao50',120)
insert into SANPHAM values('GA2014',N'Gạo Tài nguyên Chợ Đào(50)',800000,'bao50',130)

go
insert into NHANVIEN values('NV1001',N'Nguyễn Văn Toàn','12/20/1995','0978456258','158269347',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1002',N'Nguyễn Công Anh','1/10/1994','0978485025','158852123',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1003',N'Nguyễn Minh Tài','8/16/1993','0978456852','158262569',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1004',N'Nguyễn Văn Lâm','9/16/1995','0979752582','158264568',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1005',N'Nguyễn Trần Dần','4/14/1990','0939582456','134585212',N'Bến Tre','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1006',N'Nguyễn Công Toản','5/16/1985','0925156753','158258456',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1007',N'Nguyễn Thanh Toàn','4/15/1988','0972158654','158123654',N'Bến Tre','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1008',N'Trần Thanh Sơn','3/12/1987','0978854321','158856789',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1009',N'Nguyễn Hành Nhân','10/23/1983','097159753','158789582',N'Bến Tre','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1010',N'Dương Thanh Tuấn','11/22/1984','0978465482','158123852',N'Long An','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1011',N'Trần Văn Công','3/12/1982','0978236547','158159154',N'Tiền Giang','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV1012',N'Huỳnh Phát Nghĩa','2/24/1990','0978415965','158158156',N'Long An','4/5/2021',N'Công nhân bốc vác')
insert into NHANVIEN values('NV2001',N'Nguyễn Thị Kim Ngọc','12/13/1998','0923456852','285654123',N'Tiền Giang','4/5/2021',N'Kế Toán')
insert into NHANVIEN values('NV2002',N'Nguyễn Ngọc Thảo','5/08/1999','0979945914','294561852',N'Tiền Giang','4/5/2021',N'Kế Toán')
insert into NHANVIEN values('NV3001',N'Võ Thị Minh Hồng Chiếm','12/10/1999','0889186324','295412153',N'Tiền Giang','4/5/2021',N'Quản Lí')
insert into NHANVIEN values('NV4001',N'Nguyễn Quang Nhật','6/15/2000','0889269092','312413794',N'Tiền Giang','4/5/2021',N'Nhân viên dây chuyền')
insert into NHANVIEN values('NV4002',N'Huỳnh Quốc Bình','2/5/2000','0928145303','312452512',N'Tiền Giang','4/5/2021',N'Nhân viên dây chuyền')
insert into NHANVIEN values('NV4003',N'Lê Trọng Phúc','12/4/2000','0981969253','312465852',N'Tiên Giang','4/5/2021',N'Nhân viên dây chuyền')

go
insert into TAIKHOAN values('kt01','kt001','NV2001','4/6/2021')
insert into TAIKHOAN values('kt02','kt002','NV2002','4/6/2021')
insert into TAIKHOAN values('qlcute','vtmhc','NV3001','4/6/2021')
go
insert into HOADON values('BL0001',N'','NV3001','5/3/2021 6:10:11 PM',0,N'')
insert into HOADON values('XK0001',N'Nguyễn Văn A','NV3001','5/3/2021',0,N'')
insert into HOADON values('NK0001',N'Lê Thị B','NV3001','5/3/2021',0,N'')

insert into CTHD values('BL0001','GA1001',1,'',0)
insert into CTHD values('XK0001','GA2001',1,'',0)
insert into CTHD values('XK0001','GA1001',1,'',0)
insert into CTHD values('NK0001','GA1002',1,'',0)
insert into CTHD values('NK0001','GA1003',1,'',0)


insert into CHAMCONG values('1/1/2021','NV1001',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1002',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1003',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1004',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1005',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1006',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1007',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1008',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1009',0,500000,0,0,0)
insert into CHAMCONG values('1/2/2021','NV1009',1,500000,0,0,500000)
insert into CHAMCONG values('1/1/2021','NV1010',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1011',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV1012',0,500000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV2001',0,325000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV2002',0,325000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV3001',0,999000,0,0,0)
insert into CHAMCONG values('1/2/2021','NV3001',1,999000,0,0,999000)
insert into CHAMCONG values('1/1/2021','NV4001',0,300000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV4002',0,300000,0,0,0)
insert into CHAMCONG values('1/1/2021','NV4003',0,300000,0,0,0)


insert into CTHD values('','','',,,)

create function DANGNHAP1(@TK varchar(10),@MK varchar(10))
returns int as
begin
	declare @a int;
	select @a =  Count(TaiKhoan)
	from TAIKHOAN
	where  TaiKhoan = @TK and MatKhau = @MK;
	return @a;	
end
go

create function DNMANV(@TK varchar(10))
returns table return
	select MaNV,MatKhau,TaiKhoan
	from TAIKHOAN
	where  TaiKhoan = @TK 
go

create function TTSANPHAM(@SP varchar(10))
returns table return
	select GiaTien,DonVi,TonKho
	from SANPHAM
	where  MaSP = @SP 
go

create PROC THEMHOADON(@MAHD varchar(10),@TenKH nvarchar(30),@MaNV varchar(10),@Date date,@Tongtien int,@MaSp varchar(10),@SL int,@Donvi varchar(10))
as
begin
	Insert into HOADON(MaHD,TenKH,MaNV,NgayXuat,TongTien) values (@MAHD,@TenKH,@MaNV,@Date,@Tongtien)
	Insert into CTHD(MaHD,MaSp,SoLuong,Donvi,ThanhTien) values (@MAHD,@MaSp,@SL,@Donvi,@Tongtien)
	Update SANPHAM set TonKho = TonKho -@SL where MaSP = @MaSp
end

create function TTSANPHAM1(@SP varchar(10))
returns table return
	select MaSP,TenSP,GiaTien,DonVi,TonKho
	from SANPHAM
	where  MaSP = @SP 
go
create PROC THEMHOADONXuatNhap(@MAHD varchar(10),@TenKH nvarchar(30),@MaNV varchar(10),@Date datetime,@Tongtien int,@NVVC nvarchar(30))
as
begin
	Insert into HOADON(MaHD,TenKH,MaNV,NgayXuat,TongTien,NVVC) values (@MAHD,@TenKH,@MaNV,@Date,@Tongtien,@NVVC)
end

create PROC THEMCTHDXK (@MAHD varchar(10),@MASP varchar(10),@SL int,@Donvi varchar(10),@Tongtien int)
as
begin
	Insert into CTHD(MaHD,MaSp,SoLuong,Donvi,ThanhTien) values (@MAHD,@MASP,@SL,@Donvi,@Tongtien)
	Update SANPHAM set TonKho = TonKho -@SL where MaSP = @MASP
end
go

create PROC THEMCTHDNK (@MAHD varchar(10),@MASP varchar(10),@SL int,@Donvi varchar(10),@Tongtien int)
as
begin
	Insert into CTHD(MaHD,MaSp,SoLuong,Donvi,ThanhTien) values (@MAHD,@MASP,@SL,@Donvi,@Tongtien)
	Update SANPHAM set TonKho = TonKho +@SL where MaSP = @MASP
end
go

create function CHUCVUNV()
returns table return
	select distinct(ChucVu)
	from NHANVIEN
go

create function TenNV(@chucvu nvarchar(20))
returns table return
		select HoTen,MaNV
		from NHANVIEN
		where  ChucVu = @chucvu
go

create function THONGTINNV(@manv varchar(10))
returns table return
		select HoTen,MaNV,NgSinh,Sdt,CCCD,QueQuan,ChucVu,NgVL
		from NHANVIEN
		where  MaNV = @manv
go

create PROC XOANV (@manv varchar(10))
as
begin
	delete from NHANVIEN where MaNV = @manv
end
go

create PROC THEMNV (@manv varchar(10),@hoten nvarchar(30),@ngaysinh date,@sdt varchar(15),@cccd varchar(15),@quequan nvarchar(30),@ngayvl date,@chucvu nvarchar(20),@luong int)
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgSinh,Sdt,CCCD,QueQuan,NgVL,ChucVu) values(@manv,@hoten,@ngaysinh,@sdt,@cccd,@quequan,@ngayvl,@chucvu)
	insert into CHAMCONG(NgayCC,MaNV,Chamcong,LuongNgay,ThuongThem,UngTruoc,TongLuongThang) values ('1/1/2021',@manv,0,@luong,0,0,0)
end
go

Create function TANGMANHANVIEN(@chucvu nvarchar(20))
returns table return
	select top 1(MaNV) from NHANVIEN where ChucVu = @chucvu order by MaNV desc
go

create PROC CAPNHATNV (@manv varchar(10),@ngaysinh date,@sdt varchar(15),@cccd varchar(15),@quequan nvarchar(30),@ngayvl date)
as
begin
	update NHANVIEN set NgSinh = @ngaysinh,Sdt = @sdt,CCCD = @cccd,QueQuan = @quequan , NgVL = @ngayvl 
	where MaNV = @manv
end
go

create function HIENTHITAIKHOAN()
returns table return
	select TaiKhoan from TAIKHOAN
go

create function XUATMANV(@taikhoan varchar(30))
returns table return
	select MANV from TAIKHOAN where TaiKhoan = @taikhoan;
go

create PROC DOIMATKHAU(@taikhoan varchar(30),@matkhau varchar(30))
as
begin
	update TAIKHOAN set MatKhau = @matkhau where TaiKhoan = @taikhoan
end
go

create PROC CAPNHATSP(@masp varchar(10),@giatien int,@tonkho int)
as
begin
	update SANPHAM set GiaTien = @giatien,TonKho = @tonkho where MaSP = @masp
end
go

create PROC THEMSP(@masp varchar(10),@tensp nvarchar(30),@giatien int,@donvi varchar(10),@tonkho int)
as
begin
	insert into SANPHAM(MaSP,TenSP,GiaTien,Donvi,TonKho) values (@masp,@tensp,@giatien,@donvi,@tonkho)
end
go

create function XUATCHAMCONG (@manv nvarchar(20))
returns table as return
	select top 1 Chamcong,UngTruoc,LuongNgay,ThuongThem,TongLuongThang,NgayCC from CHAMCONG where MaNV = @manv order by NgayCC desc
go

create PROC  PROCCHAMCONG(@ngaycc date,@manv varchar(10),@chamcong int,@luongngagy int,@thuongthem int, @ungtruoc int,@tongluongthang int)
as
begin
	insert into CHAMCONG(NgayCC,MaNV,Chamcong,LuongNgay,ThuongThem,UngTruoc,TongLuongThang) values (@ngaycc,@manv,@chamcong,@luongngagy,@thuongthem,@ungtruoc,@tongluongthang)
end
go

create PROC NHAPUNGTHUONG(@manv nvarchar(20),@ngaycc date,@ungtruoc int,@thuong int)
as
begin
	update CHAMCONG set UngTruoc = UngTruoc + @ungtruoc, ThuongThem = ThuongThem +@thuong where MaNV = @manv and NgayCC = @ngaycc
end
go

create function NGAYCUOITHANG(@manv varchar(10))
returns table return
 select top 1(NgayCC) from CHAMCONG where MaNV = @manv order by NgayCC desc
 go

create PROC THANGMOI(@manv varchar(10),@ngaycc date)
as
begin
	update CHAMCONG set Chamcong = 0,UngTruoc = 0,ThuongThem = 0,TongLuongThang=0 where MaNV = @manv and NgayCC = @ngaycc
end
go

create function XUATHOADONTHEONV (@manv varchar(10),@thang int,@nam int)
returns table return
	select MaHD,TenKH,NgayXuat,TongTien,NVVC from HOADON where MaNV = @manv and MONTH(NgayXuat) = @thang and YEAR(NgayXuat) = @nam
go

create function HOADONTHEOLOAI (@loai varchar(10))
returns table return
	select MaHD from HOADON where MaHD like @loai+'%'
go

create function XUATCTHD (@mahd varchar(10))
returns table return
	select C.MaSp,TenSP,C.Donvi,SoLuong,ThanhTien from CTHD C,SANPHAM S where C.MaSp = S.MaSP and MaHD = @mahd
go

create function XUATRPXUATNHAPHD (@mahd varchar(10))
returns table return
	select H.MaHD,TenKH,HoTen,NgayXuat,H.TongTien,NVVC,C.MaSP,TenSP,SoLuong,C.DonVi,C.ThanhTien,GiaTien 
	from SANPHAM S,CTHD C,HOADON H,NHANVIEN N 
	where S.MaSP = C.MaSp and C.MaHD = H.MaHD and H.MaNV = N.MaNV and H.MaHD = @mahd
go

create function XUATDOANHTHUMTN (@mahd varchar(10),@thang int,@nam int)
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where MONTH(NgayXuat) = @thang  and YEAR(NgayXuat) = @nam and MaHD like @mahd+'%'
go

create function XUATDOANHTHUTN (@thang int,@nam int)
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where MONTH(NgayXuat) = @thang  and YEAR(NgayXuat) = @nam
go

create function XUATDOANHTHUMT (@mahd varchar(10),@thang int)
returns table as return 
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where  MaHD like  @mahd+'%'  and  MONTH(NgayXuat) = @thang
go

create function XUATDOANHTHUMN (@mahd varchar(10),@nam int)
returns table as return 
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where  MaHD like  @mahd+'%'  and  YEAR(NgayXuat) = @nam
go

create function XUATDOANHTHUN (@nam int)
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where  YEAR(NgayXuat) = @nam
go

create function XUATDOANHTHUM (@mahd varchar(10))
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where  MaHD like  @mahd+'%'
go

create function XUATDOANHTHUT (@thang int)
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where  MONTH(NgayXuat) = @thang
go	

create function XUATDOANHTHU()
returns table as return
	select SUBSTRING(MAHD,1,2) as Ma,MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON 
go	

select SUBSTRING(MAHD,1,2) as Ma from HOADON
select*from XUATDOANHTHUTN(5,2021)

select top 1(MaHD) from HOADON where MaHD like 'NK%' order by MaHD desc
select*from NHANVIEN
select*from SANPHAM
select*from TAIKHOAN
select*from HOADON
select*from CTHD
select*from CHAMCONG
select  distinct C.MaNV ,N.HoTen,C.Chamcong,C.UngTruoc,C.LuongNgay,C.ThuongThem,C.TongLuongThang from NHANVIEN N,CHAMCONG C where N.MaNV = C.MaNV and ChucVu = N'Công nhân bốc vác' order by C.MaNV asc
select  C.MaNV,HoTen,UngTruoc,LuongNgay,ThuongThem,TongLuongThang from CHAMCONG C inner join NHANVIEN N on N.MaNV = C.MaNV 
where ChucVu = N'Công nhân bốc vác' and c.MaNV in (select distinct(MaNV) from NHANVIEN )

select*from XUATCHAMCONG('NV3001')

select*from NGAYCUOITHANG('NV1001')

select MAX(chamcong) from CHAMCONG where MaNV = 'NV2001'
select top 1(MaHD) from HOADON where MaHD like 'BL%' order by MaHD desc
go
select H.MaHD,TenKH,HoTen,NgayXuat,H.TongTien,NVVC,C.MaSP,TenSP,SoLuong,C.DonVi,C.ThanhTien,GiaTien from SANPHAM S,CTHD C,HOADON H,NHANVIEN N where S.MaSP = C.MaSp and C.MaHD = H.MaHD and H.MaNV = N.MaNV and H.MaHD = 'XK0005'
select MaHD,TenKH, NgayXuat,MONTH(NgayXuat)as Thang ,YEAR(NgayXuat) as Nam , TongTien  from HOADON where MONTH(NgayXuat) = 5  and YEAR(NgayXuat) = 2021 and MaHD = 'BL%'

select*from dbo.THONGTINNV('NV1001')
select dbo.DANGNHAP1('kt01','kt001')
select*from DNMANV('kt01')
select*from TTSANPHAM1('GA2004')
THEMHOADON 'BL0005' , N'','NV2002','5/3/2021',1000000,'GA2002',1,'bao50'
THEMHOADONXuatNhap 'XK0003',N'Nguyen van A', 'NV2001' , '5/5/2021' ,  1000000   , N'MAXK.tennvvc'
XOANV NV4003

select*from TANGMANHANVIEN(N'Công nhân bốc vác')
select*from HIENTHITAIKHOAN()
select*from XUATHOADONTHEONV('NV2001',5,2021)
select*from HOADONTHEOLOAI('BL')