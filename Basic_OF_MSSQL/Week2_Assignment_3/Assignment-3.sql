use tarzan;

select * from Employees;
select * from Contacts;
select * from Projects;
select * from Students2024;
Select * from Students2025;


--Task 1- Union & Union ALL

--1) Show a List of all students names( unique)
select * from Students2024
union 
select * from Students2025;

--2) Show a list of all student names ( including duplicates)

select * from Students2024
union all 
select * from Students2025;


--Task 2 UpperCase & LowerCase Functions

--1) Display Employee names in uppercase and LowerCase

select Upper(name) as EMP_NAME, 
lower(name) as emp_name
from Employees;

--2) Find the length of each employees name

select len(name) from Employees;

--3)Show only the first 3 letters of each name.

select substring(name,1,3) from Employees;

--4)Replace Finance department with Accounts.

Select Replace(Department,'Finance','Accounts') from Employees;

--5) Create a new column showing "Name-Department" using concat

select concat(name,' - ',Department) as Details from Employees;

--Task-3 --> Date Functions (DATEDIFF, DATEADD, GETDATE, NOW)

--1)Show today�s date using GETDATE().
select GETDATE() as CurrentDate;


--2)Find the duration (in days) of each project using DATEDIFF.
select DATEDIFF(day,StartDate,EndDate) from Projects;

--3)Add 10 days to each project�s EndDate using DATEADD.
select DATEADD(day,10,EndDate) from Projects;

--4)Find how many days are left until each project ends. (Hint: Use DATEDIFF with GETDATE())
select DATEDIFF(day,EndDate,GETDATE()) from Projects;

--Tasks-4 -->CAST, CONVERT, CASE



--1)Convert today's date into DD/MM/YYYY format using CONVERT.
select CONVERT(varchar(10),GETDATE(),103) as DD_MM_YYY;

--2)Convert a float 123.456 into an integer using CAST.
select CAST(123.456 as int) as TypeConversion ;
 


