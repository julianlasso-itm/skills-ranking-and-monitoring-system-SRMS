# Skills Ranking and Monitoring System - SRMS

## What is the project about

Management and assessment of technical competencies in software development teams by team leaders, based on expert judgment, to track the technical skills and experience level of software developers, through the implementation of an open-source web application.

## Short description of the project

The "Skills Ranking and Monitoring System (SRMS)" is an advanced solution aimed at the evaluation and management of technical competencies in software development teams. As an open-source web platform, SRMS enables team leaders to conduct precise assessments of the technical knowledge and experience of each developer, using an approach based on expert judgment. This tool allows for the efficient administration of developer profiles and client accounts, including the ability to register, update, and maintain a complete history of technical evaluations, which is essential for talent management within the organization.

## How to run the backend 

 ✔ This project requires docker o podman to run the database and redis.

To Execute the Database, locate the root of the project and execute:
```bash
docker compose up -d
```

To configure the database, follow these steps:

1. Open Visual Studio.
2. Navigate to the Backend folder located at the root of the project, inside the src folder.
3. Open the Package Manager Console.
4. Run the following command in the Package Manager Console:

```bash
update-database 
```

In Solution Explorer, locate the following projects:

 - AccessControl.Infrastructure
 - Profiles.Infrastructure
 - ApiGateway.Infrastructure
 - Analytics.Infrastructure

1. Right-click the solution in Solution Explorer and select "Properties" from the context menu.
2. In the left pane of the Solution Properties window, select Startup Projects.
3. Select "Multiple startup projects."
4. Set up the projects as follows:
   
   * AccessControl.Infrastructure: Start
   * Profiles.Infrastructure: Start
   * ApiGateway.Infrastructure: Start
   * Analytics.Infrastructure: Start
   * Click "OK" to save the settings.
     
5.Then start the solution

## How to run the frontend project

  ✔ This project requires node v18 or higher.

To run the frontend project you must install the necessary dependencies with the following command:
```bash
npm install
```

Then execute the start command:
```bash
npm start
```
And Enjoy!
