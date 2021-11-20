--Select
--ANSI standartı
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive = büyük küçük harf duyarsız
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by UnitPrice desc --ascending(artan) descending(düşen) --burada birim fiyatı düşüne göre sıralıyoruz

select * from Products where CategoryID=1  order by UnitPrice desc

Select count(*) from Products --Kaç tane ürün olduğunu sayıyor

Select count(*) Adet from Products where CategoryID=2 --ürünlerde kategoriıd si 2 olan kaç ürün var say göster adı da adet olsun

Select categoryId,count(*) from Products group by CategoryID --her kategorideki ürünlerin sayısını göstermme

Select categoryId,count(*) from Products group by CategoryID having COUNT(*)<10--ürün sayısı 10 dan az olan kategorileri listele

Select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10 
--önce her zaman where çalışır fiyatı 20 den fazla olan ürünleri kategoryıd ye göre grupla onlardanda sayısı o grupta 10 dan az olanları sayısı sırala demek
--havingi her zaman kümülatife uygularız.Count,sum, vs.

--Joın = tabloları birleştirmek
--İnner Join iki tabloladada sadece eşleşenleri bir araya getirir eşleşmeyen data varsa onu getirmez
--left join solda olup sağda olmayan, right join sağda olup solda olmayan
Select 
* from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName --hangi tablodan,hamngi kolon
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID --ben bunları listeledikten sonra kullanıcaya gidip foreachle dönerek listeliycem
where Products.UnitPrice>10

--C# ta DTO = Data Transformation object

Select * from Products p left join [Order Details] od -- order details tablosunun köşeli parantez içinde yazmasının sebebi aradaki boşluğu yanlış anlamasın dşye sql köşede yazıyor yazım hatasından kaynaklı tedbir alıyor
on p.ProductID = od.ProductID --p,od alias takma addır
---Burada left join solda olup(products) sağda olmayanları(order detais) getir demek

Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID --830(kolon sayısı) kişi sipariş veren müşteri

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID  --832(kolon sayısı) solda olup(müşteri) sağda olmayan(orders)

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null --sipariş vermeyen 2 müşteriyi göster bana --sağda olmayanlar null olarak gelir çünkü solda var sağda yok,nullar is le gösterilir --primary key customrıd nullu ona yollarız

--Birden fazla tabloyu join etmek
Select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID 

--Ödev
Select p.ProductName[Urun Adi], Sum(od.UnitPrice * od.Quantity) as ToplamKazanc
From Products p
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on od.OrderID = o.OrderID
Group by p.ProductName
Order by ToplamKazanc asc



