# ⚽ Balanced Soccer Team Generator

![.NET](https://img.shields.io/badge/.NET-8.0-5C2D91.svg) ![ASP.NET Core
MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-blue.svg) ![Entity
Framework](https://img.shields.io/badge/Entity%20Framework-Core-512BD4.svg)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-red.svg)
![Docker](https://img.shields.io/badge/Docker-Compose-2496ED.svg)
![Azure](https://img.shields.io/badge/Hosted%20On-Azure%20App%20Service-0089D6.svg)
![License](https://img.shields.io/badge/License-MIT-green.svg)

A web application that generates mathematically balanced soccer teams
using a custom greedy algorithm. Built with **ASP.NET Core MVC**,
**Entity Framework Core**, **SQL Server**, and deployed using **Azure
App Service**.

------------------------------------------------------------------------

## 📋 Overview

The **Balanced Soccer Team Generator** helps coaches easily manage
player rosters and automatically generate fair, balanced teams for
practices or tournaments.

This project was built for:

-   **Course:** 420N54LA.Sec1 --- Fall 2025\
-   **Authors:** Shawn Nabizada, Samuel Reyes Cifuentes, Jake Tremblay\
-   **Date:** November 25, 2025

------------------------------------------------------------------------

## 🛠️ Tech Stack

  -----------------------------------------------------------------------
  Layer                      Technology
  -------------------------- --------------------------------------------
  **Framework**              .NET 8 (ASP.NET Core MVC)

  **Backend**                C#, Entity Framework Core

  **Database**               SQL Server 2022 (Docker for development,
                             Azure SQL for production)

  **Containerization**       Docker & Docker Compose

  **Hosting**                Azure App Service (Linux)

  **Tools**                  VS Code, Azure CLI, Docker Desktop
  -----------------------------------------------------------------------

------------------------------------------------------------------------

## 🧮 Functional Logic

### 1. Player Ranking Formula

Each player receives an **Overall Score** and a **Rank (1--5)** derived
from five attributes:

\[ ext{Overall Score} = rac{ ext{Ball Control} + ext{Passing} +
ext{Dribbling} + ext{Defense} + ext{Shooting} }{5} \]

**Rank thresholds:**

  Rank    Label        Score Requirement
  ------- ------------ -------------------
  **1**   Elite        ≥ 85
  **2**   Great        ≥ 75
  **3**   Good         ≥ 65
  **4**   Average      ≥ 55
  **5**   Developing   \< 55

------------------------------------------------------------------------

### 2. Team Balancing Algorithm

The system uses a **Greedy Snake Draft Algorithm** that ensures balanced
total skill scores across all teams.

**Algorithm Steps:**

1.  Filter players marked as *Selected*\
2.  Sort by Overall Score (descending)\
3.  Distribute players by placing each into the team with the **lowest
    current total score**

**Time Complexity:**

-   Sorting: `O(P log P)`
-   Distribution: `O(P × T)`

------------------------------------------------------------------------

## 🚀 Installation & Local Development

Follow these steps to run the project locally using **Docker Compose**.

### **Prerequisites**

Ensure you have the following installed:

-   **Docker** (Docker Desktop, Docker Engine, or equivalent)
-   **Docker Compose**
-   **Git**
-   **.NET 8 SDK** (optional---only needed if running outside Docker)

### **1. Clone the Repository**

``` bash
git clone https://github.com/YOUR_USERNAME/BalancedSoccerTeamGenerator.git
cd BalancedSoccerTeamGenerator
```

### **2. Navigate to the Application Folder**

``` bash
cd SoccerApp
```

### **3. Build & Start the Containers**

``` bash
docker compose up --build
```

### **4. Access the Application**

Open your browser to:

    http://localhost:5000

------------------------------------------------------------------------

## 🧑‍💻 Usage

### **1. Manage the Roster**

-   Add players with skill attributes\
-   Edit or remove existing players\
-   Filter by position

### **2. Select Players for Team Generation**

-   Use checkboxes to select players\
-   Or use "Select All"

### **3. Generate Balanced Teams**

-   Choose the number of teams\
-   View team cards and compare total scores

------------------------------------------------------------------------

## ☁️ Deployment

The application is live at:

https://soccer-gen-b7dug0auhec9bxcn.eastus-01.azurewebsites.net/

------------------------------------------------------------------------

## 📌 Conclusion

This project demonstrates modern DevOps practices, clean architecture,
and a mathematically sound team balancing algorithm, packaged in a
user-friendly ASP.NET MVC application.

------------------------------------------------------------------------

## 📄 License

This project is licensed under the **MIT License**.
