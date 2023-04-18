create database QuanLyQuanCafe
go

use QuanLyQuanCafe
go

create table Account(
	Username Nvarchar(100) primary key,
	Password Nvarchar(1000) not null,
	Type int not null default 0 --0: staff, 1: admin
)
insert into Account (
	Username,
	Password,
	Type
) Values (
	N'admin', N'123456', 1
)
insert into Account (
	Username,
	Password,
	Type
) Values (
	N'staff', N'123456', 0
)