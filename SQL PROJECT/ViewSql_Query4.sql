
CREATE VIEW VMEMPLOYEEBYDEPARTMENT
AS
SELECT NAME,GENDER,SALARY,DEPARTMENTNAME
FROM EMPLOYEE 
JOIN DEPARTMENT
ON EMPLOYEE.DEPARTMENTID=DEPARTMENT.ID;

SELECT * FROM VMEMPLOYEEBYDEPARTMENT;

CREATE VIEW VMITEMPLOYEE
AS
SELECT NAME,GENDER,SALARY,DEPARTMENTNAME
FROM EMPLOYEE 
JOIN DEPARTMENT
ON EMPLOYEE.DEPARTMENTID=DEPARTMENT.ID
WHERE DEPARTMENT.DEPARTMENTNAME='IT'

SELECT * FROM VMITEMPLOYEE;

CREATE VIEW VMLOCATIONDEPARTMENT
AS
SELECT NAME,GENDER,SALARY,DEPARTMENTNAME
FROM EMPLOYEE 
JOIN DEPARTMENT
ON EMPLOYEE.DEPARTMENTID=DEPARTMENT.ID
WHERE DEPARTMENT.DEPARTMENTNAME='HR'

SELECT * FROM VMLOCATIONDEPARTMENT


