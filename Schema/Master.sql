set define off;

-- Start Books

DROP TABLE Books;

CREATE TABLE Books(
    BookId NUMBER(4) CHECK(BookID >= 0),
    Title VARCHAR2(32) NOT NULL,
    Author VARCHAR2(32) NOT NULL,
    Description VARCHAR2(124),
    Publisher VARCHAR2(64) NOT NULL,
    Price NUMBER(6,2) NOT NULL CHECK(Price > 0),
    Quantity NUMBER(6) DEFAULT(0) NOT NULL CHECK(Quantity >= 0),
    ISBN CHAR(13) NOT NULL UNIQUE,
    Status CHAR DEFAULT('A') NOT NULL CHECK(Status IN ('A', 'N')),
    CONSTRAINT pk_Books PRIMARY KEY (BookId)
);

INSERT INTO Books
VALUES(0001, 'Frankenstein', 'Mary Shelly', 'A monster! The scientist! Who??', 'Lackington, Hughes, Harding, Mavor & Jones', 15.45, 80, '9781861972712', 'A');

INSERT INTO Books
VALUES(0002, 'Mice and Men', 'John Steinbeck', 'He shoots him! Gasp.', 'Penguin', 10, 200, '9788431634506', 'A');

INSERT INTO Books
VALUES(0003, 'Cherub', 'Robert Muchamore', 'Spies!', 'Simon & Schuster', 25, 45, '9780340881538', 'A');

COMMIT;