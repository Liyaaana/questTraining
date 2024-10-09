INSERT INTO courses (course_name, course_fee, student_id)
VALUES ('Math', 1000.00, 101),
       ('Science', 1200.00, 101),
       ('English', 800.00, 102),
       ('History', 900.00, 102),
       ('History', 900.00, 105);


SELECT course_name, COUNT(*) AS total_students
FROM courses
GROUP BY course_name;

SELECT course_name, SUM(course_fee) AS total_fees
FROM courses
GROUP BY course_name;

SELECT TOP 1 course_name, COUNT(*) AS total_students
FROM courses
GROUP BY course_name
ORDER BY total_students DESC;


