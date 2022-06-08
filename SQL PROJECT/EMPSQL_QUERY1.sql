CREATE TABLE EMPLOYEE(ID INT PRIMARY KEY NOT NULL,
NAME NVARCHAR(20) NOT NULL,
GENDER NVARCHAR(25) NOT NULL,
SALARY INT NOT NULL,
DEPARTMENTID INT);
SELECT * FROM EMPLOYEE;
INSERT INTO EMPLOYEE VALUES(1,'TOM','MALE',4000,1);
INSERT INTO EMPLOYEE VALUES(2,'VARA','FEMALE',5000,3);
INSERT INTO EMPLOYEE VALUES(3,'ALEE','FEMALE',4500,1);
INSERT INTO EMPLOYEE VALUES(4,'MANJU','MALE',3500,2);
INSERT INTO EMPLOYEE VALUES(5,'HARII','FEMALE',7000,2);
INSERT INTO EMPLOYEE VALUES(6,'ASHOK','MALE',8500,1);
INSERT INTO EMPLOYEE VALUES(7,'ANIL','MALE',2800,3);
INSERT INTO EMPLOYEE VALUES(8,'PRAKHYA','FEMALE',6500,1);
INSERT INTO EMPLOYEE(ID,NAME,GENDER,SALARY) VALUES(9,'JAMES','MALE',9000);
INSERT INTO EMPLOYEE (ID,NAME,GENDER,SALARY)VALUES(10,'SUMMU','FEMALE',4000);

TRUNCATE TABLE EMPLOYEE;