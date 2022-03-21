create database Zensarcasestudy;

use Zensarcasestudy;


create table Student(
S_ID int primary key,
S_Name Varchar(20),
S_Dob Varchar(10))



select *from Student


--Creation of Course table

create table Course
(C_Id int primary key,
C_Name Varchar(10),
C_Dur Varchar(10),
Fees int)



select *from Course


--Creation of Enroll table


create table Enroll(cid int foreign key references Course(C_Id),
S_id int foreign key references student(S_ID),
EnrollDate date)

select *from Enroll