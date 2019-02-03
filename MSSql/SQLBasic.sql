/* ----------------------------------------------------------------------------------
A: DML : Data MANIPULATION Language
1. SELECT	2.INSERT	3.UPDATE	4.DELETE
*-----------------------------------------------------------------------------------*/

/* --------------------------------------------------
A-1. Simple Select Statement

Basic use of queries and SQL functions
--------------------------------------------------- */

SELECT @@servername, @@version

USE pubs
GO

SELECT * FROM titles
GO
SELECT title_id, title, type FROM TITLES
GO
SELECT title_id AS bookID, title AS bookTitle, type AS bookType FROM TITLES
GO
-- 
SELECT bookID=title_id, bookTitke=title, bookType=type FROM TITLES

-- TIP: system stored procedure
EXEC sp_tables

select * from sysobjects where type = 'U'
-- system sp
sp_columns titles

select * from syscolumns where id = object_id('titles') 

-- Declare keyword
-- specific data type: table
DECLARE @T TABLE (id int, name varchar(8))
INSERT @T values(10,'Joe')
SELECT * FROM @T

-- set keyword, sql_variant type
DECLARE @T1 sql_variant, @T2 sql_variant
set @T1 = 12345
set @T2 = 'this is string'
select @T1
select @T2

/* sql built-in function
** Aggregate Functions 
Configuration Functions
Cursor Functions
** Date and Time Functions
** Mathematical Functions
Metadata Functions
Security Functions
** String Functions
System Functions
System Statistical Functions
Text and Image Functions
** : Often Used
*/ 

-- example of using function 
-- NOTE: When using "functions", use it with "SELECT"

SELECT AVG(advance) FROM titles
SELECT SUM(price), SUM(advance) FROM titles
SELECT COUNT(*) FROM titles -- == SELECT COUNT(title) FROM titles
SELECT MAX(ytd_sales) FROM titles
SELECT min(ytd_sales) FROM titles 

-- Date function
SELECT GETDATE()
SELECT DATEADD(day, 21, pubdate) AS timeframe FROM titles
SELECT DATEDIFF(day, pubdate, getdate()) AS no_of_days FROM titles
SELECT DATEPART(month, GETDATE()) AS 'Month Number'

-- Math function
SELECT ABS(-1.0), ABS(0.0), ABS(1.0)
SELECT RAND(1) AS Random_Number
SELECT ROUND(123.9994, 3), ROUND(123.9995, 3) 
SELECT ROUND(123.9994, 3), ROUND(123.9995, 3) 

-- String
SELECT LEFT(title, 5) FROM titles
SELECT LEN(title) FROM titles
SELECT LOWER(title) AS LowerCase FROM titles
SELECT UPPER(au_lname) AS UpperCase FROM authors


DECLARE @temp_string varchar(100)
SET @temp_string = ' abcdefg'
SELECT LTRIM(@temp_string)

SELECT PATINDEX('%the%', title) as firstPlaceOfString FROM titles

SELECT REPLACE('Here is Canada','Canada','Korea')

SELECT REVERSE(au_fname) FROM authors

SELECT RIGHT(au_fname, 5) FROM authors

SELECT au_fname, SUBSTRING(au_fname, 3, 2) FROM authors

/* ---------------------------------------------------
A-1. Select Statement

SELECT query with 

filtering, distinct, order by, group by, join, sub Query,
union, select into
---------------------------------------------------- */
USE pubs
GO

-- where filtering
SELECT * FROM sales where qty > 10

SELECT * FROM authors WHERE zip > 90000

-- string: not double quotation, but single one
SELECT * FROM authors WHERE state = 'CA'

-- NB: price = null 
SELECT title FROM titles WHERE price IS NULL

SELECT title_id, ytd_sales 
FROM titles 
WHERE ytd_sales > 4095 AND ytd_sales < 12000

SELECT title_id, ytd_sales 
FROM titles 
WHERE ytd_sales between 4095 AND 12000

SELECT title, type FROM titles 
WHERE type IN ('mod_cook', 'trad_cook')

SELECT title, type FROM titles 
WHERE type NOT IN ('mod_cook', 'trad_cook')

SELECT title, type FROM titles 
WHERE type = 'mod_cook' OR type = 'trad_cook'

-- Like pattern match
SELECT stor_name FROM stores 
WHERE stor_name LIKE '%Books%'

SELECT stor_name FROM stores
WHERE stor_name LIKE 'Bo%'

SELECT stor_name FROM stores
WHERE stor_name LIKE 'E_i%'

SELECT stor_name FROM stores
WHERE stor_name LIKE 'B[^a]%'

