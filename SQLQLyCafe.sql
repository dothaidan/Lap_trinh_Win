create database QuanLyQuanCafe
go

use QuanLyPhanMem
go

--account
--food
--foodcategory
--table
--bill
--billinfo

CREATE TABLE TableFood
(
	id int identity primary key,
	name nvarchar(100) not null,
	status nvarchar(100) not null default N'Trống' --trống || có người
)
go

create table Account
(
	username nvarchar(100) primary key,
	password nvarchar(1000) not null,
	type int not null --1 admin, 0 staff
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null,
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null,
	idCategory int not null,
	price float not null

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status  int not null default 0 --1: đã thanh toán, 0: chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id)
)
go

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go