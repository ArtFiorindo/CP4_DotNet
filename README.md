# Brinquedos API

---
## Integrantes do Grupo

- **Artur Fiorindo** - RM553481
- **Eduardo Função** - RM553362
- **Erick Lopes** - RM553927
- **Jhoe Hashimoto** - RM553927
---

## Descrição

Este projeto é uma API para gerenciamento de brinquedos de uma empresa que fabrica brinquedos para crianças de até 12 anos. O projeto foi desenvolvido utilizando **C#** com **.NET 6** e **Entity Framework Core** para se conectar ao banco de dados **Oracle**. A API fornece operações **CRUD** (Create, Read, Update, Delete) para gerenciar brinquedos.

### Endpoints disponíveis:

- **GET /api/brinquedos**: Retorna uma lista de todos os brinquedos cadastrados.
- **GET /api/brinquedos/{id}**: Retorna os detalhes de um brinquedo específico.
- **POST /api/brinquedos**: Adiciona um novo brinquedo.
- **PUT /api/brinquedos/{id}**: Atualiza os dados de um brinquedo existente.
- **DELETE /api/brinquedos/{id}**: Remove um brinquedo específico.

## Tecnologias Utilizadas

- **C# com .NET 6**
- **Entity Framework Core**
- **Oracle Database**
- **Swagger para documentação da API**
- **Postman para testes**
- **Docker** (Opcional para rodar o Oracle localmente, se necessário)

## Instalação e Execução

### 1. Clonar o Repositório

```bash
git clone https://github.com/usuario/brinquedos-api.git
cd brinquedos-api
```

### 2. Restaurar as Dependências

No diretório do projeto, execute:

```bash
dotnet restore
```

### 3. Configurar a Conexão com o Banco de Dados

No arquivo `appsettings.json`, verifique se a string de conexão do Oracle está correta:

```json
"ConnectionStrings": {
  "OracleDbConnection": "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=rm553481;Password=021004;"
}
```

### 4. Executar as Migrações

Aplique as migrações para criar as tabelas no banco de dados:

```bash
dotnet ef database update
```

### 5. Executar a Aplicação

Após configurar o banco de dados e aplicar as migrações, execute a aplicação:

```bash
dotnet run
```

A aplicação estará disponível em:

- **Swagger UI**: [http://localhost:5000](http://localhost:5000)
- **API base**: [http://localhost:5000/api/brinquedos](http://localhost:5000/api/brinquedos)

## Exemplo de JSON para Cadastro de Brinquedo

Utilize o seguinte JSON no **Postman** para cadastrar um brinquedo via **POST**:

```json
{
  "nome_brinquedo": "Carrinho de Controle Remoto",
  "tipo_brinquedo": "Eletrônico",
  "classificacao": "4+",
  "tamanho": "Médio",
  "preco": 120.50
}
```

## Testes com o Swagger

O Swagger está configurado para rodar na raiz do servidor. Acesse `http://localhost:5000` para ver a documentação da API e testar os endpoints diretamente pela interface gráfica do Swagger.

## Estrutura do Projeto

- **Controllers**: Contém os controladores da API (CRUD para Brinquedos).
- **Models**: Contém o modelo `Brinquedo` utilizado para representar a entidade no banco de dados.
- **Data**: Contém o contexto de dados `BrinquedosContext` utilizado pelo Entity Framework Core para acessar o banco de dados.

## Prints de Tela

### 1. Tela Inicial do Swagger

![Swagger UI](https://link-para-imagem/swagger-ui.png)

### 2. Teste de Cadastro de Brinquedo no Postman

![Postman](https://link-para-imagem/postman-cadastro.png)

---

