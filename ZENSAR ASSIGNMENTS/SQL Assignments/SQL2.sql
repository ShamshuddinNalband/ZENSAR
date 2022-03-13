use ash1

--Assignment2

--1 Retrieve a list of MANAGERS.
select mgr from Emp;

--2 Find out salary of both MILLER and SMITH.
select EmpName,salary from Emp where empname in ('MILLER','SMITH');

--3 Find out the names and salaries of all employees earning more than 1000 per month
select EmpName,salary from Emp where salary>1000;

--4 Display the names and salaries of all employees except JAMES.
select EmpName,salary from Emp where EmpName<>'JAMES';

--5 Find out the details of employees whose names begin with ‘S’.
select * from Emp where EmpName like 's%';

--6 Find out the names of all employees that have ‘A’ anywhere in their name. 
select * from Emp where EmpName like '%a%';

--7 Find out the names of all employees that have ‘L’ as their third character in their name.
select EmpName from Emp where EmpName like '__l%';

--8 Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select EmpName from Emp where EmpName like '[am]%';

--9 Compute yearly salary of SMITH.
select EmpName,salary*30*12 as Annual_Sal from Emp where EmpName='SMITH'; 

--10 Compute daily salary of JONES.
select EmpName,salary as Daily_Sal from Emp where EmpName='JONES';

--11 Calculate the total monthly salary of all employees.
select EmpName,salary*30 as Month_Sal from Emp;

--12 Print the average annual salary.
select avg(salary*30*12) as Avg_AnnualSal from Emp;

--13 Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select EmpName,job,salary,DeptNo from Emp where job<>'salesman' and DeptNo=30;

--14 List unique departments of the EMP table.
select distinct(DeptNo) from Emp;

--15 List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select Empname 'Employee ',salary 'Monthly_Salary' from Emp where salary>1500 and DeptNo in (10,30);