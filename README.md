# Student Management System (Web Forms - ASP.NET)

1.	WELCOME

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/WELCOME.png)

2.	CRUD OPERATION (PAGE LOAD)

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/PAGE%20LOAD.png)

3.	ADD

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/ADD.png)

4.	UPDATE

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/UPDATE.png)

5.	DELETE (using Student ID only)

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/DELETE.png)
 
6.	SEARCH  (using Student ID and if Student found information shown in the fields)

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/SEARCH.png)

7.	Clear

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System--Web-Forms---ASP.NET-/blob/main/Output%20SS/Clear.png)

The Student Management System is a web-based application developed using ASP.NET Web Forms (C#) and SQL Server as the backend database. This project allows users (such as school or college administrators) to Add, Update, Delete, Search, and Display student information efficiently.

The system is designed with a user-friendly interface using Bootstrap 5 for responsive layout and enhanced UI. It consists of multiple web forms including a Welcome page, a Main CRUD page (Default.aspx), and a Master Page for consistent layout across pages.

📁 Project Structure:

✅ 1. Welcome Page (Welcome.aspx)

Purpose: Acts as the landing page for the application.

Features:

Introduction text.

"Continue" button that navigates to the main student management system (Default.aspx).

UI: Styled with custom CSS and Bootstrap.

✅ 2. Main CRUD Page (Default.aspx)

Purpose: Allows users to perform CRUD (Create, Read, Update, Delete) operations on student data.

Features:

Input Form to enter student details:

Student ID

Student Name

Roll Number

Email

Age

CRUD Buttons:

Add: Insert new student into the database.

Update: Modify existing student details.

Delete: Remove a student record based on Student ID.

Search: Retrieve student data using Student ID.

Clear: Reset input fields.

GridView: Displays the list of all students from the database.

✅ 3. Master Page (Site.Master)

Purpose: Provides a consistent layout with shared components like header/nav bar.

Features:

Bootstrap-enabled responsive design.

Navigation bar titled “Student Management”.

🗄️ Backend Details (Default.aspx.cs)

Language Used: C#

Database: SQL Server (Database Name: Studentweb, Table: Students)

Connection String:

Database Operations:

Insert student using parameterized query in BtnAdd_Click.

Update student record using StudentId as a key.

Delete student record using StudentId.

Search student by ID and populate form fields.

Load all students into GridViewStudents during page load.

💡 Technologies Used:

| Category             | Technology Used                              |
| -------------------- | -------------------------------------------- |
| Frontend             | ASP.NET Web Forms                            |
| Styling              | Bootstrap 5, CSS                             |
| Server-side Language | C#                                           |
| Database             | SQL Server                                   |
| UI Controls          | ASP.NET Controls (TextBox, Button, GridView) |
| Hosting              | Local IIS or Visual Studio Debug Server      |

🛠️ Key Functionalities:

💾 Add Student: Save new student data to the database.

✏️ Update Student: Modify details of existing student using ID.

❌ Delete Student: Remove student record.

🔍 Search Student: Auto-fill the form with data of searched student.

📋 View All Students: Auto-refreshing GridView shows updated list after every operation.

🧹 Clear Fields: Reset all form inputs to blank.

