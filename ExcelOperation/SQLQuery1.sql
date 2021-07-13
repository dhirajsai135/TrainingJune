create database Excel

use Excel

create table ExcelExport
(Id int identity(8600,10),
Name varchar(30),
Gender Char(20),
Age int )

ALTER TABLE ExcelExport
ADD PRIMARY KEY (Id);

select * from ExcelExport

create table ExcelImport
(Id int identity(1000,30) primary key,
Name varchar(30),
Gender Char(20),
Age int )

select * from ExcelImport