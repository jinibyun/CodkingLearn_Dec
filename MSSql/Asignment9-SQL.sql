-- 1. create stored procedure which accept following parameters
/*
au_id,
au_lname,
au_fname,
phone,
address,
city,
state,
zip,
contract
*/

-- inside procedure, it should insert authors table

 
CREATE PROCEDURE [dbo].[usp_authors_insert]
@au_id varchar(11),@au_lname varchar(40),@au_fname varchar(20),
@phone char(12),@address varchar(40),@city varchar(20),@state char(2),@zip char(5),@contract bit
AS BEGIN
INSERT INTO AUTHORS(au_id, au_lname,au_fname,phone, address,city,state,zip,contract) 
VALUES(@au_id,@au_lname,@au_fname,@phone,@address,@city,@state,@zip,@contract)
END
GO
-- EXECUTE
EXEC usp_authors_insert '998-70-2567','Shin','Dodam',4379817523,'51 maple Road','Toronto','ON','34234',TRUE;
GO





-- 2. Same idea as #1. create stored procedure which accept following parameters
/*

title_id
title
type
pub_id
price
advance
royalty
ytd_sales
notes
pubdate
*/

 -- inside procedure, it should insert titles table  

CREATE PROCEDURE [dbo].[usp_titles_insert]
@title_id varchar(6),@title varchar(80),@type char(12),@pub_id char(4),
@price money,@advance money,@royalty int,@ytd_sales int,@notes varchar(200),@pubdate datetime
ASBEGIN
INSERT INTO TITLES(title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate) 
VALUES(@title_id,@title,@type,@pub_id,@price,@advance,@royalty,@ytd_sales,@notes,@pubdate)
END
GO

-- EXECUTE
EXEC usp_titles_insert 'TA7773','Joy Luck Club','Fiction','0877',
31.5900,2275.0000,30,2045,'N/A','19890612';
GO



-- 3. Create another stored procedure which calls #1, #2 in sequence

-- CREATE
CREATE PROCEDURE dbo.usp_2procs_exe
AS
EXEC usp_authors_insert '818-90-7567','Kim','Jumi',4279817523,'21 maples Road','Toronto','ON','34234',TRUE
EXEC usp_titles_insert 'MM9303','Joy Luck Club5','Fiction','0877',11.9900,225.0000,30,2045,'N/A','19910712'
GO

-- ALTER
ALTER PROCEDURE dbo.usp_2procs_exe
AS
BEGIN
SET NOCOUNT ON;
BEGIN TRAN

BEGIN TRY
EXEC usp_authors_insert '777-90-7567','Lee','surim',4279817523,'2000 maples Road','Toronto','ON','34234',TRUE
EXEC usp_titles_insert 'CL9303','Joy Luck Club7','Fiction','0877',20.9900,225.0000,30,2045,'N/A','19910712'
-- if all of them is successful, then commit tran
COMMIT TRAN
END TRY

-- If one of them is failed to insert (authors or titles), then rollback tran
BEGIN CATCH
ROLLBACK TRAN
END CATCH

END

-- If one of them is failed to insert (authors or titles), then rollback tran
-- if all of them is successful, then commit tran

EXEC dbo.usp_2procs_exe
GO


-- 4. Research on whether you can use "try catch statement" in sql statement. (Copy and Paste is allowed)

IF OBJECT_ID('dbo.ErrorTracer') IS NOT NULL
BEGIN
	DROP TABLE dbo.ErrorTracer
	PRINT 'Table dbo.ErrorTracer Dropped'
END
GO

CREATE TABLE ErrorTracer
(
  iErrorID INT PRIMARY KEY IDENTITY(1,1),
  vErrorNumber INT,
  vErrorState INT,
  vErrorSeverity INT,
  vErrorLine INT,
  vErrorProc VARCHAR(MAX),
  vErrorMsg VARCHAR(MAX),
  vUserName VARCHAR(MAX),
  vHostName VARCHAR(MAX),
  dErrorDate DATETIME DEFAULT GETDATE()
)

IF OBJECT_ID('dbo.ErrorTracer') IS NOT NULL
BEGIN
	PRINT 'Table dbo.ErrorTracer Created'
END
GO

IF OBJECT_ID('Proc_InsertErrorDetails') IS NOT NULL
BEGIN
	DROP PROCEDURE [dbo].[Proc_InsertErrorDetails]
    PRINT 'Procedure Proc_InsertErrorDetails Dropped'
END
GO

