USE [SimpleStudentSystem]

-- 1. Select all data from the studets table 
SELECT * FROM [Students]

-- 2. Select all student data
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age, un.Name, un.[Description], fc.Name FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
JOIN Faculties fc 
ON st.FacultyId = fc.FacultyId 

-- 3. Select all students form the Informatics faculty
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age, fc.Name FROM [Students] st
JOIN Faculties fc 
ON st.FacultyId = fc.FacultyId 
WHERE fc.Name = 'Informatics'

-- 4. Select all the students from UNWE
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age, un.Name, un.[Description] FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
WHERE un.Name = 'UNWE'

-- 5. Select all students from the UNWE and SU
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age, un.Name, un.[Description] FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
WHERE un.Name IN ('UNWE', 'TU')

-- 6. Select all students that are not form UNWE
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age, un.Name, un.[Description] FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
WHERE un.Name NOT IN ('UNWE')

-- 7. Select all students which first name starts with an 'I'

SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age FROM [Students] st
WHERE st.FirstName LIKE 'I%'

-- 8. Selecting all the students with age between 18 and 21 and order them by age
SELECT st.StudentId, st.FirstName + ' ' + st.MiddleName + ' ' + st.LastName as [Full Name], st.Age FROM [Students] st
WHERE st.Age BETWEEN 18 AND 21
ORDER BY st.Age DESC

-- 9. Geting the average age for each university
SELECT un.Name, AVG(Age)  FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
GROUP BY un.Name

-- 10. Geting the average age for UNWE
SELECT un.Name, AVG(Age) as [Average Age]  FROM [Students] st
JOIN Universities un 
ON st.UniversityId = un.UniversityId
GROUP BY un.Name
HAVING un.Name = 'UNWE'

-- 11. Get the count of all students
SELECT COUNT(StudentId) as [Student count] FROM [Students]

-- 12. Get the age of the oldest student
SELECT MAX(st.Age) as [Highest age] FROM [Students] st