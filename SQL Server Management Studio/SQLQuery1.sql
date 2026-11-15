create table Account (
    AccountID INT PRIMARY KEY,
    Name VARCHAR(100),
    Address TEXT,
    PhoneNo VARCHAR(15),
    Email VARCHAR(100),
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(50)
);
select * from Account

	INSERT INTO Account (AccountID, Name, Address, PhoneNo, Email, Username, Password) VALUES
	(1, 'Nirosha karunartha', '123 Main Street,kandy', '0712234578', 'Niro@gmail.com', 'Niro', 'Ni234kr87'),
	(2, 'Gamini ', '156 Pine Rd', '0751230983', 'Gami@gmail.com', 'Gami21', 'Ga67hg00'),
	(3, 'Anuka perera ', 'A/23 Mawanalla Rd', '0759876532', 'Anu@gmail.com', 'Anu00', 'An67nH00'),
	(4, 'Dewmi gamage', '19 Peradeniya', '0721239874', 'Dew@gmail.com', 'Dew46', 'De67mi12'),
	(5, 'Nimal ', '209 Mape street', '0714568732', 'Nim@gmail.com', 'Nim237', 'Ni67mf34'),
	(6, 'Dharaka Manohara ', 'B/234 Katugasthota,Kandy', '0720943756', 'Dha@gmail.com', 'Dhara102', 'DH67ma65'),
	(7, 'sihan ', '90 birch Rd', '0725467812', 'Sih@gmail.com', 'Sih90', 'Si12bd3y'),
	(8, 'Harry Lee', '009 Oak way', '0702349871', 'Harr@gmail.com', 'Harr34', 'Har12xdd4'),
	(9, 'Jack Brown', '9/A Cedar street', '0701267534', 'Jack@gmail.com', 'Jack20', 'Jack23pp0'),
	(10, 'Methmi', '02 Elm Rd', '0713478234', 'Meth@gmail.com', 'Meth123', 'Meth23jb3');

