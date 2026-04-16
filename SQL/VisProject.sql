Create database VisProject;

use VisProject;

--Resepsionis

CREATE TABLE users (
  id INT IDENTITY(1,1) PRIMARY KEY,
  username VARCHAR(50) NOT NULL,
  password VARCHAR(50) NOT NULL,
  bidangpekerjaan VARCHAR(50) NOT NULL
);

INSERT INTO users (username, password, bidangpekerjaan)
VALUES
    ('admin', '123', 'Administrasi');

CREATE TABLE Pelanggan (
    IDPelanggan INT PRIMARY KEY,
    NamaLengkap VARCHAR(100),
    TglLahir DATE,
    NoTelp VARCHAR(20),
    Email VARCHAR(100),
    Gender VARCHAR(10)
);

INSERT INTO Pelanggan (IDPelanggan, NamaLengkap, TglLahir, NoTelp, Email, Gender)
VALUES
    (1, 'Guest Sample A', '1990-05-15', '0800000001', 'guest.a@example.com', 'Male'),
    (2, 'Guest Sample B', '1985-09-20', '0800000002', 'guest.b@example.com', 'Female'),
    (3, 'Guest Sample C', '1998-03-10', '0800000003', 'guest.c@example.com', 'Male');

CREATE TABLE Tamu(
    IDPelanggan INT PRIMARY KEY,
    NamaLengkap VARCHAR(100),
    TglLahir DATE,
    NoTelp VARCHAR(20),
    Email VARCHAR(100),
    Gender VARCHAR(10),
    JumlahKamar INT,
    JumlahHari INT,
    MetodePembayaran VARCHAR(20),
    TotalHarga INT,
	RoomNumber VARCHAR(10)
);

CREATE TABLE Room (
    RoomNumber VARCHAR(10));

INSERT INTO Room (RoomNumber)
VALUES 
    ('101'),
    ('102'),
    ('103'),
    ('104'),
    ('105'),
    ('106'),
    ('107'),
    ('108'),
    ('109'),
    ('110'),
    ('201'),
    ('202'),
    ('203'),
    ('204'),
    ('205'),
    ('206'),
    ('207'),
    ('208'),
    ('209'),
    ('210'),
    ('301'),
    ('302'),
    ('303'),
    ('304'),
    ('305'),
    ('306'),
    ('307'),
    ('308'),
    ('309'),
    ('310'),
    ('401'),
    ('402'),
    ('403'),
    ('404'),
    ('405'),
    ('406'),
    ('407'),
    ('408'),
    ('409'),
    ('410'),
    ('501'),
    ('502'),
    ('503'),
    ('504'),
    ('505'),
    ('506'),
    ('507'),
    ('508'),
    ('509'),
    ('510');

-- Inventory
CREATE TABLE Barang (
    IDBarang VARCHAR(100) PRIMARY KEY,
    NamaBarang VARCHAR(100),
    JumlahTersedia INT,
    HargaSatuan DECIMAL(10, 2)
);

INSERT INTO Barang (IDBarang, NamaBarang, JumlahTersedia, HargaSatuan)
VALUES
    ('SP01', 'Sabun', 100, 5000),
    ('SP02', 'Shampoo', 50, 10000),
    ('SP03', 'Toothbrush', 200, 2000),
    ('SP04', 'Towel', 75, 15000),
    ('SP05', 'Soap', 150, 3000);

--Housekeeping
CREATE TABLE BKebersihan (
    IDBarang VARCHAR(100) PRIMARY KEY,
    NamaBarang VARCHAR(100),
    JumlahTersedia INT,
    Harga DECIMAL(10, 2)
);

INSERT INTO BKebersihan (IDBarang, NamaBarang, JumlahTersedia, Harga)
VALUES 
    ('P01', 'Sapu', 10, 25500),
    ('P02', 'Pembersih Lantai', 5, 45750),
    ('P03', 'Kain Lap', 20, 10990),
    ('P04', 'Sikat Toilet', 15, 8500),
    ('P05', 'Sabun Cuci Piring', 12, 12250);

--Admnistrasi
CREATE TABLE Users (
    IDKaryawan INT PRIMARY KEY,
    NamaLengkap VARCHAR(255),
    Username VARCHAR(50),
    Jabatan VARCHAR(100),
    Alamat VARCHAR(255),
    NoTelp VARCHAR(20),
    Password VARCHAR(50)
);

INSERT INTO Users (IDKaryawan, NamaLengkap, Username, Jabatan, Alamat, NoTelp, Password)
VALUES
    (1, 'Admin', 'admin', 'Administrasi', 'Alamat Admin', '1234567890', '1'),
    (2, 'Resepsionis', 'resep', 'Resepsionis', 'Alamat Resepsionis', '0987654321', '2'),
    (3, 'Inventory', 'inv', 'Inventory', 'Alamat Inventory', '9876543210', '3'),
    (4, 'Housekeeping', 'house', 'Housekeeping', 'Alamat Housekeeping', '0123456789', '4');

