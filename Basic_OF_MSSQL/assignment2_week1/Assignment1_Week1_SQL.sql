--Created a Database Assignment1-Week1
create database Assignment1;

--Initialized the Database
use Assignment1;

-- Create Customers table to store customer information
create table Customers
(
customer_id int primary key,
name varchar(50),
address varchar(50),
region varchar(50)
);

-- Insert sample customer records
insert into Customers values 
(101,'Sashi','Jharkhand','East'),
(102,'Surendra','AP','South'),
(103,'Dharmesh', 'MP','Centre'),
(104,'Tejas','UP','North'),
(105,'Suraj','Rajasthan','North');

-- Display all customers
select * from Customers;

-- Create SmartMeterReadings table to store meter readings
create table SmartMeterReadings(
meterId int primary key,
customer_id int ,
location varchar(50),
Installed_Date date,
readingDateTime datetime,
energyConsumed float,
foreign key (customer_id) references Customers(customer_id),
);

-- Insert sample smart meter readings
insert into SmartMeterReadings values
(301,101, 'East', '2024-12-23','2024-12-23 11:30:00', 25.50),
(302,102, 'North', '2024-08-24','2024-08-24 01:23:40', 75.50),
(303,101, 'East', '2024-02-23','2024-02-23 11:40:00', 75.00),
(304,102, 'North', '2024-04-23','2024-04-23 10:00:00', 26.50),
(305,102, 'North', '2024-03-20','2024-03-20 10:40:00', 37.50),
(306,103, 'East', '2024-02-23','2024-02-23 10:00:00', 15.50),
(307,103, 'Cent', '2024-05-12','2024-05-12 05:00:40', 21.20),
(308,105, 'East', '2024-12-31','2024-12-31 03:30:00', 65.50);

-- Display all smart meter readings
select * from SmartMeterReadings;


--Task1 
-- Query to retrieve meter readings between Jan 1, 2024 and Jun 30, 2024
-- where energy consumed is between 10 and 50 units
-- and the meter was installed on or before Jun 30, 2024
select meterId, readingDateTime, energyConsumed 
from SmartMeterReadings
where readingDateTime 
between '2024-01-01' and '2024-06-30' 
and  
energyConsumed between 10 and 50 
and 
Installed_Date<='2024-06-30';


--Task 2
-- Query to calculate average and maximum energy consumed per customer
Select customer_id, 
avg(energyConsumed) as AvgEnergyConsumed, 
max(energyConsumed) as MaxEnergyConsumed
from SmartMeterReadings 
where YEAR(readingDateTime)=2024
group by customer_id  ;