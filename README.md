# Architecture of .NET Core Microservices with RabbitMQ Messaging in the Banking Sector
## Introduction
Hello, my name is Mykola Lehkyi, and I am a Software Engineer.

## Project Overview
This project is a comprehensive system designed to implement two microservices: Banking and Transfer, along with a .NET MVC presentation layer. These components communicate with each other using RabbitMQ, employing MediatR for command and handler functionality. The system is structured according to the Clean Architecture pattern and is divided into the following main components:

- Presentation Layer: Implemented using .NET MVC, facilitating user interaction with the system.
- Infrastructure Layer: Manages all external concerns, such as data communications, file systems, and external web services.
- Application Layer: Serves as the core of the system's operations, handling business logic and application-specific tasks.
- Domain Layer: Contains enterprise logic and types, defining the business objects of the project.
- Data Layer: Utilizes MS SQL Server to manage data persistence and retrieval.
## Purpose
The aim of this project is to demonstrate the practical application of microservices architecture in the banking sector using .NET Core, RabbitMQ, and MediatR. This setup ensures efficient communication and operation between different services, promoting scalability, maintainability, and modularity.