CREATE PROCEDURE Proc_InsertErrorDetails
AS
/*
Purpose    : Insert the error details occurred in the SQL query
Input      : Insert the details which receives from the TRY...CATCH block
Output     : Insert the details of received errors into the ErrorTracer table
Created By : Senthilkumar
Created On : July 17, 2009
*/
BEGIN
  SET NOCOUNT ON 
  SET XACT_ABORT ON
  
  DECLARE @ErrorNumber VARCHAR(MAX)  
  DECLARE @ErrorState VARCHAR(MAX)  
  DECLARE @ErrorSeverity VARCHAR(MAX)  
  DECLARE @ErrorLine VARCHAR(MAX)  
  DECLARE @ErrorProc VARCHAR(MAX)  
  DECLARE @ErrorMesg VARCHAR(MAX)  
  DECLARE @vUserName VARCHAR(MAX)  
  DECLARE @vHostName VARCHAR(MAX) 

  SELECT  @ErrorNumber = ERROR_NUMBER()  
       ,@ErrorState = ERROR_STATE()  
       ,@ErrorSeverity = ERROR_SEVERITY()  
       ,@ErrorLine = ERROR_LINE()  
       ,@ErrorProc = ERROR_PROCEDURE()  
       ,@ErrorMesg = ERROR_MESSAGE()  
       ,@vUserName = SUSER_SNAME()  
       ,@vHostName = Host_NAME()  
  
INSERT INTO ErrorTracer(vErrorNumber,vErrorState,vErrorSeverity,vErrorLine,
	vErrorProc,vErrorMsg,vUserName,vHostName,dErrorDate)  
VALUES(@ErrorNumber,@ErrorState,@ErrorSeverity,@ErrorLine,@ErrorProc,
	@ErrorMesg,@vUserName,@vHostName,GETDATE())  
END
GO


IF OBJECT_ID('Proc_InsertErrorDetails') IS NOT NULL
BEGIN
    PRINT 'Procedure Proc_InsertErrorDetails Created'
END
GO

IF OBJECT_ID('Proc_ExceptionHandlingExample') IS NOT NULL
BEGIN
	DROP PROCEDURE [dbo].[Proc_ExceptionHandlingExample]
    PRINT 'Procedure Proc_ExceptionHandlingExample Dropped'
END
GO

CREATE PROCEDURE Proc_ExceptionHandlingExample
AS
BEGIN
/*
Purpose    : Sample procedure for check the Try...Catch
Output     : It will insert into ErrorTracer table if this 
			stored procedure throws any error
Created By : Senthilkumar
Created On : July 17, 2009
*/
   SET NOCOUNT ON
   SET XACT_ABORT ON
   
   BEGIN TRY
      SELECT 15/0
   END TRY
   BEGIN CATCH
      EXEC Proc_InsertErrorDetails
   END CATCH
END
GO

IF OBJECT_ID('Proc_ExceptionHandlingExample') IS NOT NULL
BEGIN
    PRINT 'Procedure Proc_ExceptionHandlingExample Created'
END
GO

EXEC Proc_ExceptionHandlingExample
GO

SELECT * FROM ErrorTracer;



-- 5. Apply "try catch statement" to above #3 statement to better exception handling



-- 6. Create sql function. Parameter should be one type of varchar(max). 
      -- If this parameter contains ' (single quotation), it should replace it with empty string and return it
      -- (one varchar parameter, one varchar return)
	 CREATE FUNCTION dbo.replaceVarchar(@input VARCHAR(MAX))
	 RETURNS VARCHAR(MAX)
	 AS BEGIN
	 DECLARE @param1 VARCHAR(MAX)
	 SET @param1 = @input
	 SET @param1 = REPLACE(@param1,'''','')	 
	 RETURN @param1
	 END
	 GO 

	


-- 7. Show statement for testing #6 function.

 SELECT dbo.replaceVarchar('someone''s responsibility')
 GO 

-- 8. Then modify #2 stored proc as follows:
-- As define, one of parameters is "notes" which take some note information. 
-- When calling this sp to insert titles, you need to pass note containing ' (single quotation) 
--such as : someone's responsibility  

-- However, we need to call #6 function from this stored proc in order to replace single quotation with empty string.

-- In other words, Inside stored proc, call function

CREATE PROCEDURE dbo.callingFunction
(@firstParam VARCHAR(MAX))

AS
BEGIN
DECLARE @setval VARCHAR(MAX)
SELECT dbo.replaceVarchar(@firstParam)
END
GO

DECLARE  @return_value int
EXEC  @return_value = dbo.callingFunction
      @firstParam = 'Jane''s message''s key'
