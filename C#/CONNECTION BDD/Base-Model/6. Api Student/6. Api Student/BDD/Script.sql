--DROP DATABASE IF EXISTS Student; 
--CREATE DATABASE Student CHARACTER SET utf8;
--USE Student;

--#========================================
--# Table : Students
--#========================================

--CREATE TABLE Students(
--   IdStudent INT AUTO_INCREMENT PRIMARY KEY,
--   NomStudent VARCHAR(50) ,
--   AgeStudent INT
--)ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;


--#========================================
--# Table : Courses
--#========================================

--CREATE TABLE Courses(
--   IdCourse INT AUTO_INCREMENT PRIMARY KEY,
--   NomCourse VARCHAR(50) ,
--   DescriptionCourse TEXT
--)ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;


--#========================================
--# Table : Participation
--#========================================

--CREATE TABLE Participation(
--   IdParticipation Int AUTO_INCREMENT PRIMARY KEY,
--   IdStudent INT,
--   IdCourse INT
--)ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;

--ALTER TABLE
--    Participation
--ADD
--    CONSTRAINT FK_Participation_Students FOREIGN KEY(IdStudent) REFERENCES Students(IdStudent),
--ADD
--    CONSTRAINT FK_Participation_Courses FOREIGN KEY(IdCourse) REFERENCES Courses(IdCourse);