/* 
5-1 authors table
Lastname should be start 'A', or 'B' or 'C' (case-insensitive) and order by city descending 
*/

SELECT * FROM authors
WHERE au_lname LIKE 'A%' OR 
      au_lname LIKE 'B%' OR
	  au_lname LIKE'C%'
ORDER BY CITY DESC;

/* 
5-2. publishers table
country should be only 'USA' and get record only 3 
*/

SELECT TOP 3 * FROM PUBLISHERS
WHERE COUNTRY='USA'

/*
5-3. stores table, 
stores is located in several state. Get state information (no duplication)
*/

SELECT DISTINCT STATE FROM STORES;

/*  discounts table
5-4  We have three discount options in discounts table
Which option has the highest discount rate and what is the discount value? */

SELECT  * FROM DISCOUNTS
WHERE DISCOUNT IN (SELECT MAX(DISCOUNT)  FROM DISCOUNTS)

/*
5-5 Also write query discount is more than 5.5 and less than 8.0
*/

SELECT * FROM DISCOUNTS 
WHERE DISCOUNT >5.5 AND DISCOUNT <8.0

/* sales table  (use group by)
5-6. average qty per store and average should be more than 20 and order by store id descending */

SELECT STOR_ID,AVG(QTY) AS 'AVG QTY'
FROM SALES
GROUP BY STOR_ID
HAVING AVG(QTY) >20
ORDER BY STOR_ID DESC;


/*5-7. sum qty per title and qty should be more than 10 and order by title id ascending*/
SELECT TITLE_ID,SUM(QTY) AS 'SUM QTY'
FROM SALES
GROUP BY TITLE_ID
HAVING SUM(QTY) >10
ORDER BY TITLE_ID ASC;

/*5-8. sum qty per year (may use date function as well)*/
SELECT DATEPART(YEAR,ORD_DATE) AS 'YEAR',SUM(QTY) AS 'QTY'
FROM SALES
GROUP BY DATEPART(YEAR,ORD_DATE)

/*5-9. avg qty per year and month (may use date function as well)*/

SELECT CONVERT(VARCHAR(7),ORD_DATE,126) AS 'YEAR',AVG(QTY) AS 'AVG QTY'
FROM SALES
GROUP BY CONVERT(VARCHAR(7),ORD_DATE,126)

/* 5-10. which book is least sold out? showing title id and qty (one record)*/
SELECT * FROM SALES;

SELECT TOP 1 TITLE_ID,SUM(QTY) AS 'SALES QTY'
FROM SALES
GROUP BY TITLE_ID
ORDER BY SUM(QTY) ASC;

/*5-11. which book is most sold out? showing title id and qty (one record)*/

SELECT TOP 1 TITLE_ID,SUM(QTY) AS 'SALES QTY'
FROM SALES
GROUP BY TITLE_ID
ORDER BY SUM(QTY) DESC;

