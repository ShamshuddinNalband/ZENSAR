create database Movie
 
use Movie
 
create table MovieTable
(MovieID int primary key ,
MovieName varchar(20),
MovieReleaseDate varchar(20))
 
select *from MovieTable

insert into MovieTable values
(1,'ek the tiger','11-03-2022'),
(2,'tiger zinda hai','15-03-2022'),
(3,'Bahubali 2','02-05-2015'),
(4,'suryavanshi','09-02-2021'),
(5,'robo','12-04-2023'),
(6,'kgf','13-11-2021')