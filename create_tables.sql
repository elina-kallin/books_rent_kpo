CREATE TABLE books (
    id          uuid PRIMARY KEY,
    name        text NOT NULL,
    author      text NOT NULL,
    year        date NOT NULL,
    category    int NOT NULL,
	status_rent int not null
);

CREATE TABLE rent_checks (
    id          uuid PRIMARY KEY,
    book_id     uuid NOT NULL REFERENCES books(id),
    user_id     text NOT NULL,
    fio         text NOT NULL,
    status_rent int NOT NULL
);
