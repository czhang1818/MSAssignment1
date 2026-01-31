# 🛒 Product Catalog (ASP.NET Core MVC)

A simple web application built with ASP.NET Core MVC that demonstrates the fundamentals of the Model-View-Controller design pattern. This project allows users to browse a catalog of technology products and view detailed information for each item.

## 🚀 Features

* **Product Listing (ShowAll):** Displays a responsive table of all products with images, names, and prices.
* **Product Details (ShowById):** A dedicated detail view using Bootstrap Cards to show full descriptions and larger images.
* **Business Logic Layer:** Simulates a data source using a static list service, separating data management from the Controller.
* **Responsive UI:** Styled with Bootstrap for a clean look on both desktop and mobile.

## 🛠️ Technologies Used

* **Framework:** ASP.NET Core MVC (.NET 10.0)
* **Language:** C#
* **Frontend:** HTML5, Razor Views (.cshtml), Bootstrap 5
* **IDE:** Visual Studio 2026

## 📂 Project Structure

The project follows the standard MVC architecture:

* **Models (`/Models/Product.cs`):** Defines the data structure (Id, Name, Price, Image, Description).
* **Views (`/Views/Product/`):**
    * `ShowAll.cshtml`: The main catalog table.
    * `ShowById.cshtml`: The individual product detail card.
* **Controllers (`/Controllers/ProductController.cs`):** Handles user requests and directs traffic.
* **Services (`/Services/ProductBL.cs`):** Acts as the "Mock Database," storing the list of products and handling data retrieval logic.
