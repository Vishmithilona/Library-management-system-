Create table Account(
	AccountID int primary key,
	Name varchar (100),
	Address text,
	PhoneNo varchar (15),
	Email varchar (100),
	Username varchar (50) unique,
	Password varchar (50)
);
Select * FROM Account


insert into Account values (1,'Nirosha karunartha', '234 main street,kandy','0712234578','Niro@gmail.com','Niro','Ni234kr87');
insert into Account values (2,'Gamini','156 Pine Rd', '0751230983','Gami@gmail.com','Gami21','Ga67hg45');
insert into Account values (3,'Anuka perera','A/23 Mawanalla Rd', '0759876532','Anu@gmail.com','Anu00','An67nH00');
insert into Account values (4,'Dewmi gamage','19 Perad9eniya', '0721239874','Dew@gmail.com','Dew46','De67mi12');
insert into Account values (5,'Nimal','209 Mape street', '0714568732','Nim@gmail.com','Nim237','Ni67mf34');
insert into Account values (6,'Dharaka Manohara','B/234 Katugasthota,Kandy', '0720943756','Dha@gmail.com','Dhara102','DH67ma65');
insert into Account values (7,'sihan','90 birch Rd', '0725467812','Sih@gmail.com','Sih90','Si12bd3y');
insert into Account values (8,'Harry Lee','009 Oak way', '0702349871','Harr@gmail.com','Harr34','Har12xdd4');
insert into Account values (9,'Jack Brown','9/A Cedar street', '0701267534','Jack@gmail.com','Jack20','Jack23pp0');
insert into Account values (10,'Methmi','02 Elm Rd', '0713478234','Meth@gmail.com','Meth123','Meth23jb3');

Create table Member (
	AccountID int primary key,
	memberID int unique,
	MembershipDate Date,
	foreign key (AccountID) references Account(AccountID)
	);

 select * from Member

 insert into Member values (1,1001, '2023-04-13');
 insert into Member values (2,1002, '2024-09-23');
 insert into Member values (3,1003, '2025-05-25');
 insert into Member values (4,1004, '2024-03-18');
 insert into Member values (5,1005, '2023-08-02');
 insert into Member values (6,1006, '2025-12-09');
 insert into Member values (7,1007, '2022-11-17');
 insert into Member values (8,1008, '2023-07-30');
 insert into Member values (9,1009, '2023-06-26');
 insert into Member values (10,1010, '2025-04-04');

 Drop table  Member
 

 Create table Librarian (
	 AccountID int primary key,
	 LibrarianID int unique,
	 Role varchar (50),
	 HiredDate Date,
	 Foreign key (AccountID) references Account(AccountID)
 );

 select * from Librarian

 insert into Librarian values (1,2001,'Senior Librarian', '2023-04-09');
 insert into Librarian values (2,2002,'Technical Librarian', '2023-04-09');
 insert into Librarian values (3,2003,'Research Librarian', '2023-04-09');
 insert into Librarian values (4,2004,'Manager', '2023-04-09');
 insert into Librarian values (5,2005,'Junior Librarian', '2023-04-09');
 insert into Librarian values (6,2006,'Reference Librarian', '2023-04-09');
 insert into Librarian values (7,2007,'Staff', '2023-04-09');
 insert into Librarian values (8,2008,'Digital services', '2023-04-09');
 insert into Librarian values (9,2009,'Assistant Librarian', '2023-04-09');
 insert into Librarian values (10,2010,'Collection services', '2023-04-09');

 Create table Book (
 BookID int primary key,
 Title varchar (200),
 Genre varchar (100),
 ISBN varchar (20) unique,
 PublishedDate Date
 );

 select * from Book

insert into Book values (20,'To Kill a mockingbird','Classic','9765342112309','1960-07-11');
insert into Book values (21,'1984','Dystopian','9712345609876','1949-06-08');
insert into Book values (22,'The Alchemist','Adventure','9756321876543','1988-04-15');
insert into Book values (23,'The Hobbit','Fantasy','9709812365432','1949-06-08');
insert into Book values (24,'Moby Dick','Adventure','9705678763213','1937-09-21');
insert into Book values (25,'The great gastby','Classic','9812347654890','1925-04-10');
insert into Book values (26,'War and peace','Historical','9776512567892','1849-01-01');
insert into Book values (27,'The catcher in the Rye','Coming-of-age','9734561298763','1951-07-16');
insert into Book values (28,'Pride and prejudice','Romance','9771234098123','1813-01-28');
insert into Book values (29,'Harry potter','Fantasy','9711123455678','1997-06-26');


Create table BookCopy(
	CopyID int primary key,
	BookID int,
	Condition varchar(50),
	Foreign key (BookID) references Book(BookID)
);
Select * from BookCopy

