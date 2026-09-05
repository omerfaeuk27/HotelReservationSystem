# Hotel Reservation System

A console-based hotel reservation system developed with C# to practice object-oriented programming and business logic.

## Features

- Add and list hotel rooms
- Create customers
- Create reservations
- Calculate total reservation price automatically
- Prevent overlapping reservations for the same room
- Cancel active reservations
- Prevent reservations for unavailable rooms
- Search rooms and reservations by ID
- Console menu for user interaction

## Technologies

- C#
- .NET
- Object-Oriented Programming (OOP)

## Concepts Practiced

- Classes and Objects
- Encapsulation
- Constructors
- Properties
- Enums
- Lists
- Exception Handling
- DateTime and TimeSpan
- Business Rules
- Method Responsibilities
- ToString() Override

## Project Structure

- `Oda` - Represents hotel rooms
- `Musteri` - Represents customers
- `Rezervasyon` - Handles reservation information and status
- `Otel` - Manages rooms and reservations
- `Program` - Console application and user interaction

## Reservation Rules

The system prevents two active reservations from using the same room during overlapping date ranges.

Reservation cost is calculated according to the number of nights and the room's nightly price.

## Future Improvements

- SQL Server database integration
- ASP.NET Core Web API
- Entity Framework Core
- Authentication and authorization
- Unit tests

