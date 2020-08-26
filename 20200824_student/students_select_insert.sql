USE [test_20200824]
GO

/****** Object:  Table [dbo].[student]    Script Date: 2020-08-24 오후 12:19:59 ******/
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
('이상헌', 27, 1, 3),
('김하영', 25, 2, 2),
('박순홍', 27, 3, 1),
('박해광', 27, 4, 4);


-- 하이 쿼리

select max(idx)+1 as idx from student; -- as를 사용하여 idx 칼럼을 명명하고 max()함수를 이용하여 가장 높은 index + 1에 접근함.
