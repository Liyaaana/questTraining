CREATE TABLE students(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	email VARCHAR(100) UNIQUE NOT NULL,
	class INT DEFAULT 1
)
-- IDENTITY property is used to automatically generate unique integer values for the id column.