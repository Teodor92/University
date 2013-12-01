USE [SimpleStudentSystem]

-- Deletes all info about the mathematics faculty
DELETE FROM [Faculties]
WHERE Name = 'Mathematics'

-- Deletes all students that are younger than 20 years
DELETE FROM [Students]
WHERE Age < 20

--Deletes all data from the tables // TODO: FIX
TRUNCATE TABLE [Students_Courses]
TRUNCATE TABLE [Faculties]
TRUNCATE TABLE [Students]
TRUNCATE TABLE [Courses]
TRUNCATE TABLE [Universities]