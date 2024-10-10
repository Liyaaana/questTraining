CREATE TABLE Suppliers (
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(100) NOT NULL,
    contact_person VARCHAR(100),
    phone VARCHAR(20),
    email VARCHAR(100) UNIQUE,
    address VARCHAR(255)
);

CREATE TABLE Medications (
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(100) NOT NULL,
    category VARCHAR(50),
    price DECIMAL(10,2) NOT NULL CHECK (price >= 0),
    expiry_date DATE,
    supplier_id INT,
    stock_quantity INT DEFAULT 0 CHECK (stock_quantity >= 0),
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(id)
);

CREATE TABLE Customers (
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(100) UNIQUE,
    address VARCHAR(255)
);

CREATE TABLE Sales (
    id INT PRIMARY KEY IDENTITY,
    customer_id INT,
    medication_id INT,
    quantity INT NOT NULL CHECK (quantity > 0),
    sale_date DATETIME DEFAULT GETDATE(),
    total_price DECIMAL(10,2) NOT NULL CHECK (total_price >= 0),
    FOREIGN KEY (customer_id) REFERENCES Customers(id),
    FOREIGN KEY (medication_id) REFERENCES Medications(id)
);

CREATE TABLE Inventory (
    id INT PRIMARY KEY IDENTITY,
    medication_id INT,
    supplier_id INT,
    stock_in INT DEFAULT 0 CHECK (stock_in >= 0),
    stock_out INT DEFAULT 0 CHECK (stock_out >= 0),
    date_added DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (medication_id) REFERENCES Medications(id),
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(id)
);

