--CREATE TABLE tutorials_tbl (
--	tutorial_id int NOT NULL IDENTITY(1,1),
--	tutorial_title NVARCHAR(100) NOT NULL,
--	tutorial_author NVARCHAR(40) NOT NULL,
--	submission_date DATE,
--	PRIMARY KEY (tutorial_id)
--);

--DROP TABLE tutorials_tbl;

--CREATE TABLE marvel_heroes (
--	ID int NOT NULL IDENTITY(1,1),
--	[Name] NVARCHAR(50), 
--	Superpower NVARCHAR(50)
--);

--INSERT INTO marvel_heroes([Name], Superpower)
--VALUES ('Hulk', 'Super Strength'),
--('Iron Man', 'Intelligence'),
--('Thor', 'Lightning');

--SELECT [Name] FROM marvel_heroes;
--SELECT Superpower FROM marvel_heroes;

--SELECT ID, [Name], Superpower FROM marvel_heroes;
--SELECT * FROM marvel_heroes;

--SELECT * FROM marvel_heroes
--WHERE [name] = 'Hulk' OR Superpower = 'Lightning';

--CREATE TABLE Salaries(
--	ID int NOT NULL IDENTITY(1,1),
--	Salary Float,
--	PRIMARY KEY (ID)
--)

--INSERT INTO Salaries (Salary)
--VALUES (500000),
--(10000000),
--(3)

--SELECT * FROM Salaries
--ORDER BY Salary ASC;

--INSERT INTO marvel_heroes ([Name], Superpower)
--VALUES ('Spiderman', 'Mouthing off'),
--('Spiderman', 'Mouthing off'),
--('Spiderman', 'Mouthing off'),
--('Spiderman', 'Mouthing off'),
--('Spiderman', 'Mouthing off');

--SELECT * FROM marvel_heroes;

--UPDATE marvel_heroes 
--SET Superpower = 'Web Slinging'
--WHERE [Name] = 'Spiderman';

--DELETE FROM marvel_heroes
--WHERE [Name] = 'Spiderman';

--INSERT INTO marvel_heroes ([Name], Superpower)
--VALUES ('Spiderman', 'Web Slinging');

--ALTER TABLE marvel_heroes
--ADD Realname NVARCHAR(50);


--UPDATE marvel_heroes
--SET Realname = 'Peter Parker'
--Where [Name] = 'Spiderman';

--SELECT * FROM marvel_heroes

--CREATE TABLE Tickets (
--	id int NOT NULL IDENTITY(1,1) Primary KEY,
--	seat NVARCHAR(255),
--	price Float,
--	num_sold int
--)

--INSERT INTO Tickets (seat, price, num_sold)
--VALUES ('Box Level', 105, 4),
--('Dress Circle', 75, 2),
--('Main Floor', 58, 10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19, 3);

--SELECT COUNT(*) FROM Tickets;

--SELECT COUNT(*) FROM Tickets
--WHERE num_sold <> 0;

--SELECT SUM(num_sold) FROM Tickets;

--SELECT AVG(price) FROM Tickets;

--SELECT MAX(num_sold) FROM Tickets;

--SELECT MIN(price) FROM Tickets;

SELECT SUM(num_sold) AS 'Total Sold', SUM(price * num_sold) AS 'Total Revenue'
From Tickets;