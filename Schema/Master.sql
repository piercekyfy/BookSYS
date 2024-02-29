set define off;

-- Start Books

DROP TABLE Books;

CREATE TABLE Books(
    BookId NUMBER(4) CHECK(BookID >= 0),
    Title VARCHAR2(64) NOT NULL,
    Author VARCHAR2(48) NOT NULL,
    Description VARCHAR2(280),
    Publisher VARCHAR2(48) NOT NULL,
    Price NUMBER(6,2) NOT NULL CHECK(Price > 0),
    Quantity NUMBER(6) DEFAULT(0) NOT NULL CHECK(Quantity >= 0),
    ISBN CHAR(13) NOT NULL UNIQUE,
    Status CHAR DEFAULT('A') NOT NULL CHECK(Status IN ('A', 'N')),
    CONSTRAINT pk_Books PRIMARY KEY (BookId)
);

CREATE OR REPLACE TRIGGER setBookId_Books
BEFORE INSERT ON Books
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Books.BookId%TYPE;
BEGIN
    SELECT MAX(BookId) INTO v_maxId FROM Books;
    :NEW.BookId := COALESCE(v_maxId + 1, 0);
END;

/

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Frankenstein', 'Mary Shelly', 'A monster! The scientist! Who??', 'Lackington, Hughes, Harding, Mavor & Jones', 15.45, 80, '9781861972712');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Mice and Men', 'John Steinbeck', 'He shoots him! Gasp.', 'Penguin', 10, 200, '9788431634506');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Cherub', 'Robert Muchamore', 'Spies!', 'Simon & Schuster', 25, 45, '9780340881538');

COMMIT;

-- End Books

-- Start Clients

DROP TABLE Clients;

CREATE TABLE Clients(
    ClientId NUMBER(4) CHECK(ClientId >= 0),
    Name VARCHAR2(64) NOT NULL,
    Street VARCHAR2(48) NOT NULL,
    City VARCHAR2(48) NOT NULL,
    County VARCHAR2(12) NOT NULL,
    Eircode CHAR(7) NOT NULL UNIQUE,
    Email VARCHAR2(48) NOT NULL UNIQUE,
    Phone CHAR(9) NOT NULL UNIQUE,
    Status CHAR(1) DEFAULT('O') NOT NULL CHECK(Status IN ('O', 'C')),
    CONSTRAINT pk_Clients PRIMARY KEY (ClientId)
);

CREATE OR REPLACE TRIGGER setClientId_Clients
BEFORE INSERT ON Clients
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Clients.ClientId%TYPE;
BEGIN
    SELECT MAX(ClientId) INTO v_maxId FROM Clients;
    :NEW.ClientId := COALESCE(v_maxId + 1, 0);
END;

/

INSERT INTO Clients (Name, Street, City, County, Eircode, Email, Phone)
VALUES('Lil Bookstore', '43 Moyderwell', 'Tralee', 'Kerry', 'V92PX56', 'lilbookstore@gmail.com', '894054052');

INSERT INTO Clients (Name, Street, City, County, Eircode, Email, Phone)
VALUES('Big Book(s)store!', '32 Castle Street Upper', 'Tralee', 'Kerry', 'V92RX64', 'internal@bigbooks.com', '892055452');

INSERT INTO Clients (Name, Street, City, County, Eircode, Email, Phone)
VALUES('Crazy Books', '40 Pembroke Square', 'Tralee', 'Kerry', 'V92EHH3', 'crazyybooks@gmail.com', '872088122');

COMMIT;

-- End Clients
