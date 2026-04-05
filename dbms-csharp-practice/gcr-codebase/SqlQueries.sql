/*DDL-Data Definition Language : create,alter,truncate,drop
Syntax:
CREATE- create table Table_Name(column DataType keyType)
DROP- drop table Table_Name
ALTER- Alter Table Table_Name Add Column_Name 
TRUNCATE- Truncate Table Table_Name  (removes the rows from the table )
*/

CREATE TABLE Students
(
    StudentsId INT PRIMARY KEY,
    StudentsName VARCHAR(50),
    StudentRollNo INT
);

CREATE TABLE Teachers
(
    TeachersId INT PRIMARY KEY,
    TeacherName VARCHAR(50)
);

ALTER TABLE Teachers ADD SubjectName VARCHAR(50);

TRUNCATE TABLE Teachers;

DROP TABLE Teachers;



/*DML-Data Manipulation Language : insert,delete,update,select
Syntax:
INSERT- INSERT INTO Table_Name VALUES()
SELECT- SELECT column FROM Table_Name
UPDATE- UPDATE Table_Name SET column=value WHERE condition
DELETE- DELETE FROM Table_Name WHERE condition
*/

INSERT INTO Students VALUES (1, 'Rahul', 101);
INSERT INTO Students VALUES (2, 'Anita', 102);

SELECT * FROM Students;

UPDATE Students
SET StudentsName = 'Rahul Sharma'
WHERE StudentsId = 1;

DELETE FROM Students
WHERE StudentsId = 2;


go
/*DCL-Data Control Language : grant,revoke
Syntax:
GRANT- GRANT permission ON object TO user
REVOKE- REVOKE permission ON object FROM user
*/

GRANT SELECT, INSERT
ON Students
TO user1;

REVOKE INSERT
ON Students
FROM user1;



/*TCL-Transaction Control Language : commit,rollback,savepoint
Syntax:
COMMIT- save changes permanently
ROLLBACK- undo changes
SAVEPOINT- create point to rollback
*/

SAVE TRANSACTION sp1;

INSERT INTO Students VALUES (3, 'Kiran', 103);

ROLLBACK TRANSACTION sp1;

COMMIT;

go

--JOINS
-- Sample Tables
CREATE TABLE Departments
(
    DeptId INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Employees
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    DeptId INT
);

INSERT INTO Departments VALUES (1, 'IT'), (2, 'HR');
INSERT INTO Employees VALUES (101, 'Rahul', 1), (102, 'Anita', 2), (103, 'Kiran', NULL);



/*INNER JOIN
Returns records that have matching values in both tables
*/

SELECT Employees.EmpId, Employees.EmpName, Departments.DeptName
FROM Employees
INNER JOIN Departments
ON Employees.DeptId = Departments.DeptId;



/*LEFT JOIN
Returns all records from left table and matching records from right table
*/

SELECT Employees.EmpId, Employees.EmpName, Departments.DeptName
FROM Employees
LEFT JOIN Departments
ON Employees.DeptId = Departments.DeptId;



/*RIGHT JOIN
Returns all records from right table and matching records from left table
*/

SELECT Employees.EmpId, Employees.EmpName, Departments.DeptName
FROM Employees
RIGHT JOIN Departments
ON Employees.DeptId = Departments.DeptId;



/*FULL JOIN
Returns all records when there is a match in either table
*/

SELECT Employees.EmpId, Employees.EmpName, Departments.DeptName
FROM Employees
FULL JOIN Departments
ON Employees.DeptId = Departments.DeptId;



/*SUBQUERIES
A subquery is a query inside another query
*/

-- Single Row Subquery
SELECT EmpName
FROM Employees
WHERE DeptId =
(
    SELECT DeptId
    FROM Departments
    WHERE DeptName = 'IT'
);



-- Multiple Row Subquery
SELECT EmpName
FROM Employees
WHERE DeptId IN
(
    SELECT DeptId
    FROM Departments
);



-- Subquery with EXISTS
SELECT DeptName
FROM Departments D
WHERE EXISTS
(
    SELECT 1
    FROM Employees E
    WHERE E.DeptId = D.DeptId
);



/*Correlated Subquery
Subquery depends on outer query
*/

SELECT EmpName
FROM Employees E
WHERE DeptId =
(
    SELECT DeptId
    FROM Departments D
    WHERE D.DeptId = E.DeptId
);

go
/*Stored Procedures
Syntax:
CREATE PROCEDURE procedure_name
AS
BEGIN
SQL statements
END
*/

CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;

EXEC GetAllStudents;

go
/*Stored Procedure with Parameter
Syntax:
CREATE PROCEDURE procedure_name(parameter datatype)
*/

CREATE PROCEDURE GetStudentById
    @StudentId INT
AS
BEGIN
    SELECT * FROM Students
    WHERE StudentsId = @StudentId;
END;

EXEC GetStudentById 1;
go