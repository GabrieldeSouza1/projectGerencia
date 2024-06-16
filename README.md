# API Gerenciamento de Pacientes

![Capa do Projeto](https://picsum.photos/850/280)

# Sobre o Projeto

Este projeto implementa uma API de gerenciamento de pacientes utilizando .NET. O propósito deste projeto é fornecer um CRUD robusto para o gerenciamento de dados de pacientes e métodos para cálculo de peso ideal, IMC e outras informações do paciente.

# Índice/Sumário

- [Sobre](#sobre-o-projeto)
- [Sumário](#índice/sumário)
- [Requisitos Funcionais](#requisitos-funcionais)
- [Arquitetura](#arquitetura)
- [Instruções de Uso](#instruções-de-uso)
- [Tecnologias Usadas](#tecnologias-usadas)
- [Código Fonte](#código-fonte)
- [Testes](#testes)
- [Extra](#extra)
- [Contribuição](#contribuição)
- [Autores](#autores)
- [Licença](#licença)
- [Agradecimentos](#agradecimentos)

# Requisitos Funcionais

 - [x] Cadastrar pacientes
 - [x] Retornar todos os pacientes
 - [x] Retornar paciente por ID
 - [x] Editar um paciente
 - [x] Deletar um paciente
 - [x] Calcular IMC
 - [x] Validação de CPF
 - [x] Sensura de CPF
 - [x]  e outras medidas do paciente

# Arquitetura

A arquitetura do sistema é baseada em uma API Rest utilizando Spring Boot. A API é dividida nos seguintes componentes:

- Controller: Camada responsável por expor os endpoints e lidar com as requisições HTTP.
- Service: Camada onde reside a lógica de negócio.
- Repository: Camada de acesso aos dados, interage com o banco de dados.
- Domain: Representação das entidades do sistema.

# Instruções de Uso

1. Clone o repositório:

   `git clone https://github.com/GabrieldeSouza1/projectGerencia.git`

2. Abra a pasta no Visual Studio

3. Abra e execute a solução

4. A aplicação estará disponível em:

   `https://localhost:44395/swagger`

5. Teste a criação de paciente na rota através da interface do swagger

# Tecnologias Usadas

- [.NET] (https://dotnet.microsoft.com/pt-br/)

# Código Fonte

O código fonte do projeto pode ser encontrado na pasta [apiGerencia](https://github.com/GabrieldeSouza1/projectGerencia/tree/main/apiGerencia).

# Testes

- Testes Unitários: Os testes unitários cobrem a lógica de negócios e validações dos modelos. Foram implementados com UnitTesting.

- Testes de Integração: Os testes de integração verificam a interação entre diferentes componentes do sistema. Foram implementados com UnitTesting.

# Extra
- Análise de Código[SonarCloud] 

# Contribuição

Leia o arquivo [CONTRIBUTING.md](CONTRIBUTING.md) para saber detalhes sobre o nosso código de conduta e o processo de envio de solicitações _pull_ (_Pull Request_) para nós.

# Autores

[Gabriel de Souza](https://github.com/GabrieldeSouza1)

# Licença

Este projeto está licenciado sob a Licença MIT, consulte o arquivo [LICENSE](LICENSE) para mais detalhes.

# Agradecimentos

Agradeço aos meus amigos que me ajudaram quando não conseguia prosseguir!
