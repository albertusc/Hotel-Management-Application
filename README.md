# Hotel Management Desktop App (Windows Forms)

This repository contains a C# Windows Forms application for hotel operations, covering reception, administration, inventory, and housekeeping workflows.

## Project Structure

- `WindowsFormsApp1.sln`: Visual Studio solution file.
- `WindowsFormsApp1/`: Main Windows Forms project.
- `SQL/VisProject.sql`: Database schema and initial seed data.
- `Images/`: UI screenshots and design assets.

## Features

- Authentication and role-based menu access
- Guest registration, payment, and checkout flows
- Room reservation support
- Employee and payroll data flow
- Goods inventory and stock maintenance
- Housekeeping supply data management
- Basic reporting forms (including Crystal Reports classes/rpt files)

## Tech Stack

- .NET Framework WinForms (C#)
- SQL Server database
- Typed DataSet (.xsd) and generated Designer adapters
- Crystal Reports integration (existing project files)

## Setup

1. Open `WindowsFormsApp1.sln` in Visual Studio.
2. Ensure SQL Server is available (localdb or SQL Server instance).
3. Run `SQL/VisProject.sql` to create and seed the `VisProject` database.
4. Verify/update connection string in:
   - `WindowsFormsApp1/App.config`
   - `WindowsFormsApp1/Properties/Settings.settings`
5. Build and run the solution.

## SQL Notes

- Main script: `SQL/VisProject.sql`
- Includes tables for users, guests, rooms, inventory, housekeeping items, and employee/admin users.
- Seed data has been normalized to non-personal sample values.

## Image Gallery

The following screenshots are included under `Images/`:

- ![Login Page](Images/Login%20Page.png)
- ![Home Page](Images/Home%20Page.png)
- ![Home Menus](Images/Home%20Menus.png)
- ![Guest Reception](Images/Guest%20Reception.png)
- ![Guest Payment](Images/Guest%20Payment.png)
- ![Guest Check-out](Images/Guest%20Check-out.png)
- ![Room Reservation](Images/Room%20Reservation.png)
- ![Employee Data Management](Images/Employee%20Data%20Management.png)
- ![Payroll System Page](Images/Payroll%20System%20Page.png)
- ![Goods Inventory System](Images/Goods%20Inventory%20System.png)
- ![Stock Maintenance](Images/Stock%20Maintenance.png)
- ![Provision of Cleaning Supplies](Images/Provision%20of%20Cleaning%20Supplies.png)
- ![Availability of Cleaning Supplies](Images/Availability%20of%20Cleaning%20Supplies.png)
- ![ER Diagram](Images/ER%20Diagram.png)

## Documentation

- File-level documentation: `docs/FILE_DOCUMENTATION.md`
- SQL documentation: `SQL/README.md`

## Privacy and Repository Hygiene

This repository has been sanitized to remove machine-specific and personal artifacts:

- Removed IDE/build output directories (`.vs`, `bin`, `obj`)
- Removed user-specific project settings file (`.csproj.user`)
- Removed root personal PDF artifact
- Replaced hardcoded machine SQL Server references with settings-based configuration
- Replaced absolute local file paths in source with project-relative resolution
- Replaced personal-like seed contact values with dummy sample data