SELECT title_id, title, pub_id, price, pubdate
FROM titles
WHERE (title LIKE 'T%' OR pub_id = '0877') AND (price > $16.00)

SELECT title_id, title, pub_id, price, pubdate
FROM titles
WHERE (title LIKE 'T%') OR (pub_id = '0877' AND price > $16.00)

SELECT title_id, title, pub_id, price, pubdate
FROM titles
WHERE title LIKE 'T%' OR pub_id = '0877' AND (price > $16.00)

-- TOP
-- TODO

-- Distinct
-- compare
SELECT au_id FROM titleauthor
SELECT DISTINCT au_id FROM titleauthor

-- NOTE: text type column, image type column are not possible
SELECT DISTINCT * FROM titleauthor
SELECT * FROM titleauthor

-- Order By
/*
Column name or number
Asc is "by default".
NOTE: text type column, image type column are not possible
*/
-- compare
SELECT city, au_fname, au_lname FROM authors

SELECT city, au_fname, au_lname FROM authors
ORDER BY city

-- Same as above
SELECT city, au_fname, au_lname FROM authors
ORDER BY city ASC

SELECT city, au_fname, au_lname FROM authors
ORDER BY city DESC

SELECT city, au_fname, au_lname FROM authors
ORDER BY city ASC, au_fname ASC

-- group by
-- analytical data with aggregate function: sum, avg, count, min, max

--SELECT select_list
--FROM table_name
--[WHERE search_conditions] -- optional
--GROUP BY [ALL] aggregate_free_expression [, aggregate_free_expression…]]
--[HAVING search conditions] – optional

-- compare
select pub_id, type, royalty, ytd_sales 
from titles

select pub_id, type, royalty, ytd_sales, AVG(price)
from titles
GROUP BY pub_id, type, royalty, ytd_sales

select type, sum(price)
from titles
group by type

SELECT title_id, copies_sold = SUM(qty)
FROM sales
GROUP BY title_id
HAVING SUM(qty) > 20

SELECT title_id, copies_sold = SUM(qty)
FROM sales
WHERE ord_date BETWEEN '1/1/1994' AND '12/31/1994'
GROUP BY ALL title_id

-- Join
-- Join by identical column (Physical and Logical)
-- Data Normalization and Denormalization with ERD
-- INNER JOIN / OUTER JOIN / CROSS JOIN/ SELF JOIN

SELECT * from authors
SELECT * FROM publishers

SELECT *
FROM authors AS a INNER JOIN publishers AS p
ON a.city = p.city

-- ANSI Syntax
SELECT pub_name, title
FROM titles INNER JOIN publishers
ON titles.pub_id = publishers.pub_id
-- T-SQL Syntax
SELECT authors.au_lname, authors.state, publishers.*
FROM publishers, authors
WHERE publishers.city = authors.city

-- outer join
SELECT title, stor_id, ord_num, qty, ord_date
FROM titles LEFT OUTER JOIN sales
ON titles.title_id = sales.title_id
-- cross join
SELECT au_fname, au_lname, pub_name
FROM authors CROSS JOIN publishers 

-- self join 
-- TODO

-- Sub Query
SELECT * FROM titles
WHERE title_id IN (SELECT title_id FROM sales)

SELECT * FROM titles
WHERE title_id = (SELECT title_id FROM sales WHERE title_id like 'PS2106')

SELECT title FROM titles
WHERE title_id IN -- IN Keyword
(SELECT DISTINCT title_id FROM sales)
 
-- related subquery : repalce it with join query
-- TODO


-- select into
-- TODO

-- UNION

/* ---------------------------------------------------
A-2. Insert Statement

SQL datatype in table, default value, null or not null, 
PK-FK: Referential Integrity
BEGIN TRAN and COMMIT TRAN
---------------------------------------------------- */
CREATE TABLE test1(
	 columnA varchar(10)
	,columnB int
)
GO
INSERT INTO test1 VALUES('John',1)
INSERT INTO test1 VALUES('Jane',2)
INSERT INTO test1 VALUES('Wilson',3)

-- TODO: Referential Integrity Test

-- Insert with select
INSERT INTO test1
SELECT * FROM test1

SELECT * FROM test1
/* ---------------------------------------------------
A-3. Update Statement

SQL datatype in table, default value, null or not null, 
PK-FK: Referential Integrity
BEGIN TRAN and COMMIT TRAN
---------------------------------------------------- */

-- Before
SELECT title_id, price, title 
FROM titles WHERE title_id like 'BU1032'

UPDATE titles
SET price = price * 2
WHERE title_id like 'BU1032'

-- After
SELECT title_id, price, title 
FROM titles WHERE title_id like 'BU1032'

