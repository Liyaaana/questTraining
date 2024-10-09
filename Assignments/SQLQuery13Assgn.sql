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