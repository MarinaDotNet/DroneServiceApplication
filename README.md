# Drone Service Application

## Overview
This application is designed to log and manage drones that require service and repair. It organizes drones into two service categories: Regular and Express. The Express service includes an additional 15% charge. The application uses two Queue<T> data structures to manage the order of service requests. Once a drone is repaired, it is removed from the appropriate queue and added to a list of completed work. The application includes full error trapping and displays feedback messages via a status strip at the bottom of the form. It is built using the Windows Forms Application Framework and .NET Core.

## Features
- **Queue-Based Service Management:**
  + Uses two Queue<T> structures to manage drones for Regular and Express service categories.
  + Each entry in the queue contains the following attributes:
    * **Client Name:** The name of the drone owner.
    * **Drone Model:** The model of the drone.
    * **Service Problem:** A description of the problem or service needed.
    * **Service Cost:** The base cost of the service.
    * **Service Tag:** A unique identifier for the service request.
**Express Service Charge:** The base service cost is increased by a 15% surcharge for Express service.
- **Dequeue and Complete Service:** Once repaired, the drone is removed from the queue and the details are added to the list of completed work.
- **Error Trapping and Feedback:** This includes full error handling, with feedback displayed in a status strip at the bottom of the form.
- **User-Friendly Interface:** Designed with Windows Forms, providing an intuitive interface for managing drone service requests.

## Technologies Used
- **Programming Language:** C#
- **Framework:** .NET Core, Windows Forms
- **Data Structures:** Queue<T> for service management
- **Tools:** Git for version control, Visual Studio IDE

## Screenshot
Here’s a preview of the running application:

![Drone Service Application](https://github.com/user-attachments/assets/c16e444f-e987-4ba3-875f-65f2e7fc5f51)

## UML Class Diagram
Below is the UML class diagram illustrating the key classes and relationships:

![Drone Service Application UML](https://github.com/user-attachments/assets/c7cfc138-4fff-4aa1-9294-3e7a378a3d41)

