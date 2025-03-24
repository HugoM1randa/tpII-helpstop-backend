# HelpApp
<h2>📚 Descrição Geral</h2>
<p> O HelpApp é um sistema para organizar atendimentos voluntários, focado em facilitar o realcionamento entre quem precisa de ajuda e quem está disponivel para ajudar. O projeto foi construído utilizando a plataforma .NET Core 6, com SQL Server e implantação na nuvem via Azure Server Apps. Toda a lógica foi projetada com base em princípios de desenvolvimento e manutenção facilitada, utilizando os conceitos do SOLID, Clean Architecture e Clean Code.</p>

<h2>🧪 Funcionalidades</h2>
<ol>
  <li>
    Cadastro de usuários (ajudante e solicitante).
  </li>
  <li>
    Registro e gerenciamento de atendimentos.
  </li>
  <li>
    Agenda personalizada.
  </li>
  <li>
    Histórico e relatórios de ações.
  </li>
  <li>
    Login seguro com autenticação e autorização.
  </li>
  <li>
    Gerenciamento de ONGs e seus respectivos atendimentos.
  </li>
  <li>
    Sistema de avaliação dos atendimentos.
  </li>
</ol>

<h2>🏗️ Arquitetura do Projeto</h2>
<ul>
  <li>
    <b>Domain:</b> Contém as entidades de negócio e interfaces de repositório.
  </li>
  <li>
    <b>Application:</b> Implementa os casos de uso e a lógica de negócio da aplicação.
  </li>
  <li>
    <b>Infrastructure:</b> Detalhes de implementação, como acesso a banco de dados e serviços externos.
  </li>
  <li>
    <b>API:</b> Camada de apresentação, responsável pela interação com o usuário (API RESTful).
  </li>
</ul>
![DiagramaSimplificado](https://github.com/user-attachments/assets/8ac11aaa-8c13-4a30-9771-24ab1ff6aeff)

<h2>⚙️ Princípios SOLID Aplicados</h2>

<ul>
  <li>
    <b>S -</b> Single Responsibility Principle: Cada classe possui uma única responsabilidade. Ex: UserService lida apenas com a lógica de usuários.
  </li>
  <li>
    <b>O -</b> Open/Closed Principle: O sistema é aberto para extensão, mas fechado para modificação. Ex: Interfaces como IUserRepository permitem novas implementações sem alterar o código existente.
  </li>
  <li>
    <b>L -</b> Liskov Substitution Principle: Subclasses podem substituir suas superclasses sem afetar o comportamento do sistema. Ex: Diferentes implementações de serviços de notificação podem ser utilizadas sem alterar a camada de aplicação.
  </li>
  <li>
    <b>I -</b> Interface Segregation Principle: Interfaces específicas são preferíveis a interfaces genéricas. Ex: Interfaces como IUserService, IAttendanceService, etc.
  </li>
  <li>
    <b>D -</b> Dependency Inversion Principle: Módulos de alto nível dependem de abstrações, não de implementações concretas. Ex: A camada de aplicação depende de interfaces, não diretamente do Entity Framework Core.
  </li>
</ul>

<h2>🧩 Tecnologias e Ferramentas</h2>
<ul>
  <li>
    <b>Linguagem:</b> C# (.NET 6)
  </li>
  <li>
    <b>Banco de Dados:</b> SQL Server
  </li>
  <li>
    <b>Ambiente:</b> Azure App Services
  </li>
  <li>
    <b>IDE:</b> Visual Studio / VS Code
  </li>
  <li>
    <b>ORM:</b> Entity Framework Core
  </li>
  <li>
    <b>Testes:</b> xUnit
  </li>
  <li>
    <b>Controle de Versão:</b> Git + GitHub
  </li>
  <li>
    <b>API:</b> ASP.NET Core Web API
  </li>
</ul>

<h2>🔧 Como Rodar o Projeto</h2>

<ol>
  <li>
    Clone o repositório.
  </li>
  <li>
    Abra a solução no Visual Studio.
  </li>
  <li>
    Configure a string de conexão no appsettings.json.
  </li>
  <li>
    Execute Update-Database no Package Manager Console para aplicar as migrations.
  </li>
  <li>
    Execute a aplicação (F5 ou dotnet run).
  </li>
  <li>
    Acesse a documentação Swagger em /swagger para testar as rotas da API.
  </li>
</ol>

<h2>🧪 Testes Automatizados</h2>

<ul>
  <li>
    Testes unitários cobrem a camada de Application e regras de negócio críticas.
  </li>
  <li>
    xUnit é utilizado para os testes.
  </li>
  <li>
    A cobertura de código prioriza a lógica de negócio e casos de uso principais.
  </li>
  <li>
    Os testes podem ser executados através do Visual Studio ou usando o comando dotnet test na CLI.
  </li>
</ul>

<h2>📂 Estrutura de Pastas</h2>
<p>
  HelpStop/
├── Domain/
│   ├── Entities/
│   └── Interfaces/
├── Application/
│   ├── UseCases/
│   └── Services/
├── Infrastructure/
│   ├── Data/
│   ├── Repositories/
│   └── Services/
├── API/
│   ├── Controllers/
│   └── Program.cs
├── Tests/
└── HelpStop.sln
</p>

<h2>👨‍💻 Autores</h2>
<p>Hugo Miranda - ??????? - [HugoM1randa](https://github.com/HugoM1randa)</p>

<h2>📜 Licença</h2>
<p>Este projeto está sob a licença MIT.</p>
