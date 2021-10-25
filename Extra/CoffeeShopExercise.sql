--CREATE TABLE Coffee (
--	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	[Name] NVARCHAR(255),
--	Price Float,
--	Flavored Bit
--);

--INSERT INTO Coffee ([Name], Price, Flavored)
--VALUES ('Black Coffee', 1.00, 0),
--('Carmel Latte', 4.00, 1),
--('Frozen Mocha Latte', 5.50, 1),
--('Peppermint Latte', 4.50, 1),
--('Black Coffee with Cream', 1.50, 0);

--SELECT * FROM Coffee;

--SELECT * FROM Coffee
--WHERE Flavored = 1;

--SELECT * FROM Coffee
--Where Price > 3;

--SELECT MAX(Price) From Coffee;

--SELECT AVG(Price) FROM Coffee;

--SELECT SUM(Price) FROM Coffee;

--SELECT MAX(Price) AS 'Max Price', AVG(Price) AS 'Average Price', SUM(Price) AS 'Total cost' FROM Coffee

--Part 2

--CREATE TABLE Customer (
--	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--	[Name] NVARCHAR(255),
--	FavDrink int FOREIGN KEY REFERENCES Coffee(ID)
--);

--INSERT INTO Customer ([Name], FavDrink)
--VALUES ('Shaggy', 1),
--('Fred', 2),
--('Velma', 3),
--('Daphne', 4),
--('Scooby', 5),
--('Spongebob', 2),
--('Aang', 3),
--('Ed', 1),
--('Edd', 3),
--('Eddy',5);

--SELECT * FROM Customer;

--SELECT * FROM Customer
--ORDER BY [Name] ASC;

--SELECT * From Customer
--INNER JOIN Coffee On Customer.FavDrink = Coffee.ID;

--SELECT * From Customer
--INNER JOIN Coffee On Customer.FavDrink = Coffee.ID
--WHERE FavDrink = 1;

--UPDATE Customer
--SET FavDrink = 1
--WHERE ID = 10;

--SELECT * From Customer
--INNER JOIN Coffee On Customer.FavDrink = Coffee.ID
--WHERE FavDrink > 2;

--DELETE FROM Customer
--WHERE ID = 10;