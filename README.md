
# Concert Ticket Buyer

A secure, full-stack ASP.NET MVC application that allows users to **register**, **log in**, and **buy tickets** for their favorite artists' concerts. The app features a dynamic ticket purchasing experience, an admin panel to manage orders, and supports coupon-based discounts.

----------

## Features

-   User authentication (signup + login)
    
-   Full ticket purchase workflow
    
-   Admin panel to view and manage orders (admin-only access)
    
-   Dynamic UI changes based on ticket availability
    
-   Signup with coupon codes for discount reductions
    
-   Secure and robust architecture with repository and service layers
    

----------

## Tech Used

-   **Framework:** ASP.NET MVC (C#)
    
-   **Frontend:** Bootstrap 5
    
-   **Database:** SQL Server (local for development, Azure SQL for production)
    
-   **Architecture:** MVC with Repository & Service layers
    
-   **IDE:** Visual Studio 2022
    
-   **Version Control:** GitHub Desktop
    
-   **Deployment:** Azure Web App Service (Windows)
    

----------

## Architecture Overview

The project is built following the MVC pattern with distinct Repository and Service layers for maintainability and separation of concerns:

-   **Models:** Represent data structures (Tickets, Users, Orders, Coupons, etc.)
    
-   **Views:** Dynamic UI with Bootstrap 5 for responsive design
    
-   **Controllers:** Handle user requests and interact with services
    
-   **Repository Layer:** Abstracts database operations
    
-   **Service Layer:** Business logic and workflows
    

----------

## Base URL

> 🟢 **Deployed App:**  
> https://concerttickets20250804195258-hqhugjdvebbybyen.westeurope-01.azurewebsites.net/

----------

## Authentication

-   Register at: `/Account/Register`
    
-   Log in at: `/Account/Login`
    
-   Admin panel accessible only to users with admin credentials at `/Admin/Orders`
    

----------

## Endpoints Overview

### User Authentication

-   **Signup:** `/Account/Register`
    
-   **Login:** `/Account/Login`
    
-   **Logout:** `/Account/Logout`
    

### Ticket Purchasing

-   Browse events and tickets on `/`
    
-   Purchase tickets with dynamic UI based on availability
    
-   Apply coupons during signup or purchase for discounts
    

### Admin Panel (admin-only)

-   View and manage all orders: `/Admin/Orders`
    

----------

## Running Locally

```bash

# 1. Clone the repo
git clone https://github.com/Achra-f/AD-Project-2425.git
cd AD-Project-2425

# 2. Configure local SQL Server connection string in appsettings.json
echo "Make sure to set your connection string in appsettings.jsonlike this:"
echo "\"Server=(localdb)\\\\mssqllocaldb;Database=ConcertTicketsDb;Trusted_Connection=True;\""

# 3. Run the database migration in Package Manager Console
PM> Update-Database

# 4. Run the solution (f5)

```


