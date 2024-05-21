-- Insert data into the Client table
INSERT INTO trip.Client (IdClient, FirstName, LastName, Email, Telephone, Pesel)
VALUES
    (1, 'John', 'Doe', 'john.doe@example.com', '123456789', '85010112345'),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', '987654321', '92020254321'),
    (3, 'Michael', 'Brown', 'michael.brown@example.com', '456123789', '87030367890');

-- Insert data into the Country table
INSERT INTO trip.Country (IdCountry, Name)
VALUES
    (1, 'USA'),
    (2, 'Poland'),
    (3, 'Germany');

-- Insert data into the Trip table
INSERT INTO trip.Trip (IdTrip, Name, Description, DateFrom, DateTo, MaxPeople)
VALUES
    (1, 'Trip to New York', 'A wonderful trip to New York City.', '2023-06-01', '2023-06-10', 20),
    (2, 'Trip to Warsaw', 'Explore the beautiful city of Warsaw.', '2023-07-15', '2023-07-20', 15),
    (3, 'Trip to Berlin', 'Visit the historical sites of Berlin.', '2023-08-05', '2023-08-12', 25);

-- Insert data into the Client_Trip table
INSERT INTO trip.Client_Trip (IdClient, IdTrip, RegisteredAt, PaymentDate)
VALUES
    (1, 1, '2023-05-01', '2023-05-05'),
    (2, 2, '2023-06-10', '2023-06-15'),
    (3, 3, '2023-07-20', '2023-07-25'),
    (1, 3, '2023-07-25', NULL);

-- Insert data into the Country_Trip table
INSERT INTO trip.Country_Trip (IdCountry, IdTrip)
VALUES
    (1, 1),
    (2, 2),
    (3, 3);

-- Verify data insertion
SELECT * FROM trip.Client;
SELECT * FROM trip.Country;
SELECT * FROM trip.Trip;
SELECT * FROM trip.Client_Trip;
SELECT * FROM trip.Country_Trip;
