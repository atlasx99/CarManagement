create database carmanagement
go

use carmanagement
go

create table cars
(
    carid int primary key identity(1,1),
	carbrand nvarchar(200) not null,
	carversion nvarchar(50) not null,
	platenumber nvarchar(50) not null
)
go