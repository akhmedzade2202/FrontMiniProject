SELECT 
    s.FirstName,
    s.LastName,
    c.CourseName,
    g.Grade
FROM Grades g
JOIN Students s ON g.StudentID = s.StudentID
JOIN Courses c ON g.CourseID = c.CourseID
WHERE g.Grade > 80;


SELECT *
FROM Students
WHERE EnrollmentYear = 2022
AND FacultyID = 1;

SELECT
    s.FirstName,
    s.LastName,
    c.CourseName,
    g.Grade,
    f.FacultyName
FROM Grades g
JOIN Students s ON g.StudentID = s.StudentID
JOIN Courses c ON g.CourseID = c.CourseID
LEFT JOIN Faculties f ON s.FacultyID = f.FacultyID;

SELECT 
    s.FirstName,
    s.LastName,
    f.FacultyName,
    c.CourseName,
    g.Grade
FROM Students s
LEFT JOIN Faculties f ON s.FacultyID = f.FacultyID
LEFT JOIN Grades g ON s.StudentID = g.StudentID
LEFT JOIN Courses c ON g.CourseID = c.CourseID


SELECT 
    c.CourseName,
    s.FirstName,
    s.LastName,
    g.Grade
FROM Courses c
LEFT JOIN Grades g ON c.CourseID = g.CourseID
LEFT JOIN Students s ON g.StudentID = s.StudentID;
