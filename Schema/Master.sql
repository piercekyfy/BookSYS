set define off;

-- Drop Existing Tables

DROP TABLE BookOrders;
DROP TABLE Books;
DROP TABLE Orders;
DROP TABLE Clients;

-- End

-- Start Books

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

-- Start Orders

CREATE TABLE Orders(
    OrderId NUMBER(6) CHECK(OrderId >= 0),
    ClientId NUMBER(4),
    OrderDate DATE NOT NULL,
    Total NUMBER(8,2) NOT NULL CHECK(Total > 0),
    Status CHAR DEFAULT('U') NOT NULL CHECK(Status IN ('U', 'D', 'C', 'P')),
    CONSTRAINT pk_Orders PRIMARY KEY (OrderId),
    CONSTRAINT fk_OrdersClients FOREIGN KEY (ClientId) REFERENCES Clients(ClientId)
);

CREATE TABLE BookOrders(
    OrderId NUMBER(6),
    BookId NUMBER(4),
    SalePrice NUMBER(5,2) NOT NULL CHECK(SalePrice > 0),
    Quantity NUMBER(6) NOT NULL CHECK(Quantity > 0),
    CONSTRAINT pk_BookOrders PRIMARY KEY (OrderId, BookId),
    CONSTRAINT fk_BookOrdersOrders FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    CONSTRAINT fk_BookOrdersBooks FOREIGN KEY (BookId) REFERENCES Books(BookId)
);

CREATE OR REPLACE TRIGGER setOrderId_Orders
BEFORE INSERT ON Orders
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Orders.OrderId%TYPE;
BEGIN
    SELECT MAX(OrderId) INTO v_maxId FROM Orders;
    :NEW.OrderId := COALESCE(v_maxId + 1, 0);
END;

/

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0000, DATE '2024-03-12', 3090);

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0001, DATE '2024-03-12', 1000);

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0002, DATE '2024-03-12', 1050);

INSERT INTO BookOrders
VALUES(0000, 0000, 15.45, 200);

INSERT INTO BookOrders
VALUES(0001, 0001, 10, 100);

INSERT INTO BookOrders
VALUES(0002, 0002, 25, 42);

COMMIT;

-- End Orders
