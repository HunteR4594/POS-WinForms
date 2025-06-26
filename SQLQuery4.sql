USE tryDB; -- Ensure you are using your database

-- Insert Admin User
INSERT INTO [Users] (Email, Username, Password, Role, Status, Date, IsDeleted)
VALUES
('admin@example.com', 'admin12345', 'admin12345', 'Admin', 'Active', GETDATE(), 0);

-- Insert Cashier User
INSERT INTO [Users] (Email, Username, Password, Role, Status, Date, IsDeleted)
VALUES
('cashier@example.com', 'cashier1', 'cashier1', 'Cashier', 'Active', GETDATE(), 0);