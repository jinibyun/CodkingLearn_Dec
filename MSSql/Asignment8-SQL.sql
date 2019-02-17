-- 1. Inner Join Statement
-- Scenario: we need following data. We need to join 5 tables.

-- title and type from titles table, 
-- pub_name from publishers, 

-- qty and paytersm from sales, 
-- name from stores, 
-- discounttype from discounts  table

SELECT DISTINCT T.TITLE,T.TYPE,P.PUB_NAME,S.QTY,S.PAYTERMS,ST.STOR_NAME,D.DISCOUNTTYPE
FROM TITLES T
INNER JOIN PUBLISHERS P
ON T.PUB_ID=P.PUB_ID
INNER JOIN SALES S
ON T.PUB_ID=P.PUB_ID
INNER JOIN STORES ST
ON ST.STOR_ID=S.STOR_ID
INNER JOIN DISCOUNTS D
ON ST.STOR_ID=D.STOR_ID



-- 2. Outer Join Statement (Left Ourter Join)
-- Scenario: Between Stores and Discounts table
-- Not all stores have discount information. Select "only" stores which does "NOT" have discount

SELECT * FROM STORES;
SELECT * FROM DISCOUNTS;

SELECT STORES.STOR_ID,STORES.STOR_NAME,DISCOUNTS.DISCOUNTTYPE
FROM STORES LEFT JOIN DISCOUNTS
ON STORES.STOR_ID = DISCOUNTS.STOR_ID
WHERE DISCOUNTS.DISCOUNTTYPE IS NULL



-- 3. Run this, then you will get sale count per store.
select TOP 2 WITH TIES t1.stor_id,count(*) salesCount 
from sales t1
group by t1.stor_id
ORDER BY SALESCOUNT DESC
/* 
result would be
6380	2
7066	2
7067	4
7131	6
7896	3
8042	4
*/

-- Get only second top sale's store (from result, we know 7067 and 8042 )
-- TIP: use "top", "order by", and following hint: you can make it sub query in where clauses

SELECT TOP 2 WITH TIES * FROM 
(SELECT TOP 2 WITH TIES T1.STOR_ID, COUNT(*) SALESCOUNT 
FROM SALES T1 GROUP BY T1.STOR_ID ORDER BY SALESCOUNT DESC) AS SUBQRY
ORDER BY SALESCOUNT 

-- 4. Change following sub query to inner join statement
--SELECT * FROM titles
--WHERE title_id IN (SELECT title_id FROM sales)
--ORDER BY TITLES.TITLE_ID

SELECT DISTINCT TITLES.* FROM TITLES
INNER JOIN SALES
ON TITLES.TITLE_ID = SALES.TITLE_ID
ORDER BY TITLES.TITLE_ID

-- 5. self join : research on it and exercise (copy  & paste is allowed)

SELECT * FROM EMPLOYEE
SELECT YEAR(HIRE_DATE) FROM EMPLOYEE

SELECT A.FNAME AS EMPLOYEE1, B.FNAME AS EMPLOYEE2, YEAR(A.HIRE_DATE) AS HIREYEAR
FROM EMPLOYEE A, EMPLOYEE B
WHERE A.EMP_ID <> B.EMP_ID
AND YEAR(A.HIRE_DATE) = YEAR(B.HIRE_DATE)

-- 6. We are building table "ServiceDepot" where user request service for repair. 
--For that business, we need following two tables: Customers and Request tables.

-- 6-1. For "Customer" table, please consider following:
	-- 1. use Script (Create table script)
	-- 2. define following columns. 
       -- Id, UserName, Email,Password, FirstName, LastName, MiddleName, Address1,Address2, City, PostalCode, Province, Country
	   -- HomePhone, MobilePhone, RegisterDate, FBAccount, TwitterAccount		
	-- 3. Each column should have proper data type and null or not null constraints. Make Id as PK and Identity(1,1)

CREATE TABLE CUSTOMERS(
ID INT IDENTITY (1,1),
PRIMARY KEY (ID),
userName VARCHAR(20) NOT NULL,
eMail VARCHAR(30) NOT NULL,
firstName VARCHAR(30) NOT NULL,
lastName VARCHAR(30) NOT NULL,
middleName VARCHAR(30),
address1 VARCHAR(100),
address2 VARCHAR(100),
city VARCHAR(30),
postalCode VARCHAR(6),
province VARCHAR(20),
country VARCHAR(50),
homePhone VARCHAR(10),
mobilePhone VARCHAR(10),
registerDate DATETIME,
fbAccount VARCHAR(50),
twitterAccount VARCHAR(50)
);

