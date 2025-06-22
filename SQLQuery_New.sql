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

CREATE TABLE Categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Products (
    id INT PRIMARY KEY IDENTITY(1,1),
    prod_id VARCHAR(50) NOT NULL UNIQUE,
    prod_name VARCHAR(255) NOT NULL,
    category VARCHAR(50) NOT NULL,
    prod_price DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    image_path VARCHAR(255) NOT NULL,
    status VARCHAR(50) NOT NULL,
    date_insert DATETIME NOT NULL
);

CREATE TABLE Sales (
    id INT PRIMARY KEY IDENTITY(1,1),
    SaleDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);
