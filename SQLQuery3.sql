CREATE TABLE CustomerOrderEntry
(
	id INT PRIMARY KEY IDENTITY(1,1),
	 customer_id VARCHAR(100) NOT NULL,
	prod_id VARCHAR(100) NOT NULL,
	total_price DATETIME NOT NULL,
	amount DECIMAL(10, 2) NOT NULL,
	change DECIMAL(10, 2) NOT NULL,
	order_date DATETIME NOT NULL,
)

SELECT * FROM CustomerOrderEntry;