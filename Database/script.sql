create database BCOM
go
use BCOM
go

create table Customer
(
Id int IDENTITY(1,1) PRIMARY KEY,
CustomerName varchar(30),
LastName varchar(30),
Dni int
)
go

create table CustomerTransaction
(
Id int IDENTITY(1,1) PRIMARY KEY,
IdCustomer int not null,
TransactionStatus bit,
TransactionDate datetime,
FOREIGN KEY (IdCustomer) REFERENCES Customer(Id),
)
go


