create database QuanLyQuanCafe
go

use QuanLyQuanCafe
go

create table Account(
	Username Nvarchar(100) primary key,
	DisplayName Nvarchar(100) not null,
	Password Nvarchar(1000) not null,
	Type int not null default 0 --0: staff, 1: admin
)
drop table Account
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
values		(GETDATE(), NULL, 5, 0) 
insert Bill (DateCheckIn, DateCheckOut, idTable, status) 
values		(GETDATE(), NULL, 6, 0)
insert Bill (DateCheckIn, DateCheckOut, idTable, status) 
values		(GETDATE(), GETDATE(), 7, 1)  

select * from dbo.TableFood
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

-- thêm tablefood
declare @i int = 0 
while @i <= 20
begin 
	insert dbo.TableFood (name) values (N'Bàn ' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end
update dbo.TableFood set status = N'Có người' where id = 6
update dbo.TableFood set status = N'Có người' where id = 9
select * from dbo.TableFood

-- thêm account
insert into Account (
	Username,
	DisplayName,
	Password,
	Type
) Values (
	N'admin',N'ADMIN', N'123456', 1
)
insert into Account (
	Username,
	DisplayName,
	Password,
	Type
) Values (
	N'staff',N'STAFF', N'123456', 0
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

create PROC USP_UpdateAccount --dùng cho thay đổi mật khẩu
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO




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
alter table Bill drop constraint idTable
DBCC CHECKIDENT('Bill', RESEED, 0)
select * from dbo.Bill
select * from dbo.BillInfo
select * from dbo.Food
select * from dbo.FoodCategory
select * from Account
delete from Food where id = 21


CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) )
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput
		IF @strInput = '' RETURN @strInput 
			DECLARE @RT NVARCHAR(4000) 
			DECLARE @SIGN_CHARS NCHAR(136) 
			DECLARE @UNSIGN_CHARS NCHAR (136) 
			SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
			SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
			DECLARE @COUNTER int 
			DECLARE @COUNTER1 int 
			SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
				BEGIN 
					SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
					BEGIN 
						IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
						BEGIN 
							IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
							ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
							BREAK 
						END 
						SET @COUNTER1 = @COUNTER1 +1 
					END 
					SET @COUNTER = @COUNTER +1 
				END 
				SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END



