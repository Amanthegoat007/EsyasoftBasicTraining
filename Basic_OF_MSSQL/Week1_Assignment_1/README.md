# README.md
# MSSQL Assignment 1

This assignment demonstrates basic SQL operations using Microsoft SQL Server. It covers database creation, table definitions, data insertion, and queries involving joins and aggregate functions.

## Structure

- **SQL(Assignment_1_).sql**: Contains all SQL statements for the assignment.

## Steps

1. **Database Creation**
   - Creates a database named `Users`.

2. **Table Creation**
   - `userw`: Stores user information (`user_id`, `email`, `name`).
   - `books`: Stores book details (`product_id`, `title`, `price`).
   - `orders`: Stores order records (`order_no`, `user_id`, `product_id`).

3. **Data Insertion**
   - Inserts sample data into `userw`, `books`, and `orders` tables.

4. **Queries**
   - Lists all books.
   - Lists all orders.
   - Shows which user bought which book using joins.
   - Finds the record of the book with the maximum price.

## Usage

1. Open `SQL(Assignment_1_).sql` in your SQL Server Management Studio.
2. Execute the script step by step or all at once.
3. Review the output of each query to understand the results.

## Notes

- Foreign key relationships are set between `orders` and `userw`/`books`.
- The assignment demonstrates LEFT JOIN and INNER JOIN usage.
- Aggregate function (`MAX`) is used to find the most expensive book.
