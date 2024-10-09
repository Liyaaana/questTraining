CREATE TABLE orders(
	id BIGINT PRIMARY KEY IDENTITY,
	quantity INT NOT NULL DEFAULT 1,
	product_id BIGINT NOT NULL,
	user_id BIGINT NOT NULL

	CONSTRAINT FK_orders_product_id
	FOREIGN KEY (product_id) REFERENCES products(id),
	-- product_id column (Orders table) named as FK_orders_product_id is the foreign key that references the id column in the products table.


	CONSTRAINT FK_orders_user_id
	FOREIGN KEY (user_id) REFERENCES users(id)

)
INSERT INTO orders VALUES(1, 2, 1)
INSERT INTO orders VALUES(1, 2, 3);