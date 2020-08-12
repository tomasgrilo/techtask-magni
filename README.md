# Tech Task: [MagniFinance](https://magnifinance.com/)

Created by me ([@tomasgrilo](https://github.com/tomasgrilo))

Tech task which consist on building a college application to maintain courses, students, professors, etc

Built in ASP.NET MVC, SQL Server, EntityFramework, AngularJS

#### Technologies

- [ASP.NET MVC 5](https://dotnet.microsoft.com/apps/aspnet/mvc) - Microsoft Pattern
- [AngularJS](https://angularjs.org/) - Web Framework
- [EntityFramework](https://docs.microsoft.com/en-us/ef/) - Framework
- [BootStrap](https://getbootstrap.com/)

#### Considerations

- The EntityFramework will set up the Local Database for you, was built with Code-First.
- The project does not include any testing framework.
- The color palette was chosen based on MagniFinance's web page.


### Folder Structure

- `angularControllers` - [AngularJS](https://angularjs.org/) Controllers
- `Content` - CSS and [BootStrap](https://getbootstrap.com/) .
- `Data` - Data Access Layer folder.
- `Migrations` - EF CodeFirst migrations

### Notes (in portuguese)

#### Trabalho efetuado:
- Instalação do Visual Studio e dos componentes necessários (EF, angularJS, etc). ~1,5h
- Modelo de dados, entidades e adaptação para EF code first. ~4/5h
- Server-side (backend) development ~4h
- Front-end ~10h

#### TODOs:
- Colocar news no modelo de dados, de forma a ser apresentado na página inicial em vez de tar hardcoded.
- Cloak na página de forma a carregar os dados antes de aparecer modelos de angular vazios (atenção que este podem demorar algum tempo a carregar a primeira vez que abrimos a página/criamos a BD).
- Validações de CRUD server-side no modelo de dados, após generic BaseController.
- Tornar blocos de código nas páginas de Index em componentes, de forma a não repetir código de tabelas etc.
- Adaptar projeto ao SignalR.
- Mapear propriedades no JsonResult.
- Para resolver o JSON date problem:https://stackoverflow.com/questions/206384/how-do-i-format-a-microsoft-json-date, criar um controlador angular utils para gerir estas dates (foi resolvido diretamente no controlador).
- Páginas para gestão de professores, estudantes e notas.
- Erro cascade delete quando apagamos os Subjects que dependem das Grades, devia apagar as Grades automaticamente (resolvido fazendo override dos Delete/update) - Resolvido com override nos metodos dando a referência do objeto correto ao EF.
- Algumas validações front-end anti SQL Injection, expressões regulares em ng-pattern, etc.


## Authors

- **Tomás Grilo** - [@tomasgrilo](https://github.com/tomasgrilo)
