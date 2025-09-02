# 💰 CashFlow - Sistema de Gestão Financeira

## 📋 Descrição

O **CashFlow** é um projeto de sistema de gestão financeira desenvolvido em .NET 8, que implementa as melhores práticas de desenvolvimento de software, incluindo **DDD (Domain Driven Design)**, **SOLID**, **Injeção de Dependência** e **Entity Framework**.

Este projeto foi criado como parte de um curso completo de desenvolvimento avançado em .NET, focando em código limpo, seguro e orientado ao domínio.

## 🚀 Funcionalidades Principais

- **Gestão Financeira**: Controle completo de receitas e despesas
- **API REST**: Interface moderna e escalável
- **Validações Avançadas**: Implementação de Fluent Validation
- **Testes Unitários**: Cobertura completa de testes
- **Relatórios**: Geração de relatórios em Excel e PDF
- **Versionamento**: Controle de versão com GitHub

## 🏗️ Arquitetura

O projeto segue os princípios de **Domain Driven Design (DDD)** e **SOLID**, implementando:

- **Clean Architecture**: Separação clara de responsabilidades
- **Dependency Injection**: Injeção de dependências para baixo acoplamento
- **Repository Pattern**: Padrão de acesso a dados
- **Unit of Work**: Controle transacional
- **Exception Handling**: Tratamento robusto de erros

## 🛠️ Tecnologias Utilizadas

- **.NET 8**: Framework de desenvolvimento
- **Entity Framework Core**: ORM para acesso a dados
- **MySQL**: Banco de dados relacional
- **Fluent Validation**: Validações elegantes e expressivas
- **AutoMapper**: Mapeamento de objetos
- **xUnit**: Framework de testes unitários
- **Swagger**: Documentação da API


## 🚀 Como Executar

### Pré-requisitos
- .NET 8 SDK
- MySQL Server
- Visual Studio 2022 ou VS Code

### Instalação
```bash
# Clone o repositório
git clone https://github.com/seu-usuario/CashFlow.git

# Entre no diretório
cd CashFlow

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run
```

### Configuração do Banco de Dados
1. Configure a string de conexão no `appsettings.json`
2. Execute as migrações do Entity Framework
3. Configure o banco de dados MySQL

## 🧪 Executando os Testes

```bash
# Execute todos os testes
dotnet test

# Execute com cobertura
dotnet test --collect:"XPlat Code Coverage"
```

## 📖 Documentação da API

A documentação da API está disponível através do Swagger UI quando o projeto estiver em execução:
- **URL**: `https://localhost:5001/swagger`
- **Endpoint**: `/swagger/v1/swagger.json`

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
