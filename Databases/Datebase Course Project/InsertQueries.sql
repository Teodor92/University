USE [SimpleStudentSystem]

-- Inserts sample Faculties
INSERT INTO [Faculties] VALUES
('Informatics'),
('Mathematics'),
('Biology'),
('Economics')

-- Inserts sample Courses
INSERT INTO [Courses] VALUES
('C#', 'Basic of C# programing'),
('Macroiconomics', 'Basic of macroiconomic theory'),
('Mathematics', 'Basic mathematics'),
('Java', 'Java programing'),
('Databeses','Basic of databases')

-- Inserts sample Univerities
INSERT INTO [Universities] VALUES
('Sofia University', 'The Univeristy of Sofia'),
('UNWE', 'University of national and world economics'),
('TU', ' TU Sofia')

-- Insert Sample Sudents
INSERT INTO [Students] VALUES
('Ivan', 'Ivanovich', 'Ivanov', 1, 1, 21),
('Bojan', 'Ivanovich', 'Georgiev', 1, 2, 23),
('Georgi', 'Genchev', 'Ivanov', 1, 3, 21),
('Ivana', 'Ivanova', 'Todorova', 1, 4, 26),
('Gergana', 'Plamenova', 'Jeliazkova', 2, 1, 21),
('Nikolai', 'Ivan', 'Petev', 2, 2, 22),
('Ivan', 'Denchev', 'Petrov', 2, 3, 21),
('Petar', 'Petrov', 'Pechlivanov', 2, 4, 43),
('Georgi', 'Iliev', 'Spasov', 3, 1, 24),
('Maria', 'Georgieva', 'Ivanova', 3, 2, 18),
('Ivaila', 'Igorova', 'Teneva', 3, 3, 21),
('Penka', 'Petrova', 'Ivanova', 3, 4, 19),
('Pesho', 'Ivanovich', 'Velev', 1, 2, 21),
('Ognia', 'Pechlivanov', 'Dragoev', 2, 2, 33),
('Marian', 'Georgiev', 'Ivanov', 3, 3, 20)

-- Add students in courses
INSERT INTO [Students_Courses] VALUES
(110000, 1),
(110000, 2),
(110000, 3),
(110001, 2),
(110001, 3),
(110001, 4),
(110002, 3),
(110002, 4),
(110002, 5),
(110003, 1),
(110003, 2),
(110003, 3),
(110004, 2),
(110004, 3),
(110004, 4),
(110005, 3),
(110005, 4),
(110005, 5),
(110006, 1),
(110006, 2),
(110006, 3),
(110007, 2),
(110007, 3),
(110007, 4),
(110008, 3),
(110008, 4),
(110008, 5),
(110009, 1),
(110009, 2),
(110009, 3),
(110010, 2),
(110010, 3),
(110010, 4),
(110011, 3),
(110011, 4),
(110011, 5),
(110012, 1),
(110012, 2),
(110012, 3),
(110013, 2),
(110013, 3),
(110013, 4),
(110014, 3),
(110014, 4),
(110014, 5)