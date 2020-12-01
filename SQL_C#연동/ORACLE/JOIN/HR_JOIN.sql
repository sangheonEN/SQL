select * from 학생;
select * from 수강;
select * from 설강;

select 학번, AVG(신장) as 신장 from 학생 group by 학번;                        --1번

select 소속, sum(신장) as sum, Round(avg(신장),2) as avg, max(신장) as max, min(신장) as min, count(신장) as count from 학생 group by 소속;    --2번

select 학번, avg(성적) from 수강 group by 학번 order by avg(성적) desc;                 --3번

select count(학번) from 수강 where 번호 = 102;     -- 4번

select 학번, count(학번) from 수강 group by 학번 having count(*) >= 3;            --5번

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- inner join 

select A.학번, B.성적 from 학생 
A INNER JOIN 수강 B
ON A.학번 = B.학번
ORDER BY B.성적 DESC;           -- 학생 테이블을 A로 칭하자! 수강 테이블을 B로 칭하자!

select A.이름 from 사원 A INNER JOIN 대출 B ON A.사번 = B.사번;

-- left join, right join                          -- 
select B.사번, B.이름, A.도서
FROM 대출 A LEFT OUTER JOIN 사원 B
ON A.사번 = B.사번;

select A.사번, A.이름, B.도서
FROM 사원 A LEFT OUTER JOIN 대출 B
ON A.사번 = B.사번;

-- 테이블 A RIGHT OUTER JOIN 테이블 B
-- 테이블 사원 테이블 기준으로 사원 테이블에 연관된 내용이 없더라도 도서를 출력한다 예를들어(대출 테이블의 도서 대출 사번에 해당되는 내용이 없어도 그 사원도 사번, 이름, 도서를 출력하게한다.
select B.사번, B.이름, A.도서 
from 대출 A right outer join 사원 B
ON A.사번 = B.사번;

-- 반대로 대출 테이블의 도서 대출 사번에 해당되는 내용이 없으면 그 사원의 정보는 출력하지 않는다.
select A.사번, A.이름, B.도서 
from 사원 A right outer join 대출 B
ON A.사번 = B.사번;

SELECT * FROM 사원;
SELECT * FROM 대출;

-- self join

select * from employees;

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

select * from 학생;
select * from 수강;
select * from 설강;

-- Q1) 이길동 학생이 수강한 교수명과 성적을 구하시오. 
-- 각 테이블별로 JOIN할 수 있는 연결고리(기준)을 만들어서 표현해줌.     
-- 학생 테이블의 이길동, 수강 테이블의 성적, 설강 테이블의 교수명
select 성적, 교수명 from 학생 A INNER JOIN 수강 B ON A.학번 = B.학번 INNER JOIN 설강 C ON B.번호 = C.번호            -- 학생테이블을 A 수강테이블을 B해서 A와 B테이블의 학번을 기준으로 JOIN해서 이길동학생의 학번을 고를 수 있고 설강테이블을 C로 칭하여 이길동학생의 교수를 구할 수 있다!
where A.학번 = 07033;           -- 학번 기준으로 출력

select B.성적, C.교수명, A.이름 From 학생 A, 수강 B, 설강 C       -- 같은 칼럼이 있을 수 있음으로 SELECT 뒤 명령 구문은 B.성적, C.교수명, A.이름
where A.학번 = B.학번 AND B.번호 = C.번호
AND A.이름 = '이길동';

select 성적, 교수명 from 학생 A INNER JOIN 수강 B ON A.학번 = B.학번 INNER JOIN 설강 C ON B.번호 = C.번호
where A.이름 = '이길동';         -- 이름 기준으로 출력
   
-- Q2) 최씨성을 갖는 학생의 모든정보를 구하라.

select * from 학생;
select * from 수강;
select * from 설강;

select * from 학생 A INNER JOIN 수강 B ON A.학번 = B.학번 INNER JOIN 설강 C ON B.번호 = C.번호
WHERE A.이름 LIKE '최%';

-- Q3) 최길동 학생의 학년,이름,과목번호,성적을 구하시오.

select * from 학생;
select * from 수강;
select * from 설강;

select A.학년, A.이름, C.번호, B.성적 from 학생 A INNER JOIN 수강 B ON A.학번 = B.학번 INNER JOIN 설강 C ON B.번호 = C.번호
WHERE A.이름 = '최길동';















