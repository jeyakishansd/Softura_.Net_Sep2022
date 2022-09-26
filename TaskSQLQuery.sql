use AdventureWorks2019
go

select FirstName,LastName
from Person.Person
where title is not null

select FirstName,LastName
from Person.Person
where FirstName like '%a%' and lastname like '%a%'

select crc.CurrencyCode,c.Name
from Sales.Currency c,Sales.CountryRegionCurrency crc

create schema HR
go
select*into HR.dept from HumanResources.Department

create table Studentails
(
SNo int identity(1,1),
FirstName varchar(30),
LastName varchar(30),
DateOfJoining date,
Department varchar(30)
)
insert into Studentails values('Jeyakishan','S D','09/23/2016','Mech')
insert into Studentails values('Roopa Deepak','P J','09/22/2016','Mech')
insert into Studentails values('Sathish Kannaa','T S R','09/12/2016','Mech')
insert into Studentails values('Jayasurya','R','09/30/2016','Mech')
insert into Studentails values('Muthu Mani','B','09/25/2016','Mech')
insert into Studentails values('Prasanna Kumar','K G','09/13/2016','Mech')
insert into Studentails values('Raghavan Yougesh','S','09/23/2016','Mech')
insert into Studentails values('Prasath','M','09/12/2016','Mech')
insert into Studentails values('Suren Raj','S','09/03/2016','Mech')
insert into Studentails values('Srivathsan','P R','09/24/2016','IT')
insert into Studentails values('Gautham','R V','09/23/2016','ECE')
insert into Studentails values('Hari Vignesh','K K','09/23/2016','CSE')
insert into Studentails values('Aravind Akksan','V V','09/15/2016','IT')
insert into Studentails values('Sachin','L K','09/23/2016','ECE')
insert into Studentails values('Bharath','M','09/23/2016','IT')
insert into Studentails values('Karthikeyan','K K','09/23/2016','ECE')
insert into Studentails values('Abijith','K K','09/23/2016','CSE')
select*from Studentails

select buiseid.BusinessEntityID,buiseid.AddressTypeID
from Person.BusinessEntityAddress buiseid
inner join HumanResources.Department dept
on dept.ModifiedDate=buiseid.ModifiedDate

select distinct GroupName
from HumanResources.Department

select pch.StandardCost,sum(Pro.ListPrice+Pro.StandardCost) as
SumOfListPrice_SC
from Production.ProductCostHistory pch
join Production.product Pro
on pro.StandardCost=pch.StandardCost group by pch.StandardCost

select DATEDIFF(YEAR,StartDate,EndDate) as YearsOnRole
from HumanResources.EmployeeDepartmentHistory

select sum(SalesQuota+5000) as tot
from Sales.SalesPersonQuotaHistory
where SalesQuota>100000 group by SalesQuota order by SalesQuota asc

Select max(TaxRate) as MAX_TaxRate
from Sales.SalesTaxRate

select DepartmentID,e.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY,BirthDate,getdate())/365.25) as age
from HumanResources.Employee E
join HumanResources.EmployeeDepartmentHistory EDH ON
EDH.BusinessEntityID=E.BusinessEntityID

CREATE VIEW HumanResources.Name_age
as
select DepartmentID,e.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY,BirthDate,getdate())/365.25) as age
from HumanResources.Employee e
join HumanResources.EmployeeDepartmentHistory edh on
edh.BusinessEntityID=e.BusinessEntityID

select d.DepartmentID,max(eph.rate)Rate
from HumanResources.Department D
join HumanResources.EmployeeDepartmentHistory edh on
edh.DepartmentID=d.DepartmentID
join HumanResources.EmployeePayHistory eph on eph.BusinessEntityID=edh.BusinessEntityID
group by d.DepartmentID order by d.DepartmentID

select FirstName,MiddleName,Title,AddressTypeID,p.BusinessEntityID
from Person.Person p
left join Person.BusinessEntityAddress bea on p.BusinessEntityID=bea.BusinessEntityID
where p.Title is not null

select ProductID,LocationID,Shelf
from Production.ProductInventory 
where (ProductID between 300 and 350) and (LocationID=50) or (Shelf='E')

select pint.LocationID,Shelf,Name
from Production.ProductInventory pint
join Production.Location ploc
on
pint.LocationID=ploc.LocationID

select AddressID,AddressLine1,AddressLine2,stpro.StateProvinceID,StateProvinceCode,CountryRegionCode
from person.StateProvince stpro
join Person.Address padd
on 
stpro.StateProvinceID=padd.StateProvinceID

--select crc.CountryRegionCode,sum(soh.SubTotal+soh.TaxAmt) as Total
--from Sales.SalesOrderHeader soh
--inner join Sales.SalesTerritory st on 
--soh.TerritoryID=st.TerritoryID
--inner join sales.CountryRegionCurrency crc on 
--crc.CountryRegionCode=st.CountryRegionCode
--group by CurrencyCode