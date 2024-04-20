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
    Description VARCHAR2(480),
    Publisher VARCHAR2(48) NOT NULL,
    Price NUMBER(6,2) NOT NULL CHECK(Price > 0),
    Quantity NUMBER(6) DEFAULT(0) NOT NULL CHECK(Quantity >= 0),
    ISBN CHAR(13) NOT NULL UNIQUE,
    Status CHAR DEFAULT('A') NOT NULL CHECK(Status IN ('A', 'N')),
    CONSTRAINT pk_Books PRIMARY KEY (BookId)
);

DROP SEQUENCE idSeq_Books;

CREATE SEQUENCE idSeq_Books
INCREMENT BY 1
START WITH 0
MINVALUE 0
MAXVALUE 9999;

CREATE OR REPLACE TRIGGER setBookId_Books
BEFORE INSERT ON Books
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Books.BookId%TYPE;
BEGIN
    :NEW.BookId := idSeq_Books.NEXTVAL;
END;

/

-- Book Creation

-- Available Books (10)

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Frankenstein', 'Mary Shelly', 'A monster! The scientist! Who??', 'Lackington, Hughes, Harding, Mavor & Jones', 15.45, 80, '9781861972712');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Mice and Men', 'John Steinbeck', 'He shoots him! Gasp.', 'Penguin', 10, 200, '9788431634506');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Cherub', 'Robert Muchamore', 'Spies!', 'Simon & Schuster', 25, 45, '9780340881538');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Pride and Prejudice', 'Jane Austen', 'The love story of Elizabeth Bennet and Fitzwilliam Darcy, who misjudge, then challenge and change each other.', 'Penguin', 6, 3000, '9780141439518');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Hamlet', 'William Shakespeare', 'The story of Hamlet, the Prince of Denmark who learns of the death of his father at the hands of his uncle, Claudius.', 'Digireads.com', 8.99, 540, '9781420922530');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('The Odyssey', 'Homer', 'Odyssey is literature''s grandest evocation of an everyman''s journey through life. Odysseus'' reliance on his wit and wiliness for survival in his encounters with divine and natural forces during his ten-year voyage home to Ithaca after the Trojan War is at once a timeless human story and an individual test of moral endurance.', 'Penguin', 15, 140, '9780140449112');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('War and Peace', 'Leo Tolstoy', 'War and Peace broadly focuses on Napoleon''s invasion of Russia in 1812 and follows three of the most well-known characters in literature: Pierre Bezukhov, the illegitimate son of a count who is fighting for his inheritance and yearning for spiritual fulfillment; Prince Andrei Bolkonsky, who leaves his family behind to fight in the war against Napoleon; and Natasha Rostov, the beautiful young daughter of a nobleman who intrigues both men.', 'Penguin', 20, 850, '9780140447934');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('The Great Gatsby', 'F. Scott Fitzgerald', 'Set in the summer of 1922, the novel follows the life of a young and mysterious millionaire, his extravagant lifestyle in Long Island, and his obsessive love for a beautiful former debutante.', 'Pocket Books', 10, 130, '9781982146702');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('The Catcher in the Rye', 'J. D. Salinger', 'The novel follows the story of a teenager named Holden Caulfield, who has just been expelled from his prep school. The narrative unfolds over the course of three days, during which Holden experiences various forms of alienation and his mental state continues to unravel.', 'Little, Brown and Company', 22.49, 4300, '9780316540032');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
VALUES('Moby Dick', 'Herman Meville', 'The novel is a detailed narrative of a vengeful sea captain''s obsessive quest to hunt down a giant white sperm whale that bit off his leg. The captain''s relentless pursuit, despite the warnings and concerns of his crew, leads them on a dangerous journey across the seas.', 'CreateSpace Independent Publishing Platform', 12, 600, '9781503280786');

-- Unavailable Books (2)

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN, Status)
VALUES('Alice''s Adventures in Wonderland', 'Lewis Carroll', 'This novel follows the story of a young girl named Alice who falls down a rabbit hole into a fantastical world full of peculiar creatures and bizarre experiences.', 'William Collins', 2.50, 1200, '9780007350827', 'N');

INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN, Status)
VALUES('Les Misérables', 'Victor Hugo', 'Set in early 19th-century France, the narrative follows the lives and interactions of several characters, particularly the struggles of ex-convict Jean Valjean and his journey towards redemption.', 'Penguin', 10.29, 100, '9780140444308', 'N');

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

DROP SEQUENCE idSeq_Clients;

CREATE SEQUENCE idSeq_Clients
INCREMENT BY 1
START WITH 0
MINVALUE 0
MAXVALUE 9999;

CREATE OR REPLACE TRIGGER setClientId_Clients
BEFORE INSERT ON Clients
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Clients.ClientId%TYPE;
BEGIN
    :New.ClientId := idSeq_Clients.NEXTVAL;
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

DROP SEQUENCE idSeq_Orders;

CREATE SEQUENCE idSeq_Orders
INCREMENT BY 1
START WITH 0
MINVALUE 0
MAXVALUE 9999;

CREATE OR REPLACE TRIGGER setOrderId_Orders
BEFORE INSERT ON Orders
FOR EACH ROW
ENABLE
DECLARE
    v_maxId Orders.OrderId%TYPE;
BEGIN
    :NEW.OrderId := idSeq_Orders.NEXTVAL;
END;

/

-- 2024 (4)

INSERT INTO Orders (ClientId, OrderDate, Total, Status)
VALUES(0000, DATE '2024-03-12', 3590, 'P');

INSERT INTO BookOrders
VALUES(0000, 0000, 15.45, 200);

INSERT INTO BookOrders
VALUES(0000, 0007, 10, 50);

INSERT INTO Orders (ClientId, OrderDate, Total, Status)
VALUES(0001, DATE '2024-03-16', 3500, 'D');

INSERT INTO BookOrders
VALUES(0001, 0001, 10, 100);

INSERT INTO BookOrders
VALUES(0001, 0002, 25, 100);

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0002, DATE '2024-04-12', 1229.80);

INSERT INTO BookOrders
VALUES(0002, 0002, 25, 42);

INSERT INTO BookOrders
VALUES(0002, 0004, 8.99, 20);

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0000, DATE '2024-04-18', 4274.70);

INSERT INTO BookOrders
VALUES(0003, 0008, 22.49, 30);

INSERT INTO BookOrders
VALUES(0003, 0009, 12, 300 );

-- 2023 (2)

INSERT INTO Orders (ClientId, OrderDate, Total, Status)
VALUES(0001, DATE '2023-08-20', 2398, 'P');

INSERT INTO BookOrders
VALUES(0004, 0001, 10, 60);

INSERT INTO BookOrders
VALUES(0004, 0004, 8.99, 200 );

INSERT INTO Orders (ClientId, OrderDate, Total)
VALUES(0002, DATE '2023-08-20', 1200);

INSERT INTO BookOrders
VALUES(0005, 0008, 20, 40);

INSERT INTO BookOrders
VALUES(0005, 0006, 20, 20);

COMMIT;

-- End Orders
