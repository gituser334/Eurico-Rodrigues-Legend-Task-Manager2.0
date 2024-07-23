Drop database if exists TaskManager;
create database TaskManager;
Drop table if exists Tasks;
Create table Tasks (
TaskName varchar(90),
Descriptions varchar(90),
Statuses varchar(90),
DueDate date,
);

insert into Tasks (TaskName, Descriptions, Statuses, DueDate)
values ('Website Redesign', 'Redesign the company website', 'In Progress', '2023-06-15');
insert into Tasks (TaskName, Descriptions, Statuses, DueDate)
values ('Product Launch', 'Plan the launch of new products', 'Pending', '2023-08-20');
insert into Tasks (TaskName, Descriptions, Statuses, DueDate)
values ('Quaterly Report', 'Prepare the financial report', 'Completed', '2023-07-31');

select * from Tasks;