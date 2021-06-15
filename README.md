<h1 align="center">
📞 Parks Api 💻 </h1>

<hr style="height: 1px; border:none; color:#333; background" />

### By Isaac Moreno 👨‍💻

Click [here](https://github.com/isaacrmoreno/StateParksApi.Solution) to view project.

# Description 📝

Web app to practice building backend Api with full CRUD functionality via ASP.NET Core.

# Prerequisites 🖥️

- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
- [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VScode](https://code.visualstudio.com/) | [Atom](https://atom.io/) | [Sublime](https://www.sublimetext.com/)
- API Testing Software like [PostMan](https://www.postman.com/downloads/) | [Insomnia](https://insomnia.rest/download)
- A command line interface like Terminal or Gitbash to run and interact with the console app.

# Setup/Installation Requirements 📁

## Application Setup:

1. Clone this repository: `% git clone https://github.com/isaacrmoreno/ParksApi.Solution`
2. Navigate to the ParksApi.Solution directory on your computer
3. Open with your preferred text editor to view code
4. Within your Command line run `cd ParksApi`, touch `appsettings.json`.
5. Add the following block of code to your .json file

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
  }
}
```

- Note: Make sure that [YOUR DATABASE] and [YOUR PASSWORD] match the database name and password of your local MySql server.

## To Run Application:

1. To run console app:
   - Navigate to the `ParksApi.Solution/ParksApi` directory and run the following commands:
     - `dotnet restore` to restore the dependencies that are listed in `ParksApi.csproj`
     - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
     - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
     - `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
     - `dotnet build` to build the project and its dependencies into a set of binaries
     - `dotnet tool install --global dotnet-ef` to install EF Core tools
     - `dotnet ef migrations add Initial` and `dotnet ef database update`
   - Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - View project via web browser: `localhost:5000/`
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app

## API Endpoint Testing

Download [PostMan](https://www.postman.com/downloads/) or [Insomnia](https://insomnia.rest/download) to begin API endpoint testing.

Sample url/dummy data has been provided below for ease, but feel free to explore.

- Within your API software of choice please enter the following urls with its corresponding GET/POST/PUT/DELETE Method.

GET (To display seeded sample parks)

```
http://localhost:5000/api/parks/
```

POST (To add additional park to API database)

In order to post you will use the same url...

```
http://localhost:5000/api/parks/
```

AND you will need to add the following text to the "body" tab within your API Software

```
  {
        "parkId": 4,
        "parkName": "Smith Rock State Park", "parkDescription": "If you enjoy scenic views of deep river canyons or rock climbing, Smith Rock State Park is the place for you. There are several thousand climbs in the park. More than a thousand are bolted routes. We also offer miles of hiking and mountain biking trails. Along your trip through the canyon, you might see golden eagles, prairie falcons, mule deer, river otter and beaver. Note: Some climbing areas are closed or have limited access from about Jan. 15 to Aug. 1 to protect nesting raptors. Drones are also not allowed during this period. Check the park advisories on this page for exact dates and affected areas. Due to the uniqueness and fragile aspect of the park, park rangers enforce the animal leash law and ask all park users to stay on trails.",
        "amenitiesFacilities": "Camping",
        "region": "Central Oregon"
    }
```

From here, if you send another GET request, you should now be able to see the park you just added.

PUT (To edit park description)
You will now need to add "4" to the end of the url so we know to only target that park id when making our PUT Request.

```
http://localhost:5000/api/parks/4
```

After updating the url, please replace the current body text with the following.

```
{
        "parkId": 4,
        "parkName": "Smith Rock State Park", "parkDescription": "This is a fake park description to showcase PUT Functionality",
        "amenitiesFacilities": "Camping",
        "region": "Central Oregon"
}
```

If you submit another GET request with the above url, you will now see that the park description has been updated!

DELETE (To Delete forth park from database)

Similar to a PUT request, we will have to ensure we are targeting the appropriate id by adding "4" to the url.

```
http://localhost:5000/api/parks/4
```

After doing so, you can simple "send" the request and it should delete that entry. You can double check you did this correctly by removing the id number and submitting another GET request to view all parks, and just like that you have full CRUD functionality! Congrats! 🥳

## Swagger

If you would like to test the endpoints with [Swagger](https://swagger.io/solutions/api-documentation/) instead, please update the following:

Url browser: `http://localhost:5000/`

launchSettings.json:

```
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:4324",
      "sslPort": 44328
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "ParkApi": {
      "commandName": "Project",
      "dotnetRunMessages": "true",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}

```

<hr style="height: 1px; border:none; color:#333;" />

# Bugs 🐛

No known issues

# Technologies Used 💾

<div align="center">
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" height="45" style="vertical-align:top; margin:4px" />
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg" alt="dotnet" height="45" style="vertical-align:top; margin:4px"/>
<img alt="postman" src="https://www.vectorlogo.zone/logos/getpostman/getpostman-icon.svg" height="45" style="vertical-align:top; margin:4px"/>
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/visual-studio-code/visual-studio-code.png" alt="visual-studio-code" height="45" style="vertical-align:top; margin:4px">
<img src="https://raw.githubusercontent.com/isaacrmoreno/devicon/master/icons/git/git-original.svg" alt="git" height="45" style="vertical-align:top; margin:4px">
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/terminal/terminal.png" alt="Terminal" height="45" style="vertical-align:top; margin:4px">
</div>

# Contact ✉️

[GitHub](https://github.com/isaacrmoreno) | [Email](mailto:ipdxcreative@gmail.com)

<hr style="height: 1px; border:none; color:#333;" />

# Copyright and License ⚖️

[MIT License](license) &copy; 2021 Isaac Moreno
