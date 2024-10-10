CREATE PROCEDURE sp_CreateCustomer 
	@Name VARCHAR(100) NOT NULL, 
	@Email VARCHAR(100) NOT NULL, 
	@Phone VARCHAR(15) NOT NULL, 
	@Address VARCHAR(250) NULL
AS
BEGIN
INSERT INTO customers (name, email, phone, address) VALUES (@Name, @Email, @Phone, @Address);
END

EXEC sp_CreateCustomer @Name = 'John Doe', @gmail = 'johndoe@gmail.com', @Phone = '12345678', @Address = null;
