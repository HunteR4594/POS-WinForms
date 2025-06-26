---- SQL Query to create tables for the POS_project database in MySQL

---- Create Users table
--CREATE TABLE Users (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    Email VARCHAR(255) NOT NULL,
--    Username VARCHAR(255) NOT NULL,
--    Password VARCHAR(255) NOT NULL,
--    Role VARCHAR(255) NOT NULL,
--    Status VARCHAR(255) NOT NULL,
--    Date DATETIME NOT NULL,
--    IsDeleted BOOLEAN NOT NULL
--);

---- Create Categories table
--CREATE TABLE Categories (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    CategoryName VARCHAR(255) NOT NULL
--);

---- Create Products table
--CREATE TABLE Products (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    prod_id VARCHAR(255) NOT NULL,
--    prod_name VARCHAR(255) NOT NULL,
--    CategoryId INT NOT NULL,
--    category VARCHAR(255) NOT NULL, -- Redundant if CategoryId is used, but included as per model
--    prod_price DECIMAL(18,2) NOT NULL,
--    stock INT NOT NULL,
--    image_path VARCHAR(255) NOT NULL,
--    status VARCHAR(255) NOT NULL,
--    date_insert DATETIME NOT NULL,
--    barcode VARCHAR(255), -- Nullable
--    -- Foreign key to Categories table
--    CONSTRAINT FK_Products_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(id) ON DELETE RESTRICT
--);

---- Create Sales table (maps to CustomerOrderEntry)
--CREATE TABLE Sales (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    customer_id VARCHAR(255) NOT NULL,
--    CashierId INT NOT NULL,
--    total_price DECIMAL(18,2) NOT NULL,
--    amount DECIMAL(18,2) NOT NULL,
--    change DECIMAL(18,2) NOT NULL,
--    order_date DATETIME NOT NULL,
--    -- Foreign key to Users table (for Cashier)
--    CONSTRAINT FK_Sales_Users FOREIGN KEY (CashierId) REFERENCES Users(id) ON DELETE RESTRICT
--);

---- Create SaleItems table (maps to orders)
--CREATE TABLE SaleItems (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    SaleId INT NOT NULL,
--    ProdId VARCHAR(255) NOT NULL, -- Corresponds to product_id string, might be redundant with ProductId INT
--    ProductId INT NOT NULL,
--    ProdName VARCHAR(255) NOT NULL,
--    customer_id VARCHAR(255) NOT NULL,
--    category VARCHAR(255) NOT NULL,
--    Quantity INT NOT NULL,
--    OrigPrice DECIMAL(18,2) NOT NULL,
--    TotalPrice DECIMAL(18,2) NOT NULL,
--    order_date DATETIME NOT NULL,
--    -- Foreign key to Sales table
--    CONSTRAINT FK_SaleItems_Sales FOREIGN KEY (SaleId) REFERENCES Sales(id) ON DELETE RESTRICT,
--    -- Foreign key to Products table
--    CONSTRAINT FK_SaleItems_Products FOREIGN KEY (ProductId) REFERENCES Products(id) ON DELETE RESTRICT
--);

---- Create Customers table
--CREATE TABLE Customers (
--    id INT PRIMARY KEY AUTO_INCREMENT,
--    customer_id VARCHAR(255) NOT NULL,
--    prod_id VARCHAR(255) NOT NULL, -- This seems like a specific product associated with a customer, could be a Many-to-Many or a simple tracking field
--    total_price DECIMAL(18,2) NOT NULL,
--    amount DECIMAL(18,2) NOT NULL,
--    change DECIMAL(18,2) NOT NULL,
--    order_date DATETIME NOT NULL
--);

USE tryDB;
SELECT * FROM customers;