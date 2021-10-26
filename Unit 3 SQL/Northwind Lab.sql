--SELECT * FROM Customers;

--SELECT Distinct Country FROM Customers;

--SELECT * FROM Customers
--WHERE CustomerID LIKE 'Bl%';

--SELECT TOP 100 * FROM Orders;

--SELECT * FROM Customers
--WHERE PostalCode = '1010' OR PostalCode = '3012' OR PostalCode = '12209' OR PostalCode = '05023';

--SELECT * FROM Orders
--WHERE ShipRegion IS NOT NULL;

--SELECT * FROM Customers
--ORDER BY Country, City;

--INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, [Address], City, Region, PostalCode, Country, Phone, Fax)
--Values ('JEO', 'Jeos borgors', 'Justin', 'GC STAFF', '1234 Circus lane', 'ClownTown','MD','12345', 'The Internet', '123-456-7890', null);

--UPDATE Orders
--set ShipRegion = 'EuroZone'
--Where ShipCountry = 'France';

--DELETE [Order Details]
--WHERE Quantity = 1;

--SELECT AVG(Quantity) AS 'AVG', MAX(Quantity) AS 'MAX', MIN(Quantity)  AS 'MIN' FROM [Order Details]
--GROUP BY OrderID;

--SELECT CustomerID FROM Orders
--WHERE OrderID = 10290

--SELECT * FROM Orders
--INNER JOIN Customers 
--ON Orders.CustomerID = Customers.CustomerID;

--SELECT * FROM Orders
--LEFT JOIN Customers 
--ON Orders.CustomerID = Customers.CustomerID;

--SELECT * FROM Orders
--RIGHT JOIN Customers 
--ON Orders.CustomerID = Customers.CustomerID;

--SELECT FirstName FROM Employees
--WHERE ReportsTo IS NULL;

--SELECT FirstName FROM Employees
--WHERE ReportsTo = 2;
