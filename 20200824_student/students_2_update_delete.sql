select * from student;

select idx from student; -- �ϳ��� Į��

select max(idx)+1 as idx from student; -- ���� ū idx�� as�� ������ְ� 

--sequence ����
--primary key �⺻Ű
insert into student 
(name, age, idx, grade)
values
('�����', 38, (select max(idx)+1 as idx from student), 4);

------------------------------------------------------------------------------------------------------------------

-- ��� ���̺� ���� 
update student                 
set name = '200��°�մ�'                 -- ��� name Į���� 200��°�մ����� �����

--������ �ɾ� ���� : ���� where�� �߰�
update student                 
set name = '�̻���õ��', age = 4, grade = 3
where idx = 200;


-- ����
delete from student
where idx = 200;