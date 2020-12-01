--ex7) 설강테이블에서 교수명이 김으로 시작하는 정보의 교수명,과목명을 구하시오.
-- like에 대해서 질문! like '김%' 하면 교수명에 김이 들어간 모든 것을 얘기하는것인가? replace 권김영으로 바꾼 Table을 참조하는데 왜안되지?
-- like 
select A from (select replace(교수명, '권오영', '권김영') A from 설강) A      -- 서브쿼리 : 새로운 TABLE을 만들어
where A like '_김%';
select replace(교수명, '권오영', '권김영') from 설강;

--ex8) 설강테이블에서 교수명이 이로 시작하면서 두자리인 교수명과 과목명을 구하시오. count 사용해서 교수명의 자리수 출력? length함수 사용
select 교수명, 과목명 from 설강
where 교수명 like '이%' and count(교수명) = 2;



