# Week 2 SQL Assignment

## Overview

This assignment demonstrates basic SQL operations using a sample database with three tables: `userw`, `books`, and `orders`. The queries cover table creation, data insertion, and solutions to common SQL tasks.

## Database Structure

- **Database:** `Users`
- **Tables:**
  - `userw`: Stores user information (`user_id`, `email`, `name`)
  - `books`: Stores book details (`product_id`, `title`, `price`)
  - `orders`: Stores order records (`order_no`, `user_id`, `product_id`)

## Tasks Covered

1. **Find all books, users, and orders**  
   Joins all tables to display complete order information.
2. **Find all orders**  
   Displays all records from the `orders` table.
3. **Find which user ordered which books**  
   Shows book titles and corresponding user names.
4. **Find books users have ordered**  
   Lists users and the books they ordered.
5. **Find total price of books users have ordered**  
   Calculates the total price of books ordered by each user.
6. **Find the most valuable user**  
   Identifies the user who spent the most on books.
7. **Find the range of books from high to low price**  
   Lists books sorted by price (descending).
8. **Find the highest priced book**  
   Displays the book(s) with the highest price.
9. **Find the cheapest book**  
   Displays the book(s) with the lowest price.
10. **Find newly added books**  
    Shows the most recently added book.

## How to Use

1. Run the SQL file in Microsoft SQL Server Management Studio or any compatible SQL environment.
2. The script will create the database and tables, insert sample data, and execute the queries for each task.

