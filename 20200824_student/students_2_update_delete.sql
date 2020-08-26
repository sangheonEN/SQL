select * from student;

select idx from student; -- 하나의 칼럼

select max(idx)+1 as idx from student; -- 가장 큰 idx를 as를 명명해주고 

--sequence 순서
--primary key 기본키
insert into student 
(name, age, idx, grade)
values
('남기경', 38, (select max(idx)+1 as idx from student), 4);

------------------------------------------------------------------------------------------------------------------

-- 모든 테이블 수정 
update student                 
set name = '200번째손님'                 -- 모든 name 칼럼이 200번째손님으로 변경됨

--조건을 걸어 수정 : 조건 where절 추가
update student                 
set name = '이상헌천재', age = 4, grade = 3
where idx = 200;


-- 삭제
delete from student
where idx = 200;