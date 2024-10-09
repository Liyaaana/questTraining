-- INNER JOIN 
SELECT
	orders.id as order_id,
	products.id as product_id,
	products.name,
	products.price,
	users.first_name,
	users.last_name
FROM
orders
INNER JOIN 
products
ON orders.product_id = products.id;

-- LEFT JOIN
SELECT
	orders.id as order_id,
	products.id as product_id,
	products.name,
	products.price
FROM
orders
LEFT JOIN 
products
ON orders.product_id = products.id;

-- RIGHT JOIN
SELECT
	orders.id as order_id,
	products.id as product_id,
	products.name,
	products.price
FROM
orders
RIGHT JOIN 
products
ON orders.product_id = products.id
INNER JOIN users
ON orders.user_id = users.id;