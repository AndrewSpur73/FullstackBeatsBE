<h1 align="center" style="font-weight: bold;">Project name 💻</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
 <a href="#colab">Collaborators</a> •
</p>

<p align="center">
    <b>FullstackBeatsBE provides endpoints for managing users, shows, and show categories. This collection allows users to retrieve, create, update, and delete users, shows, and show categories. It is designed to facilitate interactions with users, their RSVP'd shows, and the categories of the shows in an organized and user-friendly way.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- C#
- .NET
- AutoMapper
- SQL
- EFcore
- Postman/Swagger - testing/documentation

<h2 id="started">🚀 Getting started</h2>

1.) Clone a repository option in Visual Studio 2.) Enter or type the repository location, and then select the Clone button 3.) To start building the program, press the green Start button on the Visual Studio toolbar, or press F5 or Ctrl+F5. Using the Start button or F5 runs the program under the debugger.

<h3>Prerequisites</h3>

Here you list all prerequisites necessary for running your project. For example:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
 
<h4>Packages</h4>

- dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0
- dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
- dotnet add package AutoMapper 

<h3>Postman Documentation</h3>

- [API Documentation](https://www.postman.com/fullstackbeats/fullstackbeats-workspace/documentation/ro8wu2l/fullstack-beats)

<h3>Cloning</h3>

How to clone your project

```bash
git clone git@github.com:AndrewSpur73/FullstackBeatsBE.git
```

<h3>Starting</h3>

```bash
cd FullstackBeatsBE
dotnet watch run
```

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /authenticate</kbd>     | retrieves user info see [response details](#get-auth-detail)
| <kbd>POST /authenticate</kbd>     | authenticate user into the api see [request details](#post-auth-detail)

<h3 id="get-auth-detail">GET /authenticate</h3>

**RESPONSE**
```json
{
  "name": "Fernanda Kipper",
  "age": 20,
  "email": "her-email@gmail.com"
}
```

<h3 id="post-auth-detail">POST /authenticate</h3>

**REQUEST**
```json
{
  "username": "fernandakipper",
  "password": "4444444"
}
```

**RESPONSE**
```json
{
  "token": "OwoMRHsaQwyAgVoc3OXmL1JhMVUYXGGBbCTK0GBgiYitwQwjf0gVoBmkbuyy0pSi"
}
```

<h2 id="colab">🤝 Collaborators</h2>

Special thank you for all people that contributed for this project.

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/153697028?v=4" width="100px;" alt="Andrew Spurlock Profile Picture"/><br>
        <sub>
          <b>Andrew Spurlock</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://ca.slack-edge.com/T03F2SDTJ-U068W2CL50D-cb7395f6591b-512" width="100px;" alt="Derek Swann Profile Picture"/><br>
        <sub>
          <b>Derek Swann</b>
        </sub>
      </a>
    </td>
  </tr>
</table>
