CREATE DATABASE AYUBOAPP;


CREATE TABLE Customer
(
  Customer_ID INT,
  First_Name VARCHAR(255),
  Last_Name VARCHAR(255),
  Address VARCHAR(255),
  NIC VARCHAR(50),
  Contact_Number VARCHAR(10) UNIQUE,
  PRIMARY KEY (Customer_ID)
);

CREATE TABLE Driver
(
  Driver_ID INT,
  First_Name VARCHAR(255),
  Last_Name VARCHAR(255),
  Address VARCHAR(255),
  Driver_license VARCHAR(255),
  ContactNumber VARCHAR(10) UNIQUE,
  Driver_Cost INT,
  PRIMARY KEY (Driver_ID)
);

CREATE TABLE Vehicle
(
  Vehicle_ID INT PRIMARY KEY,
  Vehicle_Type VARCHAR(255),
  Vehicle_Model VARCHAR(255),
  Number_Plate VARCHAR(255) UNIQUE,
  Fuel_Type VARCHAR(255),
  Hire_Charge INT,
  PerDay INT,
  PerWeek INT,
  PerMonth INT,
  Perkm INT,
  DailykmLimit INT
);

CREATE TABLE Booking
(
  Booking_ID INT,
  Customer_ID INT,
  Vehical_ID INT,
  PRIMARY KEY (Booking_ID),
  FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
  FOREIGN KEY (Vehical_ID) REFERENCES Vehicle(Vehicle_ID),
);

CREATE TABLE Package
(
Package_ID INT PRIMARY KEY,
Package_Name VARCHAR(255),
Package_Type VARCHAR(255),
Base_Charge INT,
Per_km INT,
Daily_kmLimit INT

);

CREATE TABLE Long_Tour
(
  LongHire_ID INT,
  Package_Type VARCHAR(255),
  Start_Date VARCHAR(255),
  End_Date VARCHAR(255),
  Start_km INT,
  End_km INT,
  Base_Hire_Charge INT,
  Overnight_stay_charge INT,
  Extra_km_Charge INT,
  Hire_Value INT,
  Driver_ID INT,
  Package_ID INT,
  Booking_ID INT NOT NULL,
  PRIMARY KEY (LongHire_ID),
  FOREIGN KEY (Package_ID) REFERENCES Package(Package_ID),
  FOREIGN KEY (Booking_ID) REFERENCES Booking(Booking_ID),
  FOREIGN KEY (Driver_ID) REFERENCES Driver(Driver_ID)
);

CREATE TABLE Day_Tour
(
  DayHire_ID INT,
  Package_type VARCHAR(255),
  Start_time VARCHAR(255),
  End_time VARCHAR(255),
  Start_km INT,
  End_Km INT,
  Base_Hire_charge INT,
  waiting_charge INT,
  Extra_km_Charge INT,
  Hire_Value INT,
  Driver_ID INT,
  Package_ID INT,
  Booking_ID INT,
  PRIMARY KEY (DayHire_ID),
  FOREIGN KEY (Package_ID) REFERENCES Package(Package_ID),
  FOREIGN KEY (Booking_ID) REFERENCES Booking(Booking_ID),
  FOREIGN KEY (Driver_ID) REFERENCES Driver(Driver_ID)
);

CREATE TABLE Rent
(
  Rent_ID INT,
  Driver_with_or_without VARCHAR(255),
  Rented_date VARCHAR(255),
  Return_date VARCHAR(255),
  Startkm INT,
  Endkm INT,
  Extra_km_Charge INT,
  Rent_value INT,
  Driver_ID INT,
  Booking_ID INT,
  PRIMARY KEY (Rent_ID),
  FOREIGN KEY (Booking_ID) REFERENCES Booking(Booking_ID),
  FOREIGN KEY (Driver_ID) REFERENCES Driver(Driver_ID)
);

CREATE TABLE Payment
(
  Payment_ID INT NOT NULL,
  Payment_Option VARCHAR(255) NOT NULL,
  Amount INT NOT NULL,
  Booking_ID INT NOT NULL,
  PRIMARY KEY (Payment_ID),
  FOREIGN KEY (Booking_ID) REFERENCES Booking(Booking_ID)
);



INSERT INTO Customer VALUES (001 , 'IAN', 'BRADLEY', 'ADSADS', '200208302717', '0764533003')

INSERT INTO Driver VALUES (001 , 'METHSAN', 'WICK', 'FDASFSAF', '200212365478', '0779632584', 5000)
INSERT INTO Driver VALUES (002 , 'MISHAL', 'FONSEKA', 'GGSDGFSDGFDS', '20031235456', '0783642513', 2500)
INSERT INTO Driver VALUES (003 , 'GESHAN', 'DUMINDU', 'KODAGAMULLA', '200236578410', '0745632561', 3000)

INSERT INTO Vehicle VALUES (001, 'CAR', 'TOYOTA PRIME', 'CAR - 5030', 'Petrol', 6000, 100, 600, 2000, 40, 100)
INSERT INTO Vehicle VALUES (002, 'VAN', 'SUZUKI ', 'VAN - 3322', 'Disel', 10000, 200, 1200, 4500, 60, 100)
INSERT INTO Vehicle VALUES (003, 'SUV', 'LAND ROVER', 'CDD - 9933', 'Petrol', 15000, 300, 1800, 6000, 80, 100)

select * from Vehicle
Select * from Driver


SELECT PerDay, PerWeek, PerMonth, Perkm, DailykmLimit FROM Vehicle
SELECT Driver_ID, First_Name, Driver_Cost  FROM Driver 


select * from Vehicle
select * from Booking
select * from Rent
select * from Payment



t1 = Booking
t2 = Customer
t3 = Rent
t4 = Payment


SELECT * FROM Booking full JOIN Customer ON Booking.Booking_ID = Booking.Customer_ID LEFT JOIN Rent ON Booking.Booking_ID = Rent.Rent_ID LEFT JOIN Payment ON Booking.Booking_ID = Payment.Payment_ID LEFT JOIN Driver ON Booking.Booking_ID = Driver.Driver_ID 
WHERE Booking.Booking_ID = 001

Select * from Vehicle

 SELECT * FROM Customer INNER JOIN Booking ON  Customer.Customer_ID = Booking.Customer_ID
 WHERE Booking.Booking_ID = 003

 SELECT * FROM Day_Tour

 SELECT * FROM Booking INNER JOIN Rent ON  Booking.Booking_ID = Rent.Booking_ID

 SELECT * FROM Vehicle INNER JOIN Booking ON Booking.Vehical_ID = Vehicle.Vehicle_ID
 WHERE Booking.Booking_ID = 4

 SELECT * FROM Driver INNER JOIN Day_Tour ON Driver.Driver_ID = Day_Tour.Driver_ID 
 WHERE Day_Tour.Booking_ID = 3

 SELECT * FROM Customer
 SELECT * FROM Package

 DELETE FROM Booking WHERE Booking_ID = 3
 DELETE FROM Payment WHERE Payment_ID = 3
 
 SELECT * FROM Booking

 ALTER TABLE Package
ADD Daily_kmLimit INT;


SELECT * FROM Package

SELECT * FROM Day_Tour INNER JOIN Booking ON Day_Tour.Booking_ID = Booking.Booking_ID

SELECT * FROM Vehicle INNER JOIN Booking ON Vehicle.Vehicle_ID = Booking.Booking_ID 
WHERE Booking.Booking_ID = 3

SELECT First_Name FROM Day_Tour INNER JOIN Driver ON Driver.Driver_ID = Day_Tour.Driver_ID 
