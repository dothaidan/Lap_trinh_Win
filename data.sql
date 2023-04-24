create database QuanLyQuanCafe
go

use QuanLyQuanCafe
go

create table Account(
	Username Nvarchar(100) primary key,
	Password Nvarchar(1000) not null,
	Type int not null default 0 --0: staff, 1: admin
)

CREATE TABLE TableFood
(
	id int identity primary key,
	name nvarchar(100) not null,
	status nvarchar(100) not null default N'Trống' --trống || có người
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


-- them category 
insert into FoodCategory(name)
values (N'Nước')
insert FoodCategory(name)
values (N'Đỗ ăn')
-- them mon an
insert dbo.Food(name,idCategory,price)
values (N'Cafe đen đá' ,1,12000)
insert dbo.Food(name,idCategory,price)
values (N'Bạc xỉu' ,1,15000)
insert dbo.Food(name,idCategory,price)
values (N'Bánh mì pate' ,2,30000)
insert dbo.Food(name,idCategory,price)
values (N'Sinh tố' ,1,20000)
insert dbo.Food(name,idCategory,price)
values (N'Cơm chiên' ,2,45000)

select * from dbo.Food
select * from dbo.FoodCategory



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

create proc USP_GetAccountByUserName
@userName Nvarchar(100)
as 
begin
	select * from Account where username = @userName
end
go

exec USP_GetAccountByUserName @userName = N'admin'

select * from Account where Username = N'admin' and Password = N'" + @password + "' and type = 1
select * from Account where Username = N'" + username + "'