# 📚 Library Management System

A desktop-based Library Management System built in C#. Designed with a modular architecture and intuitive UI, this system streamlines book and member management using JSON-based storage.

---

## 🚀 Features

- 🔐 **Login/Signup System** – Password-protected access for users  
- 📖 **Book Management** – Add, search, issue, and return books  
- 👤 **Member Management** – Add and view member records  
- 🔍 **Search Functionality** – Quick lookup for books and members  
- 📊 **Inventory Dashboard** – Overview of current library status  
- ✅ **Input Validation** – Prevents invalid entries and ensures data consistency  

---

## 🧱 Architecture

**Classic Layered N-Tier Architecture**

| Layer               | Description                                                                 |
|--------------------|-----------------------------------------------------------------------------|
| Presentation Layer | UI forms (Login, Dashboard, Book/Member forms)                              |
| Business Logic     | Handles validation, book issuance/return, and user operations               |
| Data Access Layer  | Reads/writes data to JSON files (books, members, users)                     |

> This architecture ensures separation of concerns, easy maintenance, and future scalability (e.g., migrating from JSON to a database).

---

## 🖼️ UI Design

- Designed using **Figma**
- Clean layout with logical grouping of features
- Forms for each operation (Add Book, Add Member, Issue/Return Book)
- Dashboard with navigation buttons

---
## ⚙️ Nonfunctional Requirements

- **Usability**: Intuitive interface, error messages, and logical grouping  
- **Reliability**: Robust checks to prevent invalid data storage  
- **Maintainability**: Modular codebase with reusable logic  

---

## 📌 Constraints

- Desktop-only application (no online/multi-user support)  
- JSON storage may not scale for large datasets  
- No role-based access control (e.g., admin vs. librarian)

---

## 🧪 Lessons Learned

- Applied modular programming principles in C#
- Gained hands-on experience with JSON data handling 
- Understood the importance of UI/UX and error handling

---

## 🛠️ Setup Instructions

1. Clone the repository  
2. Open the solution in Visual Studio  
3. Run the project (ensure `.json` files are present in the correct directory)  
4. Use the login/signup form to access the dashboard

---

This project is for academic purposes. Feel free to fork and modify for learning or personal use.

---
