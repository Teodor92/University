USE [SimpleStudentSystem] 

-- Updates the age of all students form TU by adding 1
UPDATE [Students]
SET Age = Age + 1
WHERE [UniversityId] = 3

-- Reverst the upper change
UPDATE [Students]
SET Age = Age - 1
WHERE [UniversityId] = 3

-- Updates the name of the first faculty
UPDATE [Faculties]
SET Name = Name + ' First'
WHERE FacultyId = 1 