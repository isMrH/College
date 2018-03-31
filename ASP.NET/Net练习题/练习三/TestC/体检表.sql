create database HealthTypeItemDB
--�������
create table HealthTypeItem 
(
   ItemTypeld int primary key identity(1,1),
   ItemTypeName varchar(50),
)

insert into HealthTypeItem values('���')
insert into HealthTypeItem values('�ڿ�')
insert into HealthTypeItem values('�س���')
insert into HealthTypeItem values('�ۿ�')
insert into HealthTypeItem values('�ǿ�')

select * from HealthTypeItem
--����
create table HealthItemList
(
   ItemListld int primary key identity(1,1),
   ItemListName varchar(50),
   ItemTypeld int foreign key references HealthTypeItem(ItemTypeld),
   IsGood  bit,
   Standard varchar(50),
   Price money,
   Info varchar(100),
)

insert into HealthItemList values('���',1,1,'150-190','201','�����Ĳ�������')
insert into HealthItemList values('����',1,1,'50-90','20','�����Ĳ�������')
insert into HealthItemList values('Ѫѹ',2,1,'120-190','4','�����Ĳ�������')
insert into HealthItemList values('���',2,1,'����','201','�����Ĳ�������')
insert into HealthItemList values('���',2,0,'44','50','�����Ĳ�������')
select * from HealthItemList