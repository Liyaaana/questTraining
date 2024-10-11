CREATE PROCEDURE AddMedication(
    @name VARCHAR(100),
    @category VARCHAR(50),
    @price DECIMAL(10, 2),
    @expiry_date DATE,
    @supplier_id INT,
    @stock_quantity INT
)
AS
BEGIN
    INSERT INTO Medications (name, category, price, expiry_date, supplier_id, stock_quantity)
    VALUES (@name, @category, @price, @expiry_date, @supplier_id, @stock_quantity);
END;

EXEC AddMedication 
    @name = 'Paracetamol', 
    @category = 'Pain Relief', 
    @price = 2.50, 
    @expiry_date = '2025-12-31', 
    @supplier_id = 1, 
    @stock_quantity = 100;

--Update Operation
UPDATE Medications
SET stock_quantity = stock_quantity + 50
WHERE name = 'Paracetamol';

--Join Operations 
--Write a JOIN query to list all medications and their corresponding supplier names.
SELECT Medications.name AS Medication_Name, Suppliers.name AS Supplier_Name
FROM Medications
JOIN Suppliers ON Medications.supplier_id = Suppliers.id;

--Write a query to display the sales data, including the medication name, customer name, and the total amount of the sale.
SELECT Sales.id, Customers.name AS Customer_Name, Medications.name AS Medication_Name, Sales.total_price
FROM Sales
JOIN Customers ON Sales.customer_id = Customers.id
JOIN Medications ON Sales.medication_id = Medications.id;
