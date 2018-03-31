create database MyShop
go
use MyShop
go
create table GoodsInfo
(
	Id int primary key,
	GoodsName varchar(500),
	GoodsPrice float,
	GoodsCount int,
	Company varchar(500)
)