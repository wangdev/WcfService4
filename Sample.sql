
CREATE DATABASE Sample;
USE Sample;

CREATE TABLE Employee
(
	Id			INT,
	Name		NVARCHAR(50),
	Gender		NVARCHAR(50),
	DateOfBirth DATETIME,
	CONSTRAINT PK_Employee PRIMARY KEY(Id)
);

INSERT INTO Employee VALUES (1, 'Mark',    'Male', '12/27/1991');
INSERT INTO Employee VALUES (2, 'Luke',    'Male', '09/10/1990');
INSERT INTO Employee VALUES (3, 'Michael', 'Male', '07/26/1988');

CREATE PROCEDURE GetEmployee 
@Id INT
AS
BEGIN
	SELECT Id, Name, Gender, DateOfBirth
	FROM Employee
	WHERE @ID = ID
END

CREATE PROCEDURE SaveEmployee
@Id INT,
@Name NVARCHAR(50),
@Gender NVARCHAR(50),
@DateOfBirth DATETIME
AS
BEGIN
	INSERT INTO Employee
	VALUES (@Id, @Name, @Gender, @DateOfBirth)
END
	

