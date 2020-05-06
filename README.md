# Online-Rental-Movie

Clone solution

add-migration <migration_name>
update-database
run rental_data_seed.sql in Management Studio to populate the database

buid and run OnlineMovieRental.WebApi project

Software requirements

Visual Studio 2019 16.5 Userd framework and libraries .NET Core 3 Entity Framework 3, MSSQL Server 2017

Used layered Clean Architecure for .NET Core

Core Layer - benefits and key points

Domain

- entities
- value objects
- logic related to the domain entities
- exceptions

Application

- interfaces and abstractions
- view models and DTO-s
- business logic and types
- command/query patterns
- simplicity
- performance
- scalability
- ability to attach behavior before or efter each request(logging, validation, caching, authorisation)
- exceptions

Infrastructure Layer - benefits and key points

- persistence concerns
- identity concerns
- api clients
- comunications wthi any external system
- indipendent of the database
- fluent api configuration over data anotations
- conventions over configurations
- automacaly apply all enity type configurations
- no layers depend on infrastructure
    
Presentation Layer - benefits and key points

    - web api
        - controllers should not contain any app logic
        - create and define well defined view models if needed
