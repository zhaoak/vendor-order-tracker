# Vendor and Order Tracker

#### By _Allie Zhao_

Independent project for Epicodus, C#/.NET section week 2

## Technologies Used

- ASP .NET
- C#

## Description

In-browser MVC application for tracking vendors that purchase a storefront's 
goods, as well as their orders.

## Setup/Installation Requirements

### To run app:

- clone repository to location of your choice
- ensure .NET 6 SDK is installed and correctly configured
- navigate to `VendorOrderTracker` directory
- in your terminal, enter `dotnet run`
- in your browser, open `http://localhost:5001`

### To run tests:

- clone repository
- ensure .NET 6 SDK is installed and configured
- navigate to `VendorOrderTracker.Tests` directory
- in your terminal, enter `dotnet test`

## Known Bugs

- Refreshing vendor detail page after creating order resends POST request,
  thus duplicating order

## License

MIT

Copyright (c) Allie Zhao
