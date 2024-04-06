# BlazorDemo
ATTENTION: This is the older version of the project, I have fixed the project structure, added an API, and will continue to work on the WASM portion of the demo [HERE!](https://github.com/YB-BigSwan/BlazorShop)

This is a Blazor Web Server e-commerce application I am working on to learn Blazor/.NET! It's pretty basic at the moment, but I plan on finishing and polishing up the Web Server admin panel, then creating a Blazor WASM storefront. It is not currently hosted anywhere, so if you want to check it out, follow the installation instructions below.

## Table of Contents
- [Getting Started](#getting-started)
- [Experience and Challenges](#experience-and-challenges)

## Getting Started

### Prerequisites:
>- [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed on your machine.
>- VisualStudio or Rider(Recommended)
>- [SyncFusion Community License](https://www.syncfusion.com/products/communitylicense)
>- [Docker Desktop](https://docs.docker.com/desktop/)
>- Node Package Manager (NPM)
>- SQL CLI

### Installation:

1. Clone this repository to your local machine:
>>```bash
>>git clone https://github.com/YB-BigSwan/BlazorDemo
>>```

2. Create a local database running in Docker. Be sure the container is running and preferably test the connection on DBMS to ensure it is working:
>Ensure you have the latest version of SQLServer
>>```bash
>>sudo docker pull mcr.microsoft.com/mssql/server:2022-latest
>>```
>Create DB container
>>```bash
>>docker run -d --name SQL_Server_Docker -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=DB_Password_Goes_Here' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest 
>>```
>Login to MySQL
>>```bash
>>mssql -u sa -p DB_Password_Goes_Here
>>```
>Create DB
>>```bash
>>CREATE DATABASE database_name;
>>```

3. DB Connection and migration:
>Configure DB connection string and Syncfusion key in appsettings.json
>>```bash
>>"ConnectionStrings": {
>>  "DefaultConnection": "Connection_Settings_Go_Here",
>>  "SyncFusionConnection": "Key_Goes_Here"
>>}
>>```

4. Open the project and navigate to the project directory:
>>```bash
>>cd BlazorDemo
>>```

5. Migrate data models to DB:
>Create Migration
>>```bash
>>dotnet ef migrations add <MigrationName>
>>```
>"Push" migration to DB
>>```bash
>>dotnet ef database update
>>```

6. Running the Application:
>Make sure dependencies are installed
>>```bash
>>dotnet restore
>>```
>>```bash
>>npm i
>>```
>Run
>>```bash
>>dotnet watch
>>```

7. Create your own Categories, Products, and ProductPrices using the admin panels - Categories and Products


## Experience and Challenges

### Things I Liked
>- EF Core Migrations make managing database changes a breeze.
>- Coming from a background in React, I appreciate Blazor's approach to data binding.
>- Blazor Components are convenient to work with as you can separate concerns into small, reusable blocks.
>- Having studied Java, I find C# and the .NET ecosystem refreshing as there is a lot less boilerplate to read through.
>- The way Blazor handles routing makes setting up navigation smooth and straightforward.
>- Razor component templating is much nicer than Thymeleaf templating.

### Challenges Faced
>- Transitioning to a new language, framework, and environment to some getting used to and there are definitely some "growing pains".
>- Figuring out how NuGet and EFCore migrations work in Rider took me a little while, but now that I get it, it might as well be npm.
>- Dealing with minor errors can be a bit of a headache at times as Blazor's debugging tools and error messages are not always (in my limited experience) straightforward.

### Overcoming Challenges
>- Utilizing lots of breakpoints and the debugging tool got me through most of the small errors.
>- For the real "head-scratchers" I was lucky enough to find some detailed stack-overflow posts that helped me understand what my mistakes were and how I could fix them.
>- Taking the time to read the documentation provided clarity on certain concepts that were unclear. Especially, for example, small changes in syntax between .NET 6/7 => 8.
>- Carefully reading the error messages was also helpful to help solve some of my more obvious mistakes.
