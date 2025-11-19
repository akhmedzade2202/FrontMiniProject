CREATE DATABASE Market
USE Market

CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);

ALTER TABLE Products
ADD Brand NVARCHAR(100) NOT NULL

INSERT INTO Products (Name, Price, Brand) VALUES
('Laptop', 1200, 'Dell'),
('Mouse', 15, 'Logitech'),
('Keyboard', 35, 'A4Tech'),
('Monitor', 250, 'Samsung'),
('Headset', 55, 'Razer'),
('USB Cable', 6, 'UGreen'),
('Microphone', 120, 'HyperX'),
('Flash Drive', 12, 'SanDisk'),
('Webcam', 80, 'Logitech'),
('Speaker', 45, 'Sony'),
('Router', 90, 'TPLink'),
('Tablet', 350, 'Samsung'),
('SSD', 140, 'Kingston'),
('PowerBank', 35, 'Xiaomi'),
('Phone', 700, 'Apple')

UPDATE Products
SET Price = 60
WHERE Name = 'Mouse'

UPDATE Products
SET Brand = 'Dell Pro'
WHERE Name = 'Laptop'

DELETE FROM Products
WHERE Name = 'USB Cable'

DELETE FROM Products
WHERE Price < 10

SELECT * FROM Products
WHERE Price < (SELECT AVG(Price) FROM Products)

SELECT * FROM Products
WHERE Price>10


CREATE TABLE Employee
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Fullname NVARCHAR(255) NOT NULL,
    Age INT NOT NULL CHECK (Age >= 0),
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Salary DECIMAL(18,2) NOT NULL CHECK (Salary BETWEEN 300 AND 2000)
)

INSERT INTO Employee (Fullname, Age, Email, Salary) VALUES
('Emrah AKhmdedzade', 25, 'akif@gmail.com', 1500),
('SD MD', 20, 'sd@gmail.com', 1800),
('Aysen Akhmedzade', 22, 'aysen@gmail.com', 1200),
('Rauf Karimov', 27, 'rauf@gmail.com', 900)

SELECT * FROM Employee

INSERT INTO Employee (Fullname, Age, Email, Salary) VALUES
('Salam Salamli', 20, 'salam@gmail.com', 1000)

UPDATE Employee
SET Salary = 1600
WHERE Email = 'samir@gmail.com'

DELETE FROM Employee
WHERE Email = 'salam@gmail.com'

SELECT * FROM Employee