-- 6-2. For "Request" table, please consider following:
	-- 1. use Script (Create table script)
	-- 2. define following columns.
		-- Id, CustomerId, RequestContent, RequestDate, CompletedDate, 
		-- Status, Comment, IsNotifiedToCustomer, IsNotifiedToTechnician
	-- 3. Each column should have proper data type and null or not null constraints. 
	    -- Make Id as PK and Identity(1,1) and CustomerId as FK (CustomerId must refer to Request table's Id) .
	    -- Do not use any UI menu. All should be done with "SQL Script"

CREATE TABLE REQUEST(
ID INT IDENTITY (1,1),
PRIMARY KEY (ID),
customerID VARCHAR(20) NOT NULL,
requestContent TEXT NOT NULL,
requestDate datetime NOT NULL,
completedDate datetime,
status VARCHAR(30),
comment TEXT,
IsNotifiedToCustomer CHAR(1) NOT NULL DEFAULT 'N'
CONSTRAINT CheckNotifiedToCustomer CHECK (IsNotifiedToCustomer IN('Y','N')),
IsNotifiedToTechnician CHAR(1) NOT NULL DEFAULT 'N'
CONSTRAINT CheckNotifiedToTech CHECK (IsNotifiedToTechnician IN('Y','N')),
);


ALTER TABLE REQUEST
ALTER COLUMN CUSTOMERID INT

ALTER TABLE REQUEST
ADD FOREIGN KEY (CUSTOMERID) REFERENCES CUSTOMERS(ID);


-- 7. Insert two customers using insert statement
INSERT INTO CUSTOMERS
(USERNAME,EMAIL, FIRSTNAME,LASTNAME,MIDDLENAME,
ADDRESS1,ADDRESS2,CITY, POSTALCODE,PROVINCE,COUNTRY,
HOMEPHONE,MOBILEPHONE,REGISTERDATE,FBACCOUNT,TWITTERACCOUNT)
VALUES('DODAMS','DODAM@GMAIL.COM','DODAM','SHIN',NULL,
'UNIT 32','912 MAPLE ROAD','TORONTO','M8M9N4','ONTARIO','CANADA',
NULL,'4379817523','20120618',NULL,NULL);

INSERT INTO CUSTOMERS
(USERNAME,EMAIL, FIRSTNAME,LASTNAME,MIDDLENAME,
ADDRESS1,ADDRESS2,CITY, POSTALCODE,PROVINCE,COUNTRY,
HOMEPHONE,MOBILEPHONE,REGISTERDATE,FBACCOUNT,TWITTERACCOUNT)
VALUES('SONGS','SOM@GMAIL.COM','SONGEY','SHIN',NULL,
'307-90','912 SEJONGRO','SEOUL','389832',NULL,'KOREA',
NULL,'1089773232','20170627',NULL,NULL);



-- 8. Insert four request (two request per one customer)
INSERT INTO REQUEST
(CUSTOMERID,REQUESTCONTENT, REQUESTDATE,COMPLETEDDATE,
STATUS,COMMENT,ISNOTIFIEDTOCUSTOMER,ISNOTIFIEDTOTECHNICIAN)
VALUES(1,'PRINTER ERROR','2019-02-17','2019-02-23',
'COMPLETED','GOOD','Y','Y');

INSERT INTO REQUEST
(CUSTOMERID,REQUESTCONTENT, REQUESTDATE,COMPLETEDDATE,
STATUS,COMMENT,ISNOTIFIEDTOCUSTOMER,ISNOTIFIEDTOTECHNICIAN)
VALUES(1,'PRINTER ERROR AGAIN','2019-03-12','2019-03-23',
'COMPLETED','N/A','Y','Y');

INSERT INTO REQUEST
(CUSTOMERID,REQUESTCONTENT, REQUESTDATE,COMPLETEDDATE,
STATUS,COMMENT,ISNOTIFIEDTOCUSTOMER,ISNOTIFIEDTOTECHNICIAN)
VALUES(4,'MOBILE PHONE ERROR AGAIN','2019-03-23','2019-03-27',
'COMPLETED','N/A','Y','Y');

-- 9. "Referential Integrity" confirmation
-- Confirm following: 
-- Delete from Customer should throw "error" (This is expected behavior)
-- Insert into request (with CustomerId as 99 which does not exist in Customer) should throw "error" (This is expected behavior)

DELETE FROM CUSTOMERS

INSERT INTO REQUEST
(CUSTOMERID,REQUESTCONTENT, REQUESTDATE,COMPLETEDDATE,
STATUS,COMMENT,ISNOTIFIEDTOCUSTOMER,ISNOTIFIEDTOTECHNICIAN)
VALUES(99,'MOBILE PHONE ERROR AGAIN','2019-03-23','2019-03-27',
'COMPLETED','N/A','Y','Y');

