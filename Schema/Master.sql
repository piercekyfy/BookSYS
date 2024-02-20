set define off;

-- Start Books

DROP TABLE Books;

CREATE TABLE Books(
    BookId NUMBER(4) CHECK(BookID >= 0),
    Title VARCHAR2(32) NOT NULL,
    Author VARCHAR(32) NOT NULL,
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

-- Doesn't work on uni server
/*
DROP TYPE IdMetricPairTable;

DROP TYPE IdMetricPair;

CREATE OR REPLACE TYPE IdMetricPair AS OBJECT(
    Id NUMBER(4),
    Name VARCHAR(32),
    Metric NUMBER(4) );
/
CREATE OR REPLACE TYPE IdMetricPairTable AS TABLE OF IdMetricPair;
/

-- Returns a unordered table containing BookId, Name and Metric where highest indicates the closest match.
CREATE OR REPLACE FUNCTION SearchByTitle_Books( p_Search Books.TITLE%TYPE ) RETURN IdMetricPairTable PIPELINED AS
    TYPE IdMetricPair IS RECORD(
        Id NUMBER(4),
        Name VARCHAR(32),
        Metric NUMBER(4)
    );
    TYPE IdMetricPairTable IS TABLE OF IdMetricPair;
	CURSOR c_Books IS SELECT BookId, Title FROM Books WHERE Status != 'N';

	v_Title Books.Title%TYPE;
	v_Metric NUMBER(4);
BEGIN
	FOR r_Book IN c_Books LOOP
		v_Metric := 0;
		
		v_Title := UPPER(r_Book.Title);

		IF ( v_Title LIKE UPPER(p_Search) ) THEN
            v_Metric := v_Metric + 8;
		ELSIF ( v_Title LIKE UPPER(p_Search)||'%' ) THEN
            v_Metric := v_Metric + 4;
		ELSIF ( v_Title LIKE '%'||UPPER(p_Search)||'%' ) THEN
            v_Metric := v_Metric + 2;
		END IF;

		IF ( v_Metric > 0 ) THEN 
            PIPE ROW(IdMetricPair(r_Book.BookId, r_Book.Title, v_Metric));
		END IF;
    END LOOP;
END;
*/
-- End Books