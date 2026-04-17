# 🚀 ASCENTRA – Career Guidance System

**ASCENTRA** is a desktop-based career guidance application built using **C# (.NET Windows Forms)** with a modern UI powered by **MetroFramework** and a backend database using **Microsoft SQL Server**.

The name *Ascentra* comes from *“Ascent”*, representing growth, progress, and moving forward in one's career journey.

---

## 📌 Overview

ASCENTRA helps students and beginners discover suitable career paths through an **interactive quiz-based system**. Based on user responses, it intelligently recommends fields like:

- 🌐 Web Development  
- 🤖 Machine Learning  
- 🎨 Graphic Design  

Each recommendation comes with a **structured roadmap** and learning resources.

---

## 🎯 Features

- 🔐 User Login System (with validation)
- 🧑 User Profile Management
- 🧠 Quiz-Based Career Recommendation
- 📊 Dynamic Result Calculation
- 🗺️ Career Roadmaps (Web, ML, Design)
- 💾 SQL Database Integration (CRUD operations)
- 🎥 Learning Resources (YouTube integration)
- 📋 Data Display using DataGridView

---

## 🛠️ Technologies Used

| Component | Technology |
|----------|-----------|
| Language | C# (.NET Framework) |
| UI Framework | MetroFramework |
| Database | Microsoft SQL Server |
| IDE | Visual Studio |
| Architecture | Event-Driven Programming |

---

## ⚙️ System Workflow

1. Start Screen (Load Form)
2. Login Authentication
3. User Data Input
4. Career Quiz (6 Questions)
5. Score Evaluation
6. Career Recommendation
7. Roadmap Display
8. User Data Storage in SQL

---

## 🧩 Modules / Forms

### 🔹 Load Form
- Entry point with Start button

### 🔹 Login Form
- Username/Password validation  
- Password visibility toggle  
- About section  

### 🔹 User Form
- Collects:
  - Name  
  - Age  
  - Gender  
  - Education  
  - Interests  

### 🔹 Quiz Form
- 6-question assessment  
- Calculates scores for:
  - Web Development  
  - Machine Learning  
  - Design  

### 🔹 Roadmaps
- Web Development → HTML, CSS, JS, Backend  
- Machine Learning → Math, Python, Deep Learning  
- Design → Tools, Fundamentals, Portfolio  

### 🔹 User Info Form
- Full CRUD operations  
- Displays data using DataGridView  

---

## 🗄️ Database Design

**Database Name:** `AscentraDB`

### Table: `UserInfo`

| Column | Type |
|--------|------|
| Id | INT (Primary Key) |
| Name | NVARCHAR(100) |
| Age | INT |
| Gender | NVARCHAR(50) |
| Education | NVARCHAR(100) |
| Interest | NVARCHAR(255) |

### SQL Script

```sql

```

---

## 🔌 Connection String

```plaintext

```

---

## 🧪 Testing

- Login validation (valid/invalid inputs)  
- Database CRUD operations  
- Quiz logic accuracy  
- Roadmap navigation  
- Exception handling  

---

## 📸 Screenshots

Add your images in a `/screenshots` folder:

```
![Login](screenshots/LoginForm_UI.png)
![Quiz Result](screenshots/QuizForm_Result.png)
![Web Roadmap](screenshots/WebDevRoadmap_UI.png)
```

---

## 📈 Results

- Smooth navigation across all modules  
- Accurate career recommendations  
- Fully functional database operations  
- Clean and responsive UI  

---

## 🚀 Future Improvements

- AI-based recommendation engine  
- Integration with platforms (Coursera, Udemy)  
- Dark/Light Mode  
- Voice assistance  
- Export progress as PDF  

---

## 👩‍💻 Author

**Hoor-Ain Rajput**  


---

## 📎 Note

This project demonstrates:
- GUI Design  
- Database Integration  
- Modular Programming  
- Real-world application structure  
