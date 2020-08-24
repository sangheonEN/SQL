CREATE TABLE [dbo].[Test_Table] (
    [Name]   VARCHAR (50) NULL,
    [age]    NUMERIC (18) NULL,
    [remark] VARCHAR (50) NULL,
    [idx]    NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_Test_Table] PRIMARY KEY CLUSTERED ([idx] ASC)
);



