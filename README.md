# Plastika
Aplikasi jual beli sampah dan produk dari vendor dan agen pengumpul sampah  

## Team

**Kelompok Plastika**

- **Ketua Kelompok:** Muhamad Farrel Adrian  
  NIM: 22/505897/TK/55394

- **Anggota 1:** Natanael Albert  
  NIM: 22/503184/TK/54968

- **Anggota 2:** Faundra Pratama Sukma  
  NIM: 22/505520/TK/55323
Class Diagram Plastika:

![Class diagram junpro drawio](https://github.com/user-attachments/assets/5fef6e5f-9597-413f-a7f7-da710abd4218)

Certainly! Below is the modified and neatly formatted GitHub README for your **Plastika** project.

---

# Plastika

Aplikasi jual beli sampah dan produk dari vendor serta agen pengumpul sampah.

![Plastika Logo](https://github.com/user-attachments/assets/5fef6e5f-9597-413f-a7f7-da710abd4218) <!-- Replace with your actual logo URL -->

## Introduction

**Plastika** is a Windows Forms application designed to revolutionize the management of plastic waste through a circular economy approach. It facilitates the buying and selling of plastic waste and crafted plastic products, connecting waste agents with vendors to promote sustainability and environmental responsibility.

With features such as user authentication, profile management, interactive maps, ordering, and payment systems, Plastika aims to create a seamless and efficient platform for transforming plastic waste into valuable resources.

## Features

### User Authentication
- **Login and Register:** Secure registration and login system for all users.

### Profile Management
- **Update and View Profile:** Users can update their personal and business information and view profiles of other users.

### Item Management
- **Add Items:** Agents can add plastic waste items, and vendors can add crafted plastic products.
- **Manage Items:** Edit or remove items from the inventory.

### Marketplace
- **Order and Payment:** Seamless ordering and payment processing for both plastic waste and crafted products.

### Interactive Maps
- **Locate Services:** Find collection points for plastic waste and distribution locations for products using integrated maps.

### Role-Based Access
- **Agen Sampah (Waste Agents):** Manage plastic waste collection and sales.
- **Vendor:** Manage crafted plastic products and sales.

### Notifications
- **Real-Time Updates:** Receive updates and alerts related to orders, payments, and profile changes.

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework / .NET Core *(Please specify which one you're using)*
- **IDE:** Visual Studio
- **Database:** PostgreSQL
- **Payment Gateway:** [Midtrans](https://midtrans.com/) for secure payment processing.
- **Cloud Hosting:** [AWS (Amazon Web Services)](https://aws.amazon.com/) for reliable and scalable cloud hosting.

### Libraries & Tools
- **Google Maps API:** For map integration.
- **Entity Framework:** For database management.
- **Node.js:** For running the payment server using Midtrans.


## Installation

Follow these steps to set up **Plastika** locally on your machine.

### Prerequisites

- **Operating System:** Windows 10 or later
- **.NET Framework:** Version X.X *(Please specify the required version)*
- **Node.js:** Version X.X *(Please specify the required version)*
- **Database:** PostgreSQL
- **IDE:** Visual Studio 2019 or later

### Steps

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/plastika.git
   ```

2. **Open the Project:**

   - Navigate to the cloned repository folder.
   - Open `Plastika.sln` using Visual Studio.

3. **Configure the Database:**

   - Update the connection string in `App.config` or `appsettings.json` *(depending on your setup)* to match your PostgreSQL database configuration.

4. **Set Up Payment Server:**

   - Navigate to the `midtrans-payment` directory:

     ```bash
     cd midtrans-payment
     ```

   - Install the necessary dependencies:

     ```bash
     npm install
     ```

   - Start the payment server:

     ```bash
     node server.js
     ```

   - Ensure that the payment server is running before starting the main application.

5. **Install Dependencies:**

   - Restore NuGet packages via Visual Studio:
     - Go to `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution`.
     - Click on `Restore` to install all required packages.

6. **Configure AWS Hosting (Optional):**

   - If you plan to deploy the application to AWS, configure your AWS credentials and settings as per the deployment documentation.

7. **Build and Run:**

   - Build the solution by pressing `Ctrl + Shift + B` or navigating to `Build` > `Build Solution`.
   - Run the application by pressing `F5` or clicking the `Start` button.



*Last updated on November 25, 2024.*

---

Feel free to customize the placeholders (e.g., `yourusername`, email addresses, LinkedIn profiles, and image URLs) with your actual project and team information.
