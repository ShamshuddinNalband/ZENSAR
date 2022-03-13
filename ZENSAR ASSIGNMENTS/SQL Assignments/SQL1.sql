create database ash1

use ash1;

create table Dept (
Deptno int primary key,
Dname varchar(200),
loc varchar(150),
);

insert into Dept
values (10,'ACCOUNTING','NEWYORK'),
       (20,'RESEARCH','DALLAS'),
	   (30,'SALES','CHICAGO'),
	   (40,'OPERATIONS','BOSTON');

	   select * from Dept

create table Emp (
      Empno int primary key,
	  Empname varchar(200),
	  job varchar(150),
	  mgr int,
	  hiredate varchar(200),
	  salary int,
	  comm int,
	  Deptno int foreign key references dept(deptno));


insert into Emp
values (7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
       (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
	   (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
	   (7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
	   (7654,'MARTIN','SALESMAN','7698','28-SEP-81',1250,1400,30),
	   (7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
	   (7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,NULL,10),
	   (7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
	   (7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10),
	   (7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
	   (7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
	   (7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
	   (7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
	   (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10);



select * from EMP


--List all employees whose name begins with 'A'.

select * from EMP
where EmpName like 'A%'; 


--Select all those employees who don't have a manager.

select * from EMP 
where mgr is Null;


--List employee name, number and salary for those employees who earn in the range 1200 to 1400.

select EmpName, EMPNO, salary from EMP
where salary between 1200 and 1400;



--Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.

select * from EMP
where DeptNo = 20;
update EMP set salary = salary + (salary*10/100)
where DeptNo = 20;
select * from EMP
where DeptNo = 20;



--Find the number of CLERKS employed. Give it a descriptive heading.

select count(JOB) 'Number of Employee of type Clerk' from EMP
where job = 'CLERK';



--Find the average salary for each job type and the number of people employed in each job.

select count(*) 'Count of Employees', AVG(salary) 'Average of Salary',job from EMP
group by job;



--List the employees with the lowest and highest salary. 

select * from EMP
where salary = (select min(salary)'Minimum Salary' from EMP)
select * from EMP
where salary = (select  max(salary)'Maximum Salary' from EMP)




--List full details of departments that don't have any employees.

select * from Dept
where DeptNo not in (select DeptNo from EMP)
--OR
SELECT * FROM Dept D LEFT JOIN EMP E ON D.DeptNo = E.DeptNo
WHERE E.DeptNo IS NULL






--Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.

select EmpName, salary from EMP
where JOB = 'ANALYST' and salary > 1200 and DeptNo = 20
order by EmpName




--For each department, list its name and number together with the total salary paid to employees in that department.

select DNAME, d.DeptNo, sum(salary)'Total Salaries in Department' from Dept d,EMP e
where d.DeptNo = e.DeptNo
group by DNAME, d.DeptNo




-- Find out salary of both MILLER and SMITH.

select EmpName, salary from EMP
where EmpName = 'Miller' or EmpName = 'Smith';



--Find out the names of the employees whose name begin with ‘A’ or ‘M’. 

select * from EMP 
where EmpName like 'A%' or EmpName like 'M%';





-- Compute yearly salary of SMITH. 

select EmpName,(salary*12) 'Anual Salary' from EMP
where EmpName = 'Smith';




--List the name and salary for all employees whose salary is not in the range of 1500 and 2850.

Select EmpName, salary from EMP
where salary not between 1500 and 2850;