insert into BookCopy values(30,20,'Good');
insert into BookCopy values(31,21,'Fair');
insert into BookCopy values(32,22,'Good');
insert into BookCopy values(33,23,'Excellent');
insert into BookCopy values(34,24,'Fair');
insert into BookCopy values(35,25,'Good');
insert into BookCopy values(36,26,'Excellent');
insert into BookCopy values(37,27,'Excellent');
insert into BookCopy values(38,28,'Good');
insert into BookCopy values(39,29,'poor');

Create table Borrow (
	MemberID int,
	CopyID int,
	ScheduledBorrowdate Date, 
	ScheduledReturndate Date,
	ReturnStatus varchar (50),
	Fine decimal (10,2),
	Overdue Boolean,
	CurrentStatus varchar (50),
	Primary key (MemberID, CopyID),
	Foreign key (MemberID) references Member(MemberID),
	Foreign key (CopyID) references BookCopy(CopyID)
);

select * from Borrow
drop table Borrow

Create table Borrow (
	MemberID int,
    CopyID int,
    ScheduledBorrowDate date,
    ScheduledReturnDate date,
    ReturnStatus varchar(50),
    Fine decimal(10,2),
    Overduedate date,
    CurrentStatus varchar (50),
    primary key (MemberID, CopyID),
    foreign key (MemberID) references Member(MemberID),
    foreign key (CopyID) references BookCopy(CopyID),
);

insert into Borrow values(1001,30,'2025-03-01','2025-03-20','Returned','0.00','2024-02-09','Available');
insert into Borrow values(1002,31,'2025-04-13','2025-04-30','Not Returned','23.00','2024-03-10','Borrowed');
insert into Borrow values(1003,32,'2025-03-05','2025-03-19','Returned','0.00','2024-04-23','Available');
insert into Borrow values(1004,33,'2025-05-05','2025-05-17','Not Returned','2.50','2024-09-19','Borrowed');
insert into Borrow values(1005,34,'2025-03-09','2025-03-29','Returned','0.00','2024-06-30','Available');
insert into Borrow values(1006,35,'2025-04-07','2025-04-24','Returned','0.00','2024-10-27','Available');
insert into Borrow values(1007,36,'2025-09-09','2025-09-29','Not Returned','1.20','2024-11-29','Borrowed');
insert into Borrow values(1008,37,'2025-11-02','2025-11-23','Returned','0.00','2024-01-15','Available');
insert into Borrow values(1009,38,'2025-01-10','2025-01-27','Returned','0.00','2024-07-25','Available');
insert into Borrow values(1010,39,'2025-07-20','2025-07-30','Not Returned','1.00','2024-12-11','Borrowed');

Create table Reserve (
	MemberID int,
	CopyID int,
	ReserveDate date,
	primary key (MemberID, CopyID),
	Foreign key (MemberID) references member(MemberID),
	Foreign key (CopyID) references BookCopy(CopyID)
);
drop table Reserve

select * from Reserve

insert into Reserve values(1001,30,'2025-01-13');
insert into Reserve values(1002,31,'2025-12-27');
insert into Reserve values(1003,32,'2025-09-05');
insert into Reserve values(1004,33,'2025-04-15');
insert into Reserve values(1005,34,'2025-07-29');
insert into Reserve values(1006,35,'2025-11-23');
insert into Reserve values(1007,36,'2025-06-28');
insert into Reserve values(1008,37,'2025-03-21');
insert into Reserve values(1009,38,'2025-05-11');
insert into Reserve values(1010,39,'2025-08-18');
    
Create table Authorizes (
	LibrarianID int,
	MemberID int,
	CopyID int,
	ScheduledBorrowDate DATE,
	primary key (LibrarianID, MemberID, CopyID),
	foreign key (LibrarianID) references Librarian(LibrarianID),
	Foreign key (MemberID) references member(MemberID),
	Foreign key (CopyID) references BookCopy(CopyID)
);

select * from Authorizes 

insert into Authorizes values(2001,1001,30,'2025-03-01');
insert into Authorizes values(2002,1002,31,'2025-04-13');
insert into Authorizes values(2003,1003,32,'2025-03-05');
insert into Authorizes values(2004,1004,33,'2025-05-05');
insert into Authorizes values(2005,1005,34,'2025-03-09');
insert into Authorizes values(2006,1006,35,'2025-04-07');
insert into Authorizes values(2007,1007,36,'2025-09-09');
insert into Authorizes values(2008,1008,37,'2025-11-02');
insert into Authorizes values(2009,1009,38,'2025-01-10');
insert into Authorizes values(2010,1010,39,'2025-07-20');

