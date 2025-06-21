drop table categories


CREATE TABLE Categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL UNIQUE
);
