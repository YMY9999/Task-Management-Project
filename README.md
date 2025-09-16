# Task Management System (.NET 8, WinForms, Entity Framework Core)

A modern Windows Forms application for personal task management, built with .NET 8 and Entity Framework Core. This project allows users to register, log in, and manage their tasks with features like categorization, prioritization, status tracking, overdue alerts, reporting, and more.

## Features

- **User Registration & Login:** Secure user management with unique email validation.
- **Task CRUD:** Create, read, update, and delete tasks with title, description, due date, status, priority, and category.
- **Task Status & Priority:** Track tasks as Pending, In Progress, or Completed. Prioritize as Low, Medium, or High.
- **Categories:** Organize tasks by custom categories.
- **Overdue Alerts:** Automatic and manual alerts for overdue tasks, highlighted in red.
- **Search & Filter:** Search tasks by title/description, filter by status or priority, and group by priority.
- **Sorting & Pagination:** Sort tasks by due date and navigate with pagination.
- **Reporting:** Generate a detailed report with a pie chart visualization of task statuses.
- **Average Completion Time:** Estimate average completion time for completed tasks.
- **Modern UI:** Responsive WinForms interface with DataGridView, ComboBoxes, and Chart controls.

## Technologies Used

- **.NET 8.0 (WinForms)**
- **Entity Framework Core 9**
- **SQL Server (localdb or your own connection)**
- **HIC.System.Windows.Forms.DataVisualization** (for charting)
- **C# 12**

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server (Express, LocalDB, or full)

### Setup

1. **Clone the repository:**

2. **Configure the database:**
- Update the connection string in `AppDbContext` (usually in `Context/AppDbContext.cs`) to point to your SQL Server instance.

3. **Apply migrations (if needed):**
- Open the Package Manager Console in Visual Studio.
- Run:
  ```
  Update-Database
  ```

4. **Build and run:**
- Press `F5` or click "Start" in Visual Studio.

## Usage

- **Register:** Click "Sign Up" to create a new account.
- **Login:** Enter your username and email to log in.
- **Manage Tasks:** Add, edit, delete, search, filter, and sort your tasks.
- **Check Overdue:** Click the "Check Overdue" button or wait for automatic alerts.
- **Generate Report:** Click "Generate Report" for a summary and pie chart.
- **Logout:** Click "Logout" to return to the login screen.

## Project Structure

- `Models/` - Entity classes (`User`, `TaskItem`, `Category`)
- `Context/` - Entity Framework Core DbContext
- `Form1.cs` - Main task management UI
- `LoginForm1.cs` - Login screen
- `SignUpForm.cs` - Registration screen
- `ReportForm.cs` - Reporting and chart visualization
- `Program.cs` - Application entry point

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.
