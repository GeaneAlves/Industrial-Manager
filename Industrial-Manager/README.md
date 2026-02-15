# 🏭 Industrial Manager - Inventory System

Full-stack application developed for industrial inventory management, featuring automated production suggestions prioritized by market value.

## 🚀 Key Features

* **Authentication System:** Secure login and user registration with route protection.
* **Inventory Management:** Full CRUD for Raw Materials and Final Products.
* **Smart Production (RF004):** Algorithm that suggests the maximum possible production units based on current stock, prioritizing items with higher profitability.
* **Real-time Search:** Interactive search bar with instant filtering for materials and products.
* **User Experience:** Responsive dashboard with Home navigation and Logout functionality.

## 🛠️ Technologies & Tools

* **Backend:** .NET 9 (C#) using ASP.NET Core Web API.
* **Database:** SQLite with Entity Framework Core for data persistence.
* **Frontend:** HTML5, CSS3, and Vanilla JavaScript (ES6+).
* **Icons:** FontAwesome for intuitive UI elements.
* **Tools Used:** VS Code, Git, and .NET CLI.

## ⚙️ How to Run the Project

### Prerequisites
* [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed.
* A modern web browser (Chrome or Edge recommended).

### Steps
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/GeaneAlves/Industrial-Manager.git](https://github.com/GeaneAlves/Industrial-Manager.git)
    ```
2.  **Navigate to the project folder:**
    ```bash
    cd Industrial-Manager
    ```
3.  **Start the API:**
    ```bash
    dotnet run
    ```
    *Keep the terminal open. The API will listen on `http://localhost:5008`*.

4.  **Access the Interface:**
    * Open the file `landing.html` directly in your browser.
    * Click on **"Access System"** to go to the Login page.

### 🔐 Test Credentials
* **User:** `admin`
* **Password:** `admin`
* **User:** `abc`
* **Password:** `123`
* *(Alternatively, use the "Register" page to create your own local credentials)*.

## 📄 Project Standards (RNF)
* **RNF007:** Entire codebase and documentation developed in English.
* **CORS:** Configured to allow seamless communication between the local frontend and API.
