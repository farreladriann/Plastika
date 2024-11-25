# Plastika
Aplikasi jual beli sampah dan produk dari vendor dan agen pengumpul sampah  

Kelompok Plastika  
Ketua Kelompok: Muhamad Farrel Adrian 22/505897/TK/55394  22/505897/TK/55394   
Anggota 1: Natanael Albert - 22/503184/TK/54968  
Anggota 2: Faundra Pratama Sukma - 22/505520/TK/55323  

Class Diagram Plastika:

![Class diagram junpro drawio](https://github.com/user-attachments/assets/5fef6e5f-9597-413f-a7f7-da710abd4218)

##Introduction
Plastika is a Windows Forms application designed to revolutionize the management of plastic waste through a circular economy approach. It facilitates the buying and selling of plastic waste and crafted plastic products, connecting waste agents with vendors to promote sustainability and environmental responsibility.

With features such as user authentication, profile management, interactive maps, ordering, and payment systems, Plastika aims to create a seamless and efficient platform for transforming plastic waste into valuable resources.

##Features
User Authentication:
Login and Register: Secure registration and login system for all users.
Profile Management:
Update and View Profile: Users can update their personal and business information and view profiles of other users.
Item Management:
Add Items: Agents can add plastic waste items, and vendors can add crafted plastic products.
Manage Items: Edit or remove items from the inventory.
Marketplace:
Order and Payment: Seamless ordering and payment processing for both plastic waste and crafted products.
Interactive Maps:
Locate Services: Find collection points for plastic waste and distribution locations for products using integrated maps.
Role-Based Access:
Agen Sampah (Waste Agents): Manage plastic waste collection and sales.
Vendor: Manage crafted plastic products and sales.
Notifications:
Receive updates and alerts related to orders, payments, and profile changes.


Technologies Used
Programming Language: C#
Framework: .NET Framework / .NET Core (specify which one you're using)
IDE: Visual Studio
Database: PostgreSQL
Payment Gateway: Midtrans for secure payment processing.
Cloud Hosting: AWS (Amazon Web Services) for reliable and scalable cloud hosting.
Libraries & Tools:
Google Maps API (for map integration)
Entity Framework (for database management)
Node.js (for running the payment server using Midtrans)
... (add any other libraries or tools you're using)
Installation
Follow these steps to set up Plastika locally on your machine.

Prerequisites
Operating System: Windows 10 or later
.NET Framework: Version X.X (specify the required version)
Node.js: Version X.X (specify the required version)
Database: PostgreSQL
IDE: Visual Studio 2019 or later
Steps
Clone the Repository:
bash


git clone https://github.com/yourusername/plastika.git
Open the Project:
Navigate to the cloned repository folder.
Open Plastika.sln using Visual Studio.
Configure the Database:
Update the connection string in App.config or appsettings.json (depending on your setup) to match your PostgreSQL database configuration.
Set Up Payment Server:
Navigate to the midtrans-payment directory:
bash


cd midtrans-payment
Install the necessary dependencies:
bash


npm install
Start the payment server:
bash


node server.js
Ensure that the payment server is running before starting the main application.
Install Dependencies:
Restore NuGet packages via Visual Studio:
Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.
Click on Restore to install all required packages.
Configure AWS Hosting (Optional):
If you plan to deploy the application to AWS, configure your AWS credentials and settings as per the deployment documentation.
Build and Run:
Build the solution by pressing Ctrl + Shift + B or navigating to Build > Build Solution.
Run the application by pressing F5 or clicking the Start button.
