INSERT INTO students(name, email, class) VALUES
('David Wilson', 'david.wilson@example.com', 1),
('Laura Moore', 'laura.moore@example.com', 3), 
('James Taylor', 'james.taylor@example.com', 2),
('Olivia Anderson', 'olivia.anderson@example.com', 1);

SELECT * FROM students;
SELECT id, name, email from students;
SELECT id, name FROM students WHERE id = 1;
SELECT id, name FROM students WHERE email = 'laura.moore@example.com';

SELECT id, name, class FROM students WHERE id >=1 and id <=5;
SELECT id, name, class FROM students WHERE id BETWEEN 1 AND 5;

SELECT id, name, class FROM students WHERE class = 1 OR class = 3;
SELECT id, name, class FROM students WHERE class IN (1,3);

SELECT id, name, class FROM students ORDER BY NAME ASC;
SELECT id, name, class FROM students ORDER BY NAME DESC;

-- GROUP BY shows how many members in the group and it always comes with condition, otherwise shows error
SELECT class, COUNT(id) FROM students GROUP BY class;
SELECT class, COUNT(id) AS count_of_students FROM students GROUP BY class;

-- HAVING always comes with GROUP BY ,not WHERE 
SELECT class, COUNT(id) AS count FROM students GROUP BY class HAVING count(id) < 5;

-- TOP 5 associated with Microsoft SQL Server.
SELECT TOP 5 id, name, class FROM students;

-- It first skips the first 5 rows, then it fetches the next 3 rows.
-- This works in MySQL, PostgreSQL, SQLite.
SELECT id, name, class FROM students
	ORDER BY id
	OFFSET 5 ROWS
	FETCH NEXT 3 ROWS ONLY;

SELECT LEN('Hello');
SELECT name, LEN(name) as name_length FROM students;

-- AGGREGATE FUNCTIONS
SELECT COUNT(id) AS total_students FROM students;
SELECT SUM(class) AS sum_of_classes FROM students;
SELECT MIN(class) AS min_of_classes FROM students;
SELECT MAX(class) AS max_of_classes FROM students;
SELECT AVG(class) AS avg_of_classes FROM students;







