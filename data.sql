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


-- thêm category 
insert into FoodCategory(name)
values (N'Cafe')
insert into FoodCategory(name)
values (N'Trà hoa quả')
insert into FoodCategory(name)
values (N'Sinh tố')
insert into FoodCategory(name)
values (N'Nước ép')
insert FoodCategory(name)
values (N'Đồ ăn vặt')


-- thêm món
insert dbo.Food(name, idCategory, price)
values (N'Cafe đen đá', 1, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Cafe nâu đá', 1, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Cafe cốt dừa', 1, 30000)
insert dbo.Food(name, idCategory, price)
values (N'Bạc xỉu', 1, 25000)
insert dbo.Food(name, idCategory, price)
values (N'Trà đào cam sả', 2, 35000)
insert dbo.Food(name, idCategory, price)
values (N'Trà xoài chanh vàng', 2, 35000)
insert dbo.Food(name, idCategory, price)
values (N'Trà cúc', 2, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Trà nhài kem chesse', 2, 35000)
insert dbo.Food(name, idCategory, price)
values (N'Sinh tố xoài', 3, 40000)
insert dbo.Food(name, idCategory, price)
values (N'Sinh tố bơ', 3, 40000)
insert dbo.Food(name, idCategory, price)
values (N'Sinh tố mãng cầu', 3, 40000)
insert dbo.Food(name, idCategory, price)
values (N'Sinh tố sữa chua', 3, 40000)
insert dbo.Food(name, idCategory, price)
values (N'Nước ép dứa', 4, 30000)
insert dbo.Food(name, idCategory, price)
values (N'Nước ép cam', 4, 30000)
insert dbo.Food(name, idCategory, price)
values (N'Nước ép dưa hấu', 4, 30000)
insert dbo.Food(name, idCategory, price)
values (N'Bánh ngọt', 5, 25000)
insert dbo.Food(name, idCategory, price)
values (N'Hạt hướng dương thường', 5, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Hạt hướng dương dừa', 5, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Khô bò', 5, 20000)
insert dbo.Food(name, idCategory, price)
values (N'Khô gà', 5, 20000)


-- thêm bill
insert Bill (DateCheckIn, DateCheckOut, idTable, status) 
values		(GETDATE(), NULL, 1, 0) 
insert Bill (DateCheckIn, DateCheckOut, idTable, status) 
values		(GETDATE(), NULL, 2, 0)
insert Bill (DateCheckIn, DateCheckOut, idTable, status) 
values		(GETDATE(), GETDATE(), 2, 1)  


-- thêm bill info
insert BillInfo (idBill, idFood, count) 
values			(1, 3, 4)
insert BillInfo (idBill, idFood, count) 
values			(1, 5, 1)
insert BillInfo (idBill, idFood, count) 
values			(2, 1, 2)
insert BillInfo (idBill, idFood, count) 
values			(1, 1, 2)
insert BillInfo (idBill, idFood, count) 
values			(1, 6, 2)
insert BillInfo (idBill, idFood, count) 
values			(3, 5, 2)

-- thêm account
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
-- thêm bàn
declare @i int = 1
while @i <= 20
begin
	insert TableFood (name) values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1
end

-- tạo store procedure cho Account

create proc USP_Login	
@userName Nvarchar(100), @passWord Nvarchar(1000)
as 
begin
	select * from Account where username = @userName and password = @passWord
end
go

create proc USP_UpdateAccount --dùng cho thay đổi mật khẩu
@UserName Nvarchar(100), @Password Nvarchar(1000), @NewPassword Nvarchar(1000)
as
begin
	declare @isRightPass int = 0
	select @isRightPass = count(*) from Account where UserName = @UserName and Password = @Password
	if (@isRightPass = 1)
	begin
		if (@NewPassword = null or @NewPassword = '')
			update Account set DisplayName = @DisplayName where UserName = @UserName
		else
			update Account set DisplayName = @DisplayName, Password = @NewPassword where UserName = @UserName
	end
end
go

--end store procedure cho Account

-- tạo store procedure cho table

create proc USP_GetTableList
as select * from TableFood
go

-- end store procedure cho table

--tạo store procedure cho Bill

create proc USP_GetUnCheckBillIDByTableID
	@idTable int
as
	select * from Bill where idTable = @idTable AND Status = 0
go


create proc USP_GetBillInfo
    @idBill int
as
begin
    select * from BillInfo where idBill = @idBill
end
go

create proc USP_GetBillInfoByIDTable
	@idTable Int
as
begin
	select f.name, bi.count, f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b, Food as f 
	where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = @idTable
end
go

--end store procedure cho Bill 
