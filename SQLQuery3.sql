create database BookDB
go

use BookDB

--Book-BookId,Title,AuthorId,Price
--Author-AuthorId,AuthorName

create table tbl_author(
AuthorId int identity(1,1),
AuthorName varchar(20),
constraint Pk_auth primary key(AuthorId))

create table tbl_Book(
BookId int identity(1000,1),
BookTitle varchar(100),
AuthorId int,
BookPrice Money,
constraint Pk_Book primary key(BookId),
constraint Fk_Auth foreign key(AuthorId) references tbl_Author(AuthorId))

insert into tbl_author values('George RR Martin'),('J.K Rowling'),('William shakesphere')
select * from tbl_author
select * from tbl_Book

insert into tbl_Book values('Game of Thrones',1,1400.00)
insert into tbl_Book values('Harry Potter',2,900.00),('Romeo and Juliet',1,500.00)
insert into tbl_author values('R.K Narayan')