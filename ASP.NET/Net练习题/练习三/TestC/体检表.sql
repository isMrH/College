create database HealthTypeItemDB
--体检类别表
create table HealthTypeItem 
(
   ItemTypeld int primary key identity(1,1),
   ItemTypeName varchar(50),
)

insert into HealthTypeItem values('外科')
insert into HealthTypeItem values('内科')
insert into HealthTypeItem values('肛肠科')
insert into HealthTypeItem values('眼科')
insert into HealthTypeItem values('骨科')

select * from HealthTypeItem
--体检表
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

insert into HealthItemList values('身高',1,1,'150-190','201','美国的测试仪器')
insert into HealthItemList values('体重',1,1,'50-90','20','国产的测试仪器')
insert into HealthItemList values('血压',2,1,'120-190','4','美国的测试仪器')
insert into HealthItemList values('嗅觉',2,1,'——','201','美国的测试仪器')
insert into HealthItemList values('身高',2,0,'44','50','美国的测试仪器')
select * from HealthItemList