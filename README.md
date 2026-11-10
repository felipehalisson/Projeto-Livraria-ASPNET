# Projeto Livraria ASP.NET Core MVC

Sistema de livraria com login, Home personalizada e cadastro de livros.

## Tecnologias

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core com Pomelo (MySQL)
- MySQL Workbench

## Como rodar

1. Execute o arquivo `script.txt` no MySQL Workbench para criar o banco `dblivraria`.
2. Configure a string de conexão `ConexaoMySQL` no `appsettings.json` com a sua senha do MySQL.
3. Abra a solução `ProjetoLivraria.slnx` no Visual Studio.
4. Pressione F5 para executar.

## Acesso

- Login: `/Conta/Login`
- Home: `/Home/Index`
- Cadastro de livros: `/Livro/Create`