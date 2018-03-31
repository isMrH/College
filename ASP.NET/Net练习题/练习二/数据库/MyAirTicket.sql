create database MyAirTicket
go
use MyAirTicket
go
create table ProvinceInfo	--ʡ����Ϣ��
(
	ProviceId int primary key identity(1,1),	--ʡ���
	ProviceName varchar(50)	--ʡ����
)
go
insert into ProvinceInfo
values('����')
insert into ProvinceInfo
values('�㶫')
insert into ProvinceInfo
values('�Ϻ�')
select * from ProvinceInfo
go
create table CityInfo	--������Ϣ��
(
	CityId int primary key identity(1,1),	--�������
	CityName varchar(50),	--��������
	ProviceId int foreign key references ProvinceInfo(ProviceId)	--ʡ����
)
go
insert into CityInfo
values('����',1)
insert into CityInfo
values('����',2)
insert into CityInfo
values('����',2)
select * from CityInfo

go
create table Ticket	--��Ʊ��Ϣ��
(
	TicketID int primary key identity(1,1),
	FlightOrder varchar(50),	--������
	FromCity int foreign key references CityInfo(CityId),	--��������
	ToCity int foreign key references CityInfo(CityId),	--�ִ����
	Price int,	--��Ʊ�۸�
	LeaveDate varchar(50),	--����ʱ��
	RoomType int,	--��λ����	1�����ò� 2��ͷ�Ȳ� 3��������
)
insert into Ticket
values('G12','1','2','300','2016-6-14','2')
insert into Ticket
values('G13','1','3','300','2016-6-14','3')
go
select * from Ticket