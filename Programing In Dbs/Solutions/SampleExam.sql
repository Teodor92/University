use northwind

-- 1.

create table SeafoodSales(
	ProductID int primary key,
	ProductName nvarchar(40),
	TotalQuantity int,
	AvgPrice money
);

go

-- 2.
insert into SeafoodSales
select p.ProductID, p.ProductName, sum(od.Quantity), avg(od.UnitPrice) from Products p 
join [Order Details] od on p.ProductID = od.ProductID
where p.CategoryID = 8
group by p.ProductID, p.ProductName

go

-- 3.

alter table SeafoodSales
add Price money not null
default 0

-- 4.

update SeafoodSales
set Price = i.UnitPrice
from (select p.ProductID, p.UnitPrice From Products p) i
where SeafoodSales.ProductId = i.ProductID


-- 5.

delete from SeafoodSales
where Price < 10

go
-- 6.

drop table SeafoodSales

go

-- 7.

CREATE VIEW ProductsView
AS
select p.ProductID, p.ProductName, c.CategoryName, s.CompanyName, s.Country from Products p
join Categories c on p.CategoryID = c.CategoryID
join Suppliers s on p.SupplierID = s.SupplierID

go


-- 8. -- buggy?

SELECT pv.ProductName, pv.CompanyName, pv.Country, SUM(od.Quantity) as QuantitySum from ProductsView pv, [Order Details] od
where pv.Country in ('Spain', 'France', 'Italy')
group by pv.ProductName, pv.CompanyName, pv.Country
order by pv.ProductName

go
-- 9.

drop view ProductsView

go

-- 10.
create function dbo.Sum_Product_Sales(@ProductId int)
returns money
as 
begin
	declare @money_sum money
	select @money_sum = sum(cast(UnitPrice*UnitsInStock as money)) from Products p where ProductID = @ProductId

	if @money_sum is null
		set @money_sum = 0
	return @money_sum
end

select dbo.Sum_Product_Sales(1) as unitPrice

-- 11.




-- 14.
drop function dbo.Sum_Product_Sales