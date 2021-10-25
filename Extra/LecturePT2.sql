--CREATE TABLE Class (
--	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	title NVARCHAR(255)
--);

--INSERT INTO Class (title)
--VALUES ('.NET'),
--('Java'),
--('Front-End');

--SELECT * FROM Class;

--Left in because i made a mistake
--DROP TABLE Class;

--CREATE TABLE Student (
--	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	[Name] NVARCHAR(255),
--	class_id int FOREIGN KEY REFERENCES Class(id)
--)

--INSERT INTO Student ([Name], class_id)
--VALUES ('G. Washington', 1),
--('M. Gandhi', 1),
--('N. Mandela', NULL),
--('Q. Victoria', 2);

--SELECT * FROM Student;

--SELECT * FROM Student
--JOIN Class ON Student.class_id = Class.id;

--SELECT * FROM Student
--LEFT JOIN Class ON Student.class_id = Class.id;

--SELECT * FROM STUDENT
--RIGHT JOIN Class ON Student.class_id = Class.id;

--SELECT * FROM STUDENT
--FULL JOIN Class ON Student.class_id = Class.id;

--SELECT * FROM Student
--CROSS JOIN Class

SELECT Student.id, Student.[Name] FROM Student
Join Class ON Student.class_id = Class.id
WHERE Class.title = '.NET' 
ORDER BY Student.Name;