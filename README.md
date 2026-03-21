🎓 EduCore: Educational Process Simulation System
EduCore is a robust backend simulation of a modern E-Learning environment. The project is designed with a strong focus on Software Engineering best practices, specifically leveraging Object-Oriented Programming (OOP) and SOLID Principles to ensure high maintainability and decoupled logic.

🏗️ Architectural Highlights (The SOLID Way)
Single Responsibility: Each service (Course, Assessment, User) handles a dedicated part of the domain logic.

Repository Pattern: Decoupling data access from business logic using IRepository and concrete implementations like UserRepository.

Interface Segregation: Ensuring that students, instructors, and admins interact only with the methods relevant to their roles.

Dependency Inversion: High-level modules don't depend on low-level modules; both depend on abstractions.

🚀 Key Features
Role-Based Management: Specialized entities for Student, Instructor, and User.

Course & Content Lifecycle: Full simulation of creating courses, materials, and questions.

Assessment Engine: Automated handling of exams and assessment services.

Educational Workflow: Simulates the real-world interaction between instructors, educational materials, and student evaluations.

🛠️ Tech Stack
Language: C#

Framework: .NET Core

Design Patterns: Repository Pattern, Dependency Injection.

Core Concepts: Abstraction, Encapsulation, Polymorphism, and SOLID.
