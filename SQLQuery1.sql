CREATE TABLE admin
(
	id INT PRIMARY KEY IDENTITY (1,1)
	, email VARCHAR(MAX) NULL
	, username VARCHAR(MAX) NULL
	, password VARCHAR(MAX) NULL
	, date_created DATE NULL
);

 

CREATE TABLE users 
(
	id int PRIMARY KEY IDENTITY(1,1)
	, username varchar(50) NOT NULL UNIQUE
	, password varchar(255) NOT NULL
	, role varchar(20) NOT NULL
	, status varchar(20) NOT NULL
	, date DATE NULL
	, IsDeleted BIT DEFAULT 0
);

 

CREATE TABLE categories 
(
	id int PRIMARY KEY IDENTITY(1,1)
	, category varchar(MAX) NULL
	, date DATE NULL
);

 

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1)
	, prod_id VARCHAR(MAX) NULL
	, prod_name VARCHAR(MAX) NULL	
	, category VARCHAR(MAX) NULL
	, prod_price DECIMAL(10,2) NULL
	, stock INT NULL
	, image_path VARCHAR(MAX) NULL
	, status VARCHAR(MAX) NULL
	, date_insert DATE NULL
);

 
