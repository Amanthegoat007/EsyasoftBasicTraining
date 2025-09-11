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

select * from orders;
select * from books;
select * from userw;

--Task 1) Select Top N books per User

select *
from(
select u.name, b.title, b.price ,
rank() over (partition by u.name order by b.price desc) as Top_books
from userw u
left join orders o
on u.user_id = o.user_id
inner join books b
on o.product_id = b.product_id
) as tbl
where Top_books <= 2


--Task 2) Ranking User by Total Spending


select
ranked_data.name,
ranked_data.Total_price,
    dense_rank() over (order by ranked_data.Total_price desc) as "Rank"
from (
    select
    u.name,
        sum(b.price) AS Total_price
    from
        userw u
    left join
        orders o on u.user_id = o.user_id
    inner join
        books b on o.product_id = b.product_id
    group by
        u.name
) as ranked_data
order by
    Total_price desc;
