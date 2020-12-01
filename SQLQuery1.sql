create database Orchid;--f5 / Alt + x
use Orchid;
create table student(
Id int identity,
Name Varchar(500),
Email Varchar(300),
Address Varchar(300),
Gender Varchar(1),--M,F,O
DOB datetime,
IsActive bit,
IsDeleted bit,
CreatedDate datetime,
CreatedBy int,
UpdatedDate datetime,
UpdatedBy int,

constraint pk_student_id primary key(Id),
constraint check_gender check (Gender='M' OR Gender='F' OR Gender='O')
);