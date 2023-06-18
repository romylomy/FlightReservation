##FlightReservation

This project implements a Flight Reservation System, allowing customers to search for available flights based on destination, origin, and day of flight, and reserve their desired flights.While also having an admin side system with CRUD implementation built using .NETMAUI Framework.

## Features

- Search reservations based on reservation code, airline, and passenger name.
- Display matching reservations in a select field for easy selection.
- View detailed information about a selected reservation, including flight code, airline, day, time, cost, passenger name, and citizenship.
- Update reservation details such as passenger name, citizenship, and status (active/inactive).
- Save the modified reservation to persist the changes.

## Technologies Used

- C# (.NET MAUI)
- HTML/CSS
- CSV file handling

## Ongoing improvements
    -Error handling
    -Mysql implementation

### Class Diagram 

```mermaid
classDiagram
    class interface {
        + Task OnInitializedAsync()
        + Task FindReservation()
        + void ParseString()
        + void ReservationManager()
    }

    class ReservationFinder {
        - string ReservationSelection
        - string selectedCode
        - string selectedName
        - string selectedAirline
        - string ReservationCode
        - List<Airport> airports
        - List<Booking> bookings
        - string textReservationCode
        - string textflightcode
        - string textAirline
        - string textTo
        - string textFrom
        - string textDay
        - string texthour
        - string textcost
        - string textMaxseats
        - string textPassengerName
        - string textCitizenship
        - string selectedstatus
        --
        + Task OnInitializedAsync()
        + Task findReservation()
        + void ParseString()
        + void ReservationManager()
    }

    class Airport {
        - string Airline
    }

    class Booking {
        - string ReservationCode
        - string PassengerName
        - string Citizenship
        - string FlightCode
        - string Airline
        - string To
        - string From
        - string Day
        - string Hour
        - int Maxseats
        - double Price
        - string Status
    }

    ReservationFinder --> Airport
    ReservationFinder --> Booking
    interface <|.. ReservationFinder
