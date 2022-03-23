USE EmployeeManagement

create table Code_Employee(empno int primary key identity(1,1),
empname varchar(50) not null,
empsal numeric(10,2) check(empsal>=25000),
emptype varchar(1) check(emptype in ('c','p'))
)


create or alter proc InsertEmployee(@name varchar,@sal numeric,@type varchar)
as begin
insert into Code_Employee values(@name,@sal,@type)
end

