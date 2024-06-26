# Gerenciamento de Matrículas - API

O Gerenciamento de Matrículas é uma API que suporta as operações de um aplicativo mobile voltado para gestão escolar. Ela permite que o cliente gestor acompanhe o andamento das novas matrículas realizadas na escola instantaneamente, além de possibilitar operações como adicionar, atualizar, excluir, filtrar por aluno e visualizar a lista de alunos.

## Funcionalidades Principais

- Adicionar novas matrículas
- Atualizar informações de matrículas
- Excluir matrículas
- Filtrar matrículas por aluno
- Visualizar a lista completa de alunos
- Simula um processo de matrícula real, atualizadando a lista de allunos periodicamente mediante configuração de tempo do projeto através da execução de um hosted service.

## Tecnologias Utilizadas

- .NET 5
- Dapper
- SQL Server
- Hosted Server

## Instalação e Execução

Siga estas etapas para configurar e executar a API localmente:

### Pré-requisitos

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Git](https://git-scm.com/)
- Um banco de dados SQL Server

### Clonando o repositório

1. Clone o repositório:

```bash
git clone https://github.com/Luiz-F-L-P-JR/Gerenciamento.Matricula.API.git
```

### Configuração

1. Navegue até o diretório do projeto:

```bash
cd Gerenciamento.Matricula.API
```

2. Abra o arquivo `appsettings.json` e atualize as configurações conforme necessário, especialmente as configurações relacionadas ao banco de dados para conexão com o SQL Server.

### Executando o projeto

1. Execute a aplicação VS Code:

```bash
dotnet run 
```

2. Execute a aplicação Visual Studio:

```bash
Aperte F5 ou clique no botão para a execução na barra de configuração. 
```

3. O projeto estará acessível nas rotas indicadas no arquivo `launchSettings.json`, utilize `http://localhost:` e a número da porta.

## Contribuindo

Contribuições são bem-vindas! Se deseja contribuir com este projeto, siga estas etapas:

1. Faça um fork do projeto
2. Crie uma branch com a sua feature (`git checkout -b feature/MinhaFeature`)
3. Faça commit das suas alterações (`git commit -am 'Adicionando nova feature'`)
4. Faça push para a branch (`git push origin feature/MinhaFeature`)
5. Abra um Pull Request

## Contato

Para mais informações, entrem em contato com Luizfernandojr1998@gmail.com.

---
