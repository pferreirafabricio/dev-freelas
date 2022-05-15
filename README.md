<h5 align="center">
  <img src="https://styles.redditmedia.com/t5_2qhdf/styles/communityIcon_sk8k2hisvyv51.png" height="80px" />
  &nbsp;&nbsp;&nbsp; 
  <img src="https://sabresistemas.com.br/wp-content/uploads/2021/03/sabre-sistemas-erp-software-tecnologia-microsoft-net-core.png" width="250px" />
  <br>  
  <br>  
  <b>Creating and managing freelance projects</b> 📒
</h5>
<p align="center">
  <img alt="License" src="https://img.shields.io/badge/license-MIT-purple">
  <img alt="CI Badge" src="https://github.com/pferreirafabricio/dev-freelas/actions/workflows/dotnet.yml/badge.svg">
</p>

## :open_book: About 
This project is a simple RESTful API for control freelance projects. Made for studies purposes, this API uses Clean Architecture, MediatR, Dependency Injection, Unit Testing, Authentication, Authorization and so many more concepts.

## :bricks: This project was built with: 
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- [MediatR](https://github.com/jbogard/MediatR)
- [MySQL](https://www.mysql.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [xUnit](https://xunit.net/)
- [Fluent Validation](https://fluentvalidation.net/)
- [Swagger](https://swagger.io/)

## 🏄‍♂️ Quick Start
 1. Clone this repository `git clone https://github.com/pferreirafabricio/dev-freelas.git`;
 2. Enter in the project's folder: `cd dev-freelas`
 3. Install dependencies: `dotnet restore`
 > OBS: Before the next step ensure that dotnet-ef tool is installed globally with `dotnet ef --version`, if not install with: `dotnet tool install --global dotnet-ef command`
 4. Run migrations: `dotnet ef database update -s ../DevFreela.API/DevFreela.API.csproj`
 5. Enter the API project's folder: `cd ./DevFreela.API`
 6. Run the API and be happy: `dotnet watch run` 😃
 
## :recycle: Contribute
 1. Fork this repository;
 2. Create a branch with your feature: ```git checkout -b my-feature```
 3. Commit your changes: ```git commit -m 'feat: My new feature'```
 4. Push your branch: ```git push origin my-feature```
 
## :page_with_curl:	License
This project is under the MIT license. Take a look at the [LICENSE](LICENSE) file for more details.

## 📚 Learn more

  * [Luis Dev blog](https://www.luisdev.com.br/)
  * [Método .NET Direto ao ponto](https://lp.luisdev.com.br/lista-de-espera-metodo-net-direto-ao-ponto)
  * [Learn .NET](https://dotnet.microsoft.com/en-us/learn)
  * [Quick introduction to clean architecture](https://www.freecodecamp.org/news/a-quick-introduction-to-clean-architecture-990c014448d2/)
