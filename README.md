<h5 align="center">
  <img src="https://miro.medium.com/max/976/1*f6XaetSL3yvsvKxp55sKsQ.png" width="250px" />
  &nbsp;&nbsp;&nbsp; 
  <img src="https://i0.wp.com/jasontaylor.dev/wp-content/uploads/2020/01/Figure-01-2.png?resize=531%2C531&ssl=1" height="160px" />
  <br>  
  <br>  
  <b>Creating and managing freelance projects</b> 📒
</h5>
<p align="center">
  <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
  <img alt="CI Badge" src="https://github.com/pferreirafabricio/dev-freelas/actions/workflows/dotnet.yml/badge.svg">
</p>

## :open_book: About 
This project is a a simple RESTful API for...

## :rosette: API Routes
```
GET - players/
GET - players/{nick}
POST - players/
PUT - players/

GET - history/{nick}
PUT - history/
```

## :bricks: This project was built with: 
- [C#](https://www.php.net/)
- [.NET Core 5](https://github.com/robsonvleite/router)
- [MediatR]()
- [MySQL](https://www.mysql.com/)
- [Entity Framework Core]()
- [xUnit]()
- [Fluent Validation]()

## 🏄‍♂️ Quick Start
 1. Clone this repository `git clone https://github.com/pferreirafabricio/dev-freelas.git`;
 2. Enter in the project's folder: `cd dev-freelas`
 3. Install dependencies: `dotnet restore`
 > OBS: Before the next step install the dotnet-ef tool globally first with `dotnet tool install --global dotnet-ef command`
 4. Run migrations: `dotnet ef database update -s ..\DevFreela.API\DevFreela.API.csproj`
 5. Enter the API project's folder: `cd ./DevFreela.API`
 6. Run the API and be happy: `dotnet watch run` 😃
 
## :recycle: Contribute
 1. Fork this repository;
 2. Create a branch with your feature: ```git checkout -b my-feature```
 3. Commit your changes: ```git commit -m 'feat: My new feature'```
 4. Push your branch: ```git push origin my-feature```
 
## :page_with_curl:	License
This project is under the MIT license. Take a look at the [LICENSE](LICENSE.md) file for more details.

## 📚 Learn more

  * Guides: https://super.guide.com
