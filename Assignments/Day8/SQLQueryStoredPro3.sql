CREATE PROCEDURE AddSupplier (
    @name VARCHAR(50),
    @contact_person VARCHAR(50),
    @phone_no VARCHAR(10),
    @email VARCHAR(50),
    @address VARCHAR(50)
)
AS
BEGIN
    INSERT INTO Suppliers (name, contact_person, phone_no, email, address)
    VALUES (@name, @contact_person, @phone_no, @email, @address);
END;

EXEC AddSupplier 
    @name = 'HealthCorp', 
    @contact_person = 'Jane Smith', 
    @phone_no = '1234567890', 
    @email = 'info@healthcorp.com', 
    @address = '123 Health Street';