-- Update with Select
UPDATE titles
SET price = price * 2
WHERE pub_id IN
	(SELECT pub_id
	FROM publishers
	WHERE pub_name = 'New Moon Books')  

/* ---------------------------------------------------
A-4. Delete Statement

SQL datatype in table, default value, null or not null, 
PK-FK: Referential Integrity
BEGIN TRAN and COMMIT TRAN

Referential Integrity
DELETE FROM and Trancate Table
---------------------------------------------------- */
SELECT * FROM authors

-- NOTE: PK, FK
DELETE FROM authors
WHERE au_lname = 'McBadden'

DELETE FROM titleauthor 
WHERE title_id IN 
(SELECT title_id 
FROM titles
WHERE title LIKE '%computers%')

/* ----------------------------------------------------------------------------------
B: DDL : Data Definition Language
1.CREATE  	2.DROP		3.ALTER	
---------------------------------------------------------------------------------- */
-- Data Type Confirmation
-- SQL Object : Table,View, etc

/* ---------------------------------------------------
B-1. Create 
---------------------------------------------------- */
CREATE TABLE testTable(user_id int)

INSERT INTO testTable VALUES(1)INSERT INTO testTable VALUES(2)

SELECT * FROM testTable

CREATE TABLE testTable2(
	user_id int identity(1,1)
	,user_content varchar(10)
)
INSERT INTO testTable2 VALUES('Hi')
INSERT INTO testTable2 VALUES('I am hungry')
--Error : Why?
INSERT INTO testTable2 VALUES('Hi I am hungry')

--Error : Why?
INSERT INTO testTable2 VALUES(3, 'Hi')
SELECT * FROM testTable2 

/* ---------------------------------------------------
B-2. Alter and Drop
---------------------------------------------------- */
ALTER TABLE testTable2 
ALTER COLUMN user_content VARCHAR(20) NOT NULL
GO

--Error : Why?
INSERT INTO testTable2 VALUES('Hi I am hungry')

SELECT * FROM testTable2

ALTER TABLE testTable2 
ADD gender bit NULL
GO
-- see table info
EXEC sp_help testTable2 
GO

ALTER TABLE testTable2 
DROP COLUMN gender GO

EXEC sp_help testTable2 GO

/* ----------------------------------------------------------------------------------
C: Data Integrity and Consistency
*-----------------------------------------------------------------------------------*/

-- Domain Integrity: per table 
	-- column constraint
-- Referential Integrity: between tables
	-- PK, FK
CREATE TABLE testTable4( 
             Name VARCHAR(10) NOT NULL PRIMARY KEY 
             ,Age TINYINT NULL 
)

INSERT INTO testTable4(Name, Age) VALUES('aaa', 19) 
-- Error
INSERT INTO testTable4(Name, Age) VALUES('aaa', 20)       

--
CREATE TABLE Role( 
             RoleID INT NOT NULL PRIMARY KEY 
             ,RoleName VARCHAR(10) NOT NULL 
)
INSERT INTO Role(RoleID , RoleName ) VALUES(1, 'admin') 
INSERT INTO Role(RoleID, RoleName ) VALUES(2, 'guest') 
INSERT INTO Role(RoleID, RoleName ) VALUES(3, 'member')

CREATE TABLE Employee2( 
             EmpID VARCHAR(10) NOT NULL PRIMARY KEY 
             ,EmpName VARCHAR(10) NULL 
             ,RoleID INT NOT NULL 
             REFERENCES Role(RoleID ) 
  
)

INSERT INTO Employee2(EmpID, EmpName, RoleID) VALUES('00001', 'aaaa', 1) 
													
INSERT INTO Employee2(EmpID, EmpName, RoleID) VALUES('00002', 'bbbb', 1) 
													
INSERT INTO Employee2(EmpID, EmpName, RoleID) VALUES('00003', 'cccc', 2) 
													
INSERT INTO Employee2(EmpID, EmpName, RoleID) VALUES('00004', 'dddd', 3) 

--Error: Referential Integrity
INSERT INTO Employee2(EmpID, EmpName, RoleID) VALUES('00005', 'eeee', 4) 

-- Join
SELECT e.EmpName, r.RoleName 
FROM employee2 e INNER JOIN Role r
ON e.RoleID = r.RoleID


/* ----------------------------------------------------------------------------------
D: PIVOT
*-----------------------------------------------------------------------------------*/
CREATE TABLE TestMember (userID char(02) PRIMARY KEY,userName varchar(20)) 
GO

CREATE TABLE TestProduct (productID char(02) PRIMARY KEY,productName varchar(20))

CREATE TABLE TestOrder(orderID int PRIMARY KEY,userID char(02),productID char(02),sellCount int)

