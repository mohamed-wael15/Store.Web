▶ FoodStore🍔
----------------------------------
▶ Overview👀

   - This is a complete platform dedicated to popular foods, built using the .NET Web API. The platform allows users to browse, search and purchase foods while providing a powerful admin panel to manage products, orders and users.

----------------------------------
▶ Features 
   - User Authentication: Secure login and registration system.
   - Product Management: Get all brands, Get all Types, Get all Products,Get all Product by Id.
   - Shopping Cart: Real-time cart management with the ability to add, update, and remove items.
   - Order Management: Process and manage customer orders.
   - User Manager : Manage Food products, orders, and user information.
   - Payment Integration: Secure payment handling for Food purchases.
-----------------------------------
▶ Technologies used

 The project was developed using the following technologies and tools:

 ◉ Programming language and databases:

   - C#: The basic programming language for developing the project.

   - SQL Server: The database used to store data.

 ◉ Framework:

   - ASP.NET Core Web API: To develop API interfaces.

 ◉ Data management:

   - Entity Framework Core: To deal with the database using the Object-Relational Mapping (ORM) approach.

   - Specification Pattern: To simplify and target complex queries.

 ◉ Authentication and security:

   - JWT (JSON Web Token): To authenticate users and secure access to interfaces.
     
 ◉ Performance and experience improvement:

   - Middleware: To manage requests and responses between the server and the client.

   - Caching: Improve performance using temporary data storage.

   - Redis: A high-performance caching system.

  ◉ Data management and presentation:

   - AutoMapper: To facilitate data transformation between entities and presentation interfaces.
     
  ◉ Electronic payment:

   - Stripe API: To manage electronic payment processes easily and securely.
     
▶ Key features of the project

  - Code organization: Using the Specification Pattern.
  
  - Comprehensive documentation: with tools like Swagger.

  - Performance optimization: with caching and Redis.
    
  - Secure and easy payment: with Stripe.
-----------------------------------------------
▶ Getting Started

Prerequisites

Ensure you have the following installed on your machine:

  - .NET SDK 
  - SQL Server 
  - Redis 
  - Stripe Account
-------------------------------------------
Setup Instructions

  1-Clone the Repository
  
   Clone the project to your local machine:
    
      git clone https://github.com/mohamed-wael15/StoreAPI.git
  
  2-Install Dependencies
 
   Restore the required dependencies:
   
     dotnet restore
     
 3-Database Setup

 - Update the connection string in appsettings.json to point to your SQL Server instance.
 - Run the following command to apply migrations and set up the database:
   
       dotnet ef database update

  4-Configure Redis

  - Ensure Redis is running on your machine or a server.
  - Update the Redis connection string in appsettings.json.

 5- Configure Stripe
    - Add your Stripe API keys in appsettings.json under the relevant section:
    
        {
           "Stripe": {
               "PublishableKey": "<Your-Publishable-Key>",
               "SecretKey": "<Your-Secret-Key>"
            }
         }

  6- Run the Application
    - Use the following command to start the API:
    
        dotnet run

  7-Access the API
    - The API will be available at:
           http://localhost:<port> (default: 5000 or 5001 for HTTPS)
    - Open Swagger for API documentation and testing:
           http://localhost:<port>/swagger

نسخ الكود


