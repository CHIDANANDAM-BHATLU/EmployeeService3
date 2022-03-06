CREATE TABLE Employees
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     Salary int
)
GO
INSERT INTO Employees VALUES ('RAVI', 'TEJA', 'Male', 20000)
INSERT INTO Employees VALUES ('SUNDAR', 'MEHATA', 'Male', 15000)
INSERT INTO Employees VALUES ('PRIYA', 'TYAGI', 'Female', 17500)
INSERT INTO Employees VALUES ('ABISHEK', 'SHARMA', 'Male',24400)
INSERT INTO Employees VALUES ('TILAK', 'VARMA', 'Male', 32000)
INSERT INTO Employees VALUES ('JAHNAVI', 'REDDY', 'Female', 16000)
INSERT INTO Employees VALUES ('BALU', 'MAHENDRA', 'Male', 21000)
INSERT INTO Employees VALUES('DAYA', 'NAYAK', 'Male', 16000)
INSERT INTO Employees VALUES ('HEERA', 'KANTH', 'Female', 21000)
INSERT INTO Employees VALUES ('SAI', 'KRISHNA', 'Male', 36000)
GO