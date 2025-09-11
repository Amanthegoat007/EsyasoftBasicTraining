--Created a new db --> Users

create database Users;

-- Used this db Users

use Users;

--Userw Table
create table userw (
user_id int primary key,
email varchar(50),
name varchar(50)
);


-- Books Table
create table books
(product_id int primary key,
title varchar(50),
price float);


--Orders table
create table orders
(order_no int primary key,
user_id int foreign key references userw(user_id),
product_id int foreign key references books(product_id)
);


--Inserting values inside userw
insert into userw values
(1, 'callmebhai@gmail.com','Gopal'),
(2,'toxicManjit@gmail.co','Manjit'),
(3,'kalajadu@gmail.com','SoumyaDeep'),
(4,'vimalpanMasala@gmail.com','JaiSai'),
(5,'ghostlaugh@gmail.com','Namitha');
 



--Inserting Books entries
insert into books values
(101,'MsSql',100),
(102,'Half Gf',150),
(103,'BlackMagicTutorial',700),
(104,'marfa', 2000),
(105,'How to laugh',2001);

-- Checking values of books, userw
select * from userw;
select * from books;
select * FROM orders;


--Inserting into orders table
insert into orders values
(401,1,101),
(402,2,103),
(403,2,102),
(404,3,103),
(405,3,104),
(406,4,102),
(407,5,102),
(408,5,105);

--checking inserted values inside orders
select * from orders;


--Tasks

--1) Find all the books all the users and all the order
select * 
from userw u
left join 
orders o
on u.user_id= o.user_id
inner join books b
on
b.product_id= o.product_id

--2) Find all orders
select * from orders;

--3) find particular user who has order these books
select b.title, u.name 
from books b
join orders o 
on b.product_id=o.product_id
join userw u
on o.user_id=u.user_id;


--4) find books users has order
select u.name, b.title
from books b
join orders o 
on b.product_id=o.product_id
join userw u
on o.user_id=u.user_id;

--5)Find total price of books users has orders

select u.name as Name,sum(b.price) as TotalPrice from 
books b 
left join 
orders o
on b.product_id=o.product_id
left join 
userw u
on o.user_id=u.user_id
group by u.name;


--6) find the most valuable user
select top 1 u.name as Name,sum(b.price) as TotalPrice from 
books b 
left join 
orders o
on b.product_id=o.product_id
left join 
userw u
on o.user_id=u.user_id
group by u.name 
order by TotalPrice desc;

--7) find the range of books from high to low

select title from books order by price desc;

--8) find the highest price books
select title, price from books where price=(select max(price) from books);

--9) Find the cheapest books
select title, price from books where price=(select min(price) from books);

--10)Find newly added books
select top 1 title, price from books order by product_id desc;
select * from books;


