create database studb
go
use studb
go
create table FriendType
(
   fid int identity(1,1) primary key,
   typename nvarchar(10)
)
go

insert into friendtype values('朋友')
insert into friendtype values('家人')
insert into friendtype values('同学')

create table Friends
(
   id int identity(1,1) primary key,
   name nvarchar(20),
   fid int foreign key references friendtype(fid),
   tel nvarchar(20) not null default '',
   email nvarchar(50) not null default '',
   address nvarchar(100) not null default ''
)

insert into friends(name,fid) values('zhangsan',1)
insert into friends(name,fid) values('lisi',1)
insert into friends(name,fid) values('wangwu',1)

insert into friends(name,fid) values('tom',2)
insert into friends(name,fid) values('jack',2)

