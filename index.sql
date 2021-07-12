create database afterTraining

create table E_details
(Id int identity(8600,10) primary key,
FirstName varchar(20) not null,
LastName varchar(20) not null,
Age int,
Gender char(10))

insert into E_details values
('Dheeraj','Gandrakota',21,'Male'),
('Venkat','Gandrakota',24,'Male'),
('Phani','Gandrakota',23,'Male'),
('sai','Vaddamani',25,'Male'),
('PhaniKiran','Vaddamani',29,'Male'),
('Vemanth','Madineni',21,'Male')

select * from E_details

--Creating Index for Firstname and ID

create index idx_FirstNameID on E_details (FirstName,Id)

--creating non-clustured Index

create nonclustered index NonIndx_LastNameId on E_details(LastName,Id)