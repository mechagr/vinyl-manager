# Vinyl Manager (September 2025)

Vinyl Manager is a full-stack web application for managing vinyl record collections, built with ASP.NET Core MVC.

This project was created to demonstrate Model–View–Controller architecture, Entity Framework Core integration, and user authentication systems. It showcases my ability to build complete web applications with database persistence, RESTful routing, and secure user management within a modern web framework.

---

## Project Overview

The goal of Vinyl Manager is to allow users to build and maintain a personal vinyl record collection. Users can add, edit, delete, and organise their records by artist and genre, with full user authentication protecting their data. Information is stored in SQL Server with Entity Framework Core handling all database operations.

The application demonstrates:

- Model–View–Controller (MVC) architectural pattern  
- Entity Framework Core with Code First migrations and relationships  
- ASP.NET Identity for user authentication and authorisation  
- RESTful CRUD operations with proper HTTP verbs and routing  
- Razor views with server-side rendering and Bootstrap styling  
- Database design with foreign keys and navigation properties  

---

## Features

- **Add, Edit, and Delete Records** – complete CRUD system for vinyl management  
- **Artist and Category Management** – organise collection by performer and genre  
- **User Authentication** – secure registration and login system  
- **Data Relationships** – properly linked records, artists, and categories  
- **Responsive Design** – Bootstrap-powered UI that works on all devices  
- **Database Seeding** – automatically populate with sample vinyl records  
- **Form Validation** – client- and server-side input validation  
- **Privacy-Conscious** – GDPR-compliant data handling and user privacy controls  

---

## Technologies Used

- **Language**: C#  
- **Framework**: ASP.NET Core MVC (.NET 8)  
- **Database**: SQL Server with Entity Framework Core  
- **Authentication**: ASP.NET Identity  
- **Frontend**: Razor Views, Bootstrap 5, HTML5/CSS3  
- **Concepts**: MVC pattern, ORM, authentication, RESTful APIs, responsive design  

---

## How to Run

Clone the repository and run the application locally:  

```bash
git clone https://github.com/your-username/VinylManager.git
cd VinylManager
dotnet ef database update
dotnet run
