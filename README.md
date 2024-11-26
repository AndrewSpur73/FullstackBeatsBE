<h1 align="center" style="font-weight: bold;">Fullstack Beats 💻</h1>

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
- PgAdmin
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

- [API Documentation](https://documenter.getpostman.com/view/32010448/2sAY4rDj6S)

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
| user          | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET Login</kbd> |	Retrieves login information
| <kbd>POST Register</kbd> |	Registers a new user
| <kbd>GET User by Id</kbd> |	Retrieves a user by their id
| <kbd>GET User by UID</kbd> |	Retrieves a user by their unique UID
|<kbd>PATCH Update user</kbd> |	Updates a user's information
| <kbd>DELETE Delete user</kbd> |	Deletes a user account

| category          | description                                          
|----------------------|-----------------------------------------------------
|<kbd>GET Categories</kbd> |	Retrieves all categories
|<kbd>POST Create category</kbd> |	Creates a new category
|<kbd>PATCH Update category</kbd> |	Updates an existing category
|<kbd>DELETE Delete category</kbd> |	Deletes a category

| shows           | description                                          
|----------------------|-----------------------------------------------------
|<kbd>GET All shows</kbd> |	Retrieves all shows
|<kbd>POST Create show</kbd> |	Creates a new show
|<kbd>GET User shows</kbd>	| Retrieves shows associated with a user
|<kbd>GET Single show</kbd> |	Retrieves a single show's data
|<kbd>PUT Edit show</kbd> |	Edits an existing show
|<kbd>DELETE Delete show</kbd> |	Deletes a show
|<kbd>POST Create show RSVP</kbd> |	Creates an RSVP for a show

For more in-depth information about the calls, view the documentation in the Postman here:

- [API Documentation](https://documenter.getpostman.com/view/32010448/2sAY4rDj6S)

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
