# SQL Documentation

Main script: `VisProject.sql`

## Database

- Database name: `VisProject`
- Script initializes schema and inserts baseline sample records.

## Tables and Purpose

### `users`

Used for login and role/department-based access at the application level.

Columns:

- `id` (INT, PK, identity)
- `username` (VARCHAR(50), required)
- `password` (VARCHAR(50), required)
- `bidangpekerjaan` (VARCHAR(50), required)

### `Pelanggan`

Stores guest/customer profile details.

Columns:

- `IDPelanggan` (INT, PK)
- `NamaLengkap` (VARCHAR(100))
- `TglLahir` (DATE)
- `NoTelp` (VARCHAR(20))
- `Email` (VARCHAR(100))
- `Gender` (VARCHAR(10))

### `Tamu`

Stores reservation/payment related transactional guest records.

Columns:

- `IDPelanggan` (INT, PK)
- `NamaLengkap` (VARCHAR(100))
- `TglLahir` (DATE)
- `NoTelp` (VARCHAR(20))
- `Email` (VARCHAR(100))
- `Gender` (VARCHAR(10))
- `JumlahKamar` (INT)
- `JumlahHari` (INT)
- `MetodePembayaran` (VARCHAR(20))
- `TotalHarga` (INT)
- `RoomNumber` (VARCHAR(10))

### `Room`

Stores room numbers available to reservation forms.

Columns:

- `RoomNumber` (VARCHAR(10))

Seeded with room numbers `101-110`, `201-210`, `301-310`, `401-410`, `501-510`.

### `Barang`

Inventory item master table for goods/supplies.

Columns:

- `IDBarang` (VARCHAR(100), PK)
- `NamaBarang` (VARCHAR(100))
- `JumlahTersedia` (INT)
- `HargaSatuan` (DECIMAL(10,2))

### `BKebersihan`

Housekeeping cleaning item stock table.

Columns:

- `IDBarang` (VARCHAR(100), PK)
- `NamaBarang` (VARCHAR(100))
- `JumlahTersedia` (INT)
- `Harga` (DECIMAL(10,2))

### `Users`

Employee/admin management table (separate from lowercase `users`).

Columns:

- `IDKaryawan` (INT, PK)
- `NamaLengkap` (VARCHAR(255))
- `Username` (VARCHAR(50))
- `Jabatan` (VARCHAR(100))
- `Alamat` (VARCHAR(255))
- `NoTelp` (VARCHAR(20))
- `Password` (VARCHAR(50))

## Data Notes

- Sample contact/person data has been normalized to non-personal dummy values.
- Default seed users are for demo/dev purposes and should be changed in production.

## Recommended Improvements

1. Add explicit foreign keys (for example between `Tamu.IDPelanggan` and `Pelanggan.IDPelanggan`).
2. Hash passwords instead of storing plain text.
3. Add indexes for frequent lookup columns (`Username`, `IDKaryawan`, `RoomNumber`).
4. Add uniqueness constraints where appropriate (for example employee username).
