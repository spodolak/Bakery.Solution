# _Bakery Administration Page_

#### By _**Steph Podolak**_


## Description

_An MVC web application to to catalog and manage a Bakery's inventory._

## Program User Stories

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Store Manager can create, read, edit and update a bakery treat| Manager inputs new treat| Item details can be displayed with the option to edit and update details|
| Store Manager can create, read, edit and update a flavor category to help organize treats| Manager inputs new flavor | Flavor details can ve displayed with the option to edit and update flavor |
| Manager can navigate to splash page to view list of all treats and flavors | User clicks individual treat or flavor | All treats and flavors belonging to selected item are displayed |
| Website authenticates store manager prior to manipulating bakery inventory| Manager logs in | Manager can create, update and delete inventory |


## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/spodolak/Bakery.Solution
cd Bakery.Solution
```
### 3. Install all necessary packages and make sure the project will build
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd Bakery
dotnet restore
dotnet build
```

### 4. Create the database and tables
Enter the following to build your database and tables for the program:
```sh
dotnet ef database update
```

### 5. Launch the project in your browser
In your terminal, type:
```sh
dotnet watch run
```
Then hold ```command``` while clicking the link in your local terminal to your local address, which should be:
```sh
http://127.0.0.1:5000
```

Eureka! The project is now ready to use.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/spodolak/Bakery.solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL_
* _EF Core 2.2.6_
* _ASP.NET Core Identity_
* _Razor 2.2.0_
* _Material Design Lite_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K Wicz_**
