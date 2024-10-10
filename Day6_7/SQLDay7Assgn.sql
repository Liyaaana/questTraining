
CREATE TABLE STUDENT(
    id bigint primary key identity,
    name varchar(50) not null
 );
 CREATE TABLE SUBJECT(
    id bigint primary key identity(100,1),
    name varchar(50) not null unique,
    code VARCHAR(10) not null unique 
   );
 create table exam(
    id bigint primary key identity(200,1),
    name varchar(50) not null,
    min_mark int not null default 40,
    max_mark int not null default 100
  );
 create table marks(
    id bigint primary key identity,
    mark int not null,
    student_id bigint,
    subject_id bigint,
    exam_id bigint,

 constraint fk_student_id foreign key(student_id) references student(id),
 constraint fk_subject_id foreign key(subject_id) references subject(id),
 constraint fk_exam_id foreign key (exam_id) references exam(id)
);

INSERT INTO STUDENT (name) VALUES ('liyana');
INSERT INTO STUDENT (name) VALUES ('reena');

-- Insert values into the SUBJECT table
INSERT INTO SUBJECT (name, code) VALUES ('Mathematics', 'MATH101');
INSERT INTO SUBJECT (name, code) VALUES ('Physics', 'PHY101');

-- Insert values into the EXAM table
INSERT INTO EXAM (name, min_mark, max_mark) VALUES ('Midevaluation', 35, 100);
INSERT INTO EXAM (name, min_mark, max_mark) VALUES ('Final', 40, 100);

-- Insert values into the MARKS table
INSERT INTO MARKS (mark, student_id, subject_id, exam_id)
VALUES (85, 1, 100, 200),(90,1,100,201),(98,1,101,201),(89,2,100,200),(78,2,100,201),(60,2,101,200),(90,2,101,200);

-- join above tables.
-- if a subname is given ,fetch all the marks obtained by any student.
-- if a student id is given, fetch all the exams attended by the student with student details.
select  
    marks.id as mark_id,
    marks.mark,
    student.id as student_id,
    student.name as student_name,
    subject.id as subject_id,
    subject.name as subject_name,
    exam.id as exam_id,
    exam.name as exam_name
from
    marks 
inner join 
    student 
    on marks.student_id = student.id 
inner join 
    subject
    on marks.subject_id = subject.id 
inner join 
    exam 
    on marks.exam_id = exam.id;


select
    distinct exam.name as exam_name, -- distinct always on top otherwise show erroyr.
    student.id as student_id,
    student.name as student_name
from
    student inner join marks on student.id = marks.student_id
    inner join exam on exam.id = marks.exam_id
    where student.id = 1;
