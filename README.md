# AeroMils Fleet Management System

This is a collaborative project being developed by Me and [Daniel Pereira](https://github.com/Daniel22Pereira) as part of Structured Computer Programming class at [ATEC](https://www.atec.pt/).  
The AeroMils Fleet Management System aims to provide a comprehensive solution for managing the aviation assets of AeroMils, a company operating in the aviation sector.

## Functionality

The system will include the following features:

 1. Class: Empresa
    - Contains a list of Aviões.
 2. Windows Forms Interface
    - The application will provide a user-friendly interface with the following options:
        - a. Insert new Avião (any type).
        - b. Change the status of an Avião.
        - c. View available Aviões for charter (Particulares and Mercadorias) filtered by Avião type, considering the current date.
        - d. View Aviões under maintenance.
        - e. Calculate freight price by indicating the start and end date and the desired Avião.
        - f. Export Aviões information to a CSV file.
 3. Reservation System
    - Implement a reservation system for Aviões.
 4. Calculate Total Price
    - Calculate the total value between two dates according to the reservation system (for all chartered Aviões).
 5. Simulated Date
    - Add a date simulator option, allowing the user to advance one day. The system should check all Aviões and display an alert if the end date of a charter or maintenance has been reached.

### Project Status

- Started implementing the classes and the interfaces for the application