INSERT INTO TestMember VALUES ('M1', 'jini')
INSERT INTO TestMember VALUES ('M2', 'jason')
INSERT INTO TestMember VALUES ('M3', 'boyd')
INSERT INTO TestMember VALUES ('M4', 'Phill')
INSERT INTO TestMember VALUES ('M5', 'Nick')
INSERT INTO TestProduct VALUES ('P1', 'bycycle')
INSERT INTO TestProduct VALUES ('P2', 'camera')
INSERT INTO TestProduct VALUES ('P3', 'notebook')
INSERT INTO TestOrder VALUES (1, 'M1', 'P1', 1)
INSERT INTO TestOrder VALUES (2, 'M2', 'P2', 2)
INSERT INTO TestOrder VALUES (3, 'M3', 'P1', 1)
INSERT INTO TestOrder VALUES (4, 'M3', 'P1', 1)
INSERT INTO TestOrder VALUES (5, 'M2', 'P3', 1)
INSERT INTO TestOrder VALUES (6, 'M1', 'P2', 3)
INSERT INTO TestOrder VALUES (7, 'M3', 'P1', 1)
INSERT INTO TestOrder VALUES (8, 'M1', 'P1', 2)
INSERT INTO TestOrder VALUES (9, 'M2', 'P3', 1)
INSERT INTO TestOrder VALUES (10, 'M1', 'P2', 1)

-- Order Count per customer
SELECT T2.userName, T3.productName, SUM(sellCount ) Total
FROM TestOrder T1 INNER JOIN TestMember T2 
ON T1.userID = T2.userIDINNER JOIN TestProduct T3 
ON T1. productID = T3. productID 
GROUP BY T2. userName , T3. productName 

-- what if we need "product column" as column and order count
SELECT * FROM
(
SELECT T2. userName , T3. productName , SUM(sellCount ) Total
FROM TestOrder T1 INNER JOIN TestMember T2 ON T1.userID = T2.userIDINNER JOIN TestProduct T3 
ON T1. productID = T3. productID 
GROUP BY T2. userName , T3. productName
) TPIVOT (SUM(Total) FOR productName IN (bycycle, camera, notebook) ) 
AS PVT

/* ----------------------------------------------------------------------------------
D: Ranking Function
Rank
Dens Rank
Row Number
Ntile
*-----------------------------------------------------------------------------------*/
CREATE TABLE Customer (
CustID int,
Name varchar(10),
Gender char(1),
Score int
)
GO

INSERT INTO Customer VALUES(1, 'Gilyong', 'M', 70)
INSERT INTO Customer VALUES(2, 'Deoken', 'M', 80)
INSERT INTO Customer VALUES(3, 'Juyeon', 'F', 60)
INSERT INTO Customer VALUES(4, 'Hodong', 'M', 70)
INSERT INTO Customer VALUES(5, 'Hyori', 'F', 90)
INSERT INTO Customer VALUES(6, 'Hani', 'F', 70)
INSERT INTO Customer VALUES(7, 'Minsoo', 'M', 50)
INSERT INTO Customer VALUES(8, 'MiJa', 'F', 90)
INSERT INTO Customer VALUES(9, 'ChoiGuk', 'M', 75)
INSERT INTO Customer VALUES(10, 'Kobong', 'M', 80)
GO

SELECT Name, Gender, Score 
FROM Customer
ORDER BY Score DESC
GO

SELECT Name, Gender, Score, 
RANK() OVER(ORDER BY Score DESC) AS ScoreRank
FROM Customer
GO

SELECT Name, Gender, Score, 
RANK() OVER(PARTITION BY Gender ORDER BY Score DESC) AS ScoreRank
FROM Customer
GO

SELECT Name, Gender, Score, 
DENSE_RANK() OVER(ORDER BY Score DESC) AS ScoreRank
FROM Customer
GO

SELECT Name, Gender, Score, 
DENSE_RANK() OVER(PARTITION BY Gender ORDER BY Score DESC) AS ScoreRank
FROM Customer
GO

SELECT ROW_NUMBER() OVER(ORDER BY Score DESC) AS RowNum, Name, Gender, Score
FROM Customer
GO

SELECT ROW_NUMBER() OVER(PARTITION BY Gender ORDER BY Score DESC) AS RowNum, Name, Gender, Score
FROM Customer
GO

SELECT NTILE(3) OVER(ORDER BY Score DESC) AS ScoreBand, Name, Gender, Score
FROM Customer
GO

SELECT NTILE(3) OVER(PARTITION BY Gender ORDER BY Score DESC) AS ScoreBand, Name, Gender, Score
FROM Customer
GO
