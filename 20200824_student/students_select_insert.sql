USE [test_20200824]
GO

/****** Object:  Table [dbo].[student]    Script Date: 2020-08-24 ���� 12:19:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[student](
	[name] [varchar](50) NULL,
	[age] [numeric](18, 0) NULL,
	[idx] [numeric](18, 0) not NULL,
	[grade] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

drop table student;

alter table student add constraint idx primary key(idx)  

select * from student;

select idx from student;

insert into student
(name, age, idx, grade)
values
('�̻���', 27, 1, 3),
('���Ͽ�', 25, 2, 2),
('�ڼ�ȫ', 27, 3, 1),
('���ر�', 27, 4, 4);


-- ���� ����

select max(idx)+1 as idx from student; -- as�� ����Ͽ� idx Į���� ����ϰ� max()�Լ��� �̿��Ͽ� ���� ���� index + 1�� ������.
