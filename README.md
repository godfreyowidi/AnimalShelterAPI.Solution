
## Table of Contents
* ##### About the Project
  - ###### Description
  - ###### Known Bugs
  - ###### Built With
* ##### Getting Started
  - ###### Prerequisites
  - ###### Setup and Use
* ##### API Documentation
* ##### Auxiliary
  - ###### Contributors
  - ###### Contact
  - ###### License
  - ###### Acknowledgements

<hr />
<br />

🌐 About the Project

📖 Description


🦠 Known Bugs
* No known bug.

🛠 Built With
* Visual Studio Code
* C#
* ASP.NET Core MVC
* MySQL 8.0.20
* Entity Framework Core 2.2.6
* Jwt Authentication
* Postman

🏁 Getting Started

📋 Prerequisites
#### Install .NET Core
* On macOS Mojave or later
  - Click here to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  - Click here to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
Enter the command dotnet tool install -g dotnet-script in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
Download and install the appropriate version of MySQL Workbench.

#### Install Postman
(Optional) Download and install Postman.

#### Code Editor
To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:
  * Option 1: Atom
  * Option 2: VisualStudio Code
2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a GitHub Account

⚙️ Setup and Use

#### Cloning
1. Navigate to the AnimalShelter API repository here.
2. Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
3. Open up your system Terminal or GitBash, navigate to your desktop with the command: cd Desktop, or whichever location suits you best.
4. Clone the repository to your desktop: $ git clone https://github.com/godfreyowidi/AnimalShelterAPI.Solution
5. Run the command cd AnimalShelterAPI.Solution to enter into the project directory.
6. View or Edit:
  - Code Editor - Run the command atom . or code . to open the project in Atom or VisualStudio Code respectively for review and editing.
  - Text Editor - Open by double clicking on any of the files to open in a text editor.

#### Download
1. Navigate to the AnimalShelter API repository here.
2. Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
3. Click 'Download ZIP' and unextract.
4. Open by double clicking on any of the files to open in a text editor.

#### AppSettings
1. Create a new file in the AnimalShelterAPI.Solution/OrphanagePark directory named appsettings.json
2. Add in the following code snippet to the new appsettings.json file:

```{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YourPassword];"
  }
}
```

3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).
#### Database
1. Navigate to AnimalShelterAPI.Solution/OrphanagePark directory using the MacOS Terminal or Windows Powershell (e.g. cd Desktop/AnimalShelterAPI.Solution/OrphanagePark).
2. Run the command dotnet ef database update to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command dotnet ef migrations add <MigrationsName> which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command dotnet ef database update to update the database.

#### Launch the API
1. Navigate to AnimalShelterAPI.Solution/OrphanagePark directory using the MacOS Terminal or Windows Powershell (e.g. cd Desktop/AnimalShelterAPI.Solution/OrphanagePark).
2. Run the command dotnet run to have access to the API in Postman or browser.

🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

#### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.

* Open Postman and create a POST request using the URL: http://localhost:5000/api/authmanagement/register
* Add the following query to the request as raw data in the Body tab:
```
{
    "username": "[YourEmailAddress]",
    "email": "[YourEmailAddress]"
    "Password": "[YourPassword]"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab.

#### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS. For more information or to see how CORS functions, see the Microsoft documentation.

To modify this, use the query parameters limit and start to alter the response results displayed. The limit parameter will specify how many results will be displayed, and the start parameter will specify which element in the response the limit should start counting.

🤝 Contributors
Author	GitHub	Email
Godfrey	Owidi	godfreyowiidi@gmail.com

✉️ Contact and Support
If you have any feedback or concerns, please contact the author.

Report Bug · Request Feature

⚖️ License
This project is licensed under the MIT License. Copyright (C) 2021 Godfrey Owidi. All Rights Reserved.

MIT License

Copyright (c) 2021 Shawn Lunsford.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
🌟 Acknowledgments
Epicodus
"A school for tech careers... to help people learn the skills they need to get great jobs."