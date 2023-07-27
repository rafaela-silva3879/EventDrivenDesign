# API em .NET 7 com Entity Framework Code First, Mensageria com RabbitMQ, DDD, TDD e Arquitetura de Eventos
## Descrição
Esta API foi desenvolvida em .NET 7 e utiliza o padrão de arquitetura DDD (Domain-Driven Design), TDD (Test-Driven Development) e a arquitetura de eventos para garantir um código limpo, organizado e escalável.

A API também utiliza o Entity Framework Code First para o gerenciamento de banco de dados e o RabbitMQ como serviço de mensageria.
## Requisitos
- .NET SDK 7.0 ou superior
- RabbitMQ instalado e configurado
- SQL Server instalado e configurado
- Visual Studio 2022

## Como executar
1. Clone o repositório
2. Abra a solução `ApiPedidos.sln` no Visual Studio
3- NO SQL Server Management Studio, crie um banco de dados
    3.1- Clique em menu View / Serve explorer / Connect to database
	3.2- Em "Server name", escreva o nome do servidor de banco. Ex.: localhost
	3.3- Em "Select or enter a database name", escreva o nome do banco criado. Clique em "Test Connection" e ok.
4- Em server explorer, dê um click da direita no nome do banco, vá em propriedades e copie a connectionstring. 
5. No arquivo `appsettings.json`, em Connectionstring, cole a string de conexão e configure o servidor do RabbitMQ
6. Dê um click da direita no projeto Infra.Data e clique em "Set as startup Project". 
7- Abra o Package Manager Console em default Project, escolha o projeto Infra-Data e execute o comando Add-Migration e depois Update-Database para criar as tabelas no banco de dados
8- Clique da direita no projeto Services, "Set as startup project"
9. Execute a aplicação