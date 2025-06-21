CREATE TABLE Sales (
    id INT PRIMARY KEY IDENTITY(1,1),
    SaleDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);

DROP TABLE users

CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    Email VARCHAR(255) NOT NULL UNIQUE,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Status VARCHAR(50) NOT NULL,
    Date DATETIME NOT NULL,
    IsDeleted BIT NOT NULL DEFAULT 0
);


INSERT INTO Users (Email, Username, Password, Role, Status, Date)
VALUES ('Cashier1@example.com', 'Cashier1', '123456', 'Cashier', 'Active', '2025-06-19');

INSERT INTO Users (Email, Username, Password, Role, Status, Date)
VALUES ('Admin1@example.com', 'Admin1', '123456', 'Admin', 'Active', '2025-06-19');

Select * from products