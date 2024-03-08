create database StudentMng;

create table Class (
	ClassID int primary key identity(1,1),
	Name nvarchar(256),
	[Desc] nvarchar(256),
);

create table Student(
	StudentID int primary key identity(1,1),
	ClassID int null,
	Name nvarchar(256),
	DOB datetime,
	Code nvarchar(32),
	Math int null,
	Phys int null,
	constraint FK_Student_Class foreign key (ClassID) references Class(ClassID)
);

INSERT INTO Class (Name, [Desc])
VALUES
    ('Class A', 'Description for Class A'),
    ('Class B', 'Description for Class B'),
	('Class C', 'Description for Class C'),
	('Class D', 'Description for Class D'),
	('Class E', 'Description for Class E');



INSERT INTO Student (ClassID, Name, DOB, Code, Math, Phys)
VALUES
    (1, 'Nguyen Duy A', '01-11-2001', 'SV0001', 8.0, 7.5),
    (1, 'Hoang Duy B', '01-11-2001', 'SV0002', 8.8, 9.2),
	(1, 'Nguyen Duy C', '01-11-2001', 'SV0003', 4.5, 2.5),
    (1, 'Nguyen Duy D', '01-11-2001', 'SV0004', 5.7, 6.2),
	(2, 'Nguyen Van A', '01-11-2001', 'SV0005', 6.7, 7.5),
	(2, 'Hoang Van B', '01-11-2001', 'SV0006', 8.0, 8.5),
    (2, 'Nguyen Van C', '01-11-2001', 'SV0007', 7.8, 8.2),
	(2, 'Nguyen Van D', '01-11-2001', 'SV0008', 7.5, 7.5),
    (2, 'Nguyen Van E', '01-11-2001', 'SV0009', 7.8, 8.2),
    (3, 'Nguyen Huu A', '01-11-2001', 'SV0010', 6.8, 7.2),
	(3, 'Hoang Huu B', '01-11-2001', 'SV0011', 5.6, 6.5),
	(3, 'Nguyen Huu C', '01-11-2001', 'SV0012', 8.4, 7.9),
    (3, 'Nguyen Huu D', '01-11-2001', 'SV0013', 7.4, 6.2),
	(4, 'Hoang Thi A', '01-11-2001', 'SV0014', 3.6, 4.5),
    (4, 'Nguyen Thi B', '01-11-2001', 'SV0015', 8.6, 9.2),
	(4, 'Hoang Thi C', '01-11-2001', 'SV0016', 7.0, 7.5),
    (4, 'Nguyen Thi D', '01-11-2001', 'SV0017', 9.0, 9.2),
	(4, 'Hoang Duy E', '01-11-2001', 'SV0018', 6.0, 6.5),
    (5, 'Nguyen Duy F', '01-11-2001', 'SV0019', 9.8, 9.5),
	(5, 'Hoang Thanh G', '01-11-2001', 'SV0020', 5.5, 6.5),
    (5, 'Nguyen Duy H', '01-11-2001', 'SV0021', 6.5, 6.2),
    (5, 'Hoang Duy Y', '01-11-2001', 'SV0022', 7.8, 8.0);

	select * from Student;

	select * from Student where Code = 'SV0001';

	select * from Student where Phys<4;

	select * from Student where Phys<5 and Math<5;

	update Student 
	set Math = Math + 1;

	update Student 
	set Phys = Phys + 1
	where Phys<4;

	update Student 
	set Phys = Phys + 1, Math = Math + 1
	where Phys<5 and Math<5;

	delete from Student where Code = 'SV0001';

	select COUNT(*) from Student where Phys<4 ;

	select COUNT(*) from Student where Phys<5 and Math<5 ;

	select COUNT(*) from Student where Phys+Math<10 ;

	select Name, (Math+Phys) as TongDiem from Student;

	select SUM(Math) as TongDiemToan from Student;

	select SUM(Math)/COUNT(*) as DiemToanTB from Student;

	select top 2 Name, Math from Student order by Math desc; 

	select top 2 Name, Phys from Student order by Math asc;
	
	select top 2 Name, (Math+Phys) as TongDiem from Student order by Math+Phys desc;

	select Class.Name as 'Tên lớp', Student.Name  as 'Tất cả thông tin còn lại của SV'
	from Student 
	left join Class on Student.ClassID = Class.ClassID
	order by Student.ClassID;

	select Class.Name as 'Tên lớp', count(Student.ClassID) as 'Số sinh viên'
	from Class
	left join Student on Class.ClassID = Student.ClassID
	group by Class.Name;
	