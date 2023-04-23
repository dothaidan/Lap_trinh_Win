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

create table FoodCategory 
(
id int identity primary key,
name nvarchar(100) not null
)
create table Food
(
id int identity primary key,
name nvarchar(100) not null,
idCategory int not null,
price float not null,

foreign key (idCategory) references dbo.FoodCategory(id)
)
-- them category 
insert dbo.FoodCategory(name)
values (N'Nước')
insert dbo.FoodCategory(name)
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

