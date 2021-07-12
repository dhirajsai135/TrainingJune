select @@version
select * from sys.databases

select * from sys.tables

select * from person.Person

select * from person.person where Title='Ms.'

select * from person.Person Title LIKE 'M%'

select * from Production.Product where Color is not null

update Production.Product set Color=null where Color='Multi'

select * from Production.Product

select (case when color is null then 'multi' else Color end) as color from Production.product

select * from Sales.Currency

--Task

--1

select Title,FirstName,LastName from person.Person where Title is not null

--2
select FirstName,LastName from person.Person where FirstName like '%a%' and LastName like '%a%'

--3
select CurrencyCode,name from Sales.Currency,Sales.CountryRegionCurrency 