CREATE TABLE Member (
    AccountID INT PRIMARY KEY,
    MemberID INT UNIQUE,
    MembershipDate DATE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
select * from Member

	INSERT INTO Member (AccountID, MemberID, MembershipDate) VALUES
	(1, 1001, '2023-04-13'),
	(2, 1002, '2024-09-23'),
	(3, 1003, '2025-05-25'),
	(4, 1004, '2024-03-18'),
	(5, 1005, '2023-08-02'),
	(6, 1006, '2025-12-09'),
	(7, 1007, '2022-11-17'),
	(8, 1008, '2023-07-30'),
	(9, 1009, '2023-06-26'),
	(10, 1010, '2025-04-04');

CREATE TABLE Librarian (
    AccountID INT PRIMARY KEY,
    LibrarianID INT UNIQUE,
    Role VARCHAR(50),
    HiredDate DATE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

select * from Librarian

	INSERT INTO Librarian (AccountID, LibrarianID, Role, HiredDate) VALUES
	(1, 2001, 'Senior Librarian', '2023-04-09'),
	(2, 2002, 'Technical Librarian', '2023-04-09'),
	(3, 2003, 'Research Librarian', '2023-04-09'),
	(4, 2004, 'Manager', '2023-04-09'),
	(5, 2005, 'Junior Librarian', '2023-04-09'),
	(6, 2006, 'Reference Librarian', '2023-04-09'),
	(7, 2007, 'Staff', '2023-04-09'),
	(8, 2008, 'Digital Services', '2023-04-09'),
	(9, 2009, 'Assistant Librarian', '2023-04-09'),
	(10, 2010, 'Collection services', '2023-04-09');


CREATE TABLE Book (
    BookID INT PRIMARY KEY,
    Title VARCHAR(255),
    Genre VARCHAR(100),
    ISBN VARCHAR(20) UNIQUE,
    PublishedDate DATE
);

select * from Book

	INSERT INTO Book (BookID, Title, Genre, ISBN, PublishedDate) VALUES
	(20, 'To Kill a mockingbird', 'Classic', '9765342112309', '1960-07-11'),
	(21, '1984', 'Dystopian', '9712345609876', '1949-06-08'),
	(22, 'The Alchemist', 'Adventure', '9756321876543', '1988-04-15'),
	(23, 'The Hobbit', 'Fantasy', '9709812365432', '1949-06-08'),
	(24, 'Moby Dick', 'Adventure', '9705678763213', '1937-09-21'),
	(25, 'The great gastby', 'Classic', '9812347654890', '1925-04-10'),
	(26, 'War and peace', 'Historical', '9776512567892', '1849-01-01'),
	(27, 'The catcher in the Rye', 'Coming-of-age', '9734561298763', '1951-07-16'),
	(28, 'Pride and prejudice', 'Romance', '9771234098123', '1813-01-28'),
	(29, 'Harry potter', 'Fantasy', '9711123455678', '1997-06-26');


CREATE TABLE BookCopy (
    CopyID INT PRIMARY KEY,
    BookID INT,
    Condition VARCHAR(50),
    FOREIGN KEY (BookID) REFERENCES Book(BookID)
);

select * from BookCopy

	INSERT INTO BookCopy (CopyID, BookID, Condition) VALUES
	(30, 20, 'Good'),
	(31, 21, 'Fair'),
	(32, 22, 'Good'),
	(33, 23, 'Excellent'),
	(34, 24, 'Fair'),
	(35, 25, 'Good'),
	(36, 26, 'Excellent'),
	(37, 27, 'Excellent'),
	(38, 28, 'Good'),
	(39, 29, 'poor');


CREATE TABLE Borrow (
    MemberID INT,
    CopyID INT,
    ScheduledBorrowDate DATE,
    ScheduledReturnDate DATE,
    ReturnStatus VARCHAR(50),
    Fine DECIMAL(10,2),
    Overduedate date,
    CurrentStatus VARCHAR(50),
    PRIMARY KEY (MemberID, CopyID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    FOREIGN KEY (CopyID) REFERENCES BookCopy(CopyID)
);

select * from Borrow

	INSERT INTO Borrow (MemberID, CopyID, ScheduledBorrowDate, ScheduledReturnDate, ReturnStatus, Fine, Overduedate, CurrentStatus) VALUES
	(1001, 30, '2025-03-01', '2025-03-20', 'Returned', 0.00, 2024-02-09, 'Available'),
	(1002, 31, '2025-04-13', '2025-04-30', 'Not Returned', 23.00, 2024-03-10, 'Borrowed'),
	(1003, 32, '2025-03-05', '2025-03-19', 'Returned', 0.00, 2024-04-23, 'Available'),
	(1004, 33, '2025-05-05', '2025-05-17', 'Not Returned', 2.50, 2024-09-19, 'Borrowed'),
	(1005, 34, '2025-03-09', '2025-03-29', 'Returned', 0.00, 2024-06-30, 'Available'),
	(1006, 35, '2025-04-07', '2025-04-24', 'Returned', 0.00, 2024-10-27, 'Available'),
	(1007, 36, '2025-09-09', '2025-09-29', 'Not Returned', 1.20, 2024-11-29, 'Borrowed'),
	(1008, 37, '2025-11-02', '2025-11-23', 'Returned', 0.00, 2024-01-15, 'Available'),
	(1009, 38, '2025-01-10', '2025-01-27', 'Returned', 0.00, 2024-07-25, 'Available'),
	(1010, 39, '2025-07-20', '2025-07-30', 'Not Returned', 1.00, 2024-12-11, 'Borrowed');


CREATE TABLE Reserve (
    MemberID INT,
    CopyID INT,
    ReserveDate DATE,
    PRIMARY KEY (MemberID, CopyID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    FOREIGN KEY (CopyID) REFERENCES BookCopy(CopyID)
);

select * from Reserve

	INSERT INTO Reserve (MemberID, CopyID, ReserveDate) VALUES
	(1001, 30, '2025-01-13'),
	(1002, 31, '2025-12-27'),
	(1003, 32, '2025-09-05'),
	(1004, 33, '2025-04-15'),
	(1005, 34, '2025-07-29'),
	(1006, 35, '2025-11-23'),
	(1007, 36, '2025-06-28'),
	(1008, 37, '2025-03-21'),
	(1009, 38, '2025-05-11'),
	(1010, 39, '2025-08-18');


CREATE TABLE Authorizes (
    LibrarianID INT,
    MemberID INT,
    CopyID INT,
    ScheduledBorrowDate DATE,
    PRIMARY KEY (LibrarianID, MemberID, CopyID),
    FOREIGN KEY (LibrarianID) REFERENCES Librarian(LibrarianID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    FOREIGN KEY (CopyID) REFERENCES BookCopy(CopyID)
);
select * from Authorizes

	INSERT INTO Authorizes (LibrarianID, MemberID, CopyID, ScheduledBorrowDate) VALUES
	(2001, 1001, 30, '2025-03-01'),
	(2002, 1002, 31, '2025-04-13'),
	(2003, 1003, 32, '2025-03-05'),
	(2004, 1004, 33, '2025-05-05'),
	(2005, 1005, 34, '2025-03-09'),
	(2006, 1006, 35, '2025-04-07'),
	(2007, 1007, 36, '2025-09-09'),
	(2008, 1008, 37, '2025-11-02'),
	(2009, 1009, 38, '2025-01-10'),
	(2010, 1010, 39, '2025-07-20');
