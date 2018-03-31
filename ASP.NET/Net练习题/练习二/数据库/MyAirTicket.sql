create database MyAirTicket
go
use MyAirTicket
go
create table ProvinceInfo	--省份信息表
(
	ProviceId int primary key identity(1,1),	--省序号
	ProviceName varchar(50)	--省名字
)
go
insert into ProvinceInfo
values('北京')
insert into ProvinceInfo
values('广东')
insert into ProvinceInfo
values('上海')
select * from ProvinceInfo
go
create table CityInfo	--城市信息表
(
	CityId int primary key identity(1,1),	--城市序号
	CityName varchar(50),	--城市名称
	ProviceId int foreign key references ProvinceInfo(ProviceId)	--省名字
)
go
insert into CityInfo
values('北京',1)
insert into CityInfo
values('广州',2)
insert into CityInfo
values('深圳',2)
select * from CityInfo

go
create table Ticket	--机票信息表
(
	TicketID int primary key identity(1,1),
	FlightOrder varchar(50),	--航班班次
	FromCity int foreign key references CityInfo(CityId),	--出发城市
	ToCity int foreign key references CityInfo(CityId),	--抵达城市
	Price int,	--机票价格
	LeaveDate varchar(50),	--出发时间
	RoomType int,	--仓位类型	1：经济舱 2：头等舱 3：豪华舱
)
insert into Ticket
values('G12','1','2','300','2016-6-14','2')
insert into Ticket
values('G13','1','3','300','2016-6-14','3')
go
select * from Ticket