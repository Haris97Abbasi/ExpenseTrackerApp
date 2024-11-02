# Personal Expense Tracker

## Overview
Personal Expense Tracker is a robust desktop application developed using the WPF framework with the MVVM design pattern in .NET. This application allows users to manage their personal finances by tracking expenses across various categories, providing insights into spending habits, and aiding in efficient financial planning.

## Features
- **Add/Edit/Remove Expenses**: Users can add new expenses, edit existing entries, and remove unwanted expenses.
- **Categorization**: Expenses can be categorized for better tracking and analysis.
- **Expense Analysis**: Visual graphs to show spending trends over time, helping users understand their major expenditure areas.
- **User Authentication**: Secure login system to ensure data privacy.
- **Database Integration**: Utilizes SQL Server for robust data management and query capabilities.
- **Responsive Design**: Adapts gracefully between different screen sizes ensuring a consistent user experience across all device types.
- **Accessibility Features**: Includes high-contrast themes and screen reader support for visually impaired users.

## Technologies Used
- **.NET (WPF Framework)**: Used for creating the desktop application with a rich user interface.
- **MVVM Architecture**: Ensures a clean separation of concerns, making the application easy to manage and scale.
- **Visual Studio 2022**: Provides a powerful IDE for developing, testing, and debugging the application.
- **SQL Server**: Manages all data storage, retrieval, and manipulation efficiently and securely.
- **Entity Framework Core**: Used for ORM to interact with the database using strongly typed objects.

## Getting Started
These instructions will get your copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
- Microsoft Visual Studio 2022
- SQL Server

### Installation
1. Clone the repository:
```bash
git clone https://github.com/yourusername/personal-expense-tracker.git
```
2. Open the solution file in Visual Studio.
3. Restore NuGet packages:
```bash
Update-Package -reinstall
```
4. Update the connection string in `App.config` to match your SQL Server instance.
5. Build the solution to verify everything is set up correctly.

## Usage
To use the application, run the executable and log in. From the dashboard, you can start adding and categorizing your expenses. Use the analysis tab to view graphs and insights.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change. Please make sure to update tests as appropriate.

## License
Distributed under the MIT License. See `LICENSE` for more information.

## Contact
Haris Abbasi - haris97duisburg@gmail.com
GitHub: [Haris97Abbasi](https://github.com/Haris97Abbasi)
