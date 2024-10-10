Create Database  FitnessProgramManagement;

use FitnessProgramManagement;

Create table FitnessPrograms(FitnessProgramId int identity(1,1) Primary Key,
Title NVARCHAR(20),Duration NVARCHAR(23),Price Decimal(23));


select * from FitnessPrograms

insert into FitnessPrograms values ( 'weight Training',' 6 months',10);