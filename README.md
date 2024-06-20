# Calendar Management Application  -  Connecting .NET MAUI app to SQLite Database

This repository contains the source code for a Calendar Management Application built using .NET MAUI and SQLite. The application helps users to plan and organize their events efficiently across different months, weeks, and days.

## Features

- **Simple User Access:** Users can open the application directly to access their dashboard.
- **Dashboard:** View a summary of events for the current month, week, and day, including date/time and status indicators (active, completed).
- **Event Management (CRUD):** Add, read, update, and delete events with fields such as title, date, time, and location.
- **Calendar View:** Display a calendar with marked events and the ability to click on a day to see the events for that day.
- **Reminder Notifications:** Local notifications to remind users of upcoming events.

## Technologies and Libraries Used

- .NET MAUI (Multi-platform App UI)
- SQLite for local data storage
- MVVM (Model-View-ViewModel) design pattern

## Screenshots

### Home Screen

<img src="https://github.com/Daaouan/.Net-MAUI-SQLite-Application-Calendar-Management-/assets/123327203/8ed8a1a6-d097-4ad8-8b02-9b0353e773bd" alt="Screenshot 8" width="80" height="200" />

The home screen displays the calendar for the current month. Users can navigate between months and years using the navigation buttons on either side of the month and year indicators. Each day of the month is represented, with events for the selected day highlighted.

### Adding a New Event


<img src="https://github.com/Daaouan/.Net-MAUI-SQLite-Application-Calendar-Management-/assets/123327203/bd54f845-a546-465e-b1ae-01d5e14eb9a7)" alt="Screenshot 8" width="80" height="200" />


When the user clicks the "+" button at the bottom right of the home screen, a form appears allowing the addition of a new event. This form includes fields for the event title, description, and date. Users can save the event by clicking the "Save" button.

### Viewing Event Details


<img src="https://github.com/Daaouan/.Net-MAUI-SQLite-Application-Calendar-Management-/assets/123327203/2142bcde-a0df-4695-b182-eca2025a76b2" alt="Screenshot 8" width="80" height="200" />


When a day with events is selected, the details of the events for that day are displayed below the calendar. Each event is listed with its title and description, providing a clear and organized view of the user's engagements for the day.

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/Daaouan/.Net-MAUI-SQLite-Application-Calendar-Management-.git
    ```

2. Navigate to the project directory:
    ```sh
    cd Calendar
    ```

3. Build the project:
    ```sh
    dotnet build
    ```

4. Run the project:
    ```sh
    dotnet run
    ```

## Usage

- Open the application to view the dashboard.
- Navigate through the calendar to select different days, months, and years.
- Click the "+" button to add new events.
- Click on a day to view the events scheduled for that day.
- Edit or delete events as needed.

## Contributors

- **DAAOUAN Mohammed**
- **FRIKH Said**

## Supervised by

- **Pr. Hassan ZILI**

## Contributing

Contributions are welcome! Please fork this repository and submit a pull request with your changes.
