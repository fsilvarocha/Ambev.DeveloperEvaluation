# Ambev Developer Evaluation

## Tecnologias Usadas

- **.NET Core** (ou outra tecnologia que esteja utilizando)
- **PostgreSQL** (ou outro banco de dados que está utilizando)

## Banco de Dados e Dados Iniciais

Este projeto utiliza um banco de dados **PostgreSQL** e inclui um script SQL para facilitar a inserção de dados iniciais, como categorias, produtos e companhias.

O script SQL necessário para a configuração inicial do banco de dados está localizado no seguinte caminho:

/Adapters/Drivers/Infrastructure/Ambev.DeveloperEvaluation.ORM/SaleSeed.sql

### Como Executar o Script SQL

1. **Localize o arquivo `SaleSeed.sql`** no caminho indicado acima.

2. **Conecte-se ao seu banco de dados** utilizando uma ferramenta de sua preferência, como:
   - [pgAdmin](https://www.pgadmin.org/) (para PostgreSQL)
   - [DBeaver](https://dbeaver.io/)
   - Linha de comando do PostgreSQL (`psql`)

3. **Execute o script** no banco de dados. O script irá inserir as categorias, produtos e companhias iniciais.

4. **Verifique se os dados foram inseridos corretamente** nas tabelas `Categorys`, `Products` e `Companys`.

### Exemplo de Dados Inseridos

O script SQL irá inserir os seguintes dados:

- **Categorias**: Refrigerantes, Sucos, Águas
- **Produtos**: Coca-Cola, Fanta Laranja, Suco de Laranja, etc.
- **Companhias**: Ambev S.A., Ambev Filial Rio de Janeiro


## Como Configurar a String de Conexão

A string de conexão é essencial para que o seu projeto se conecte ao banco de dados PostgreSQL. Para configurá-la, siga os passos abaixo:

1. **Abra o arquivo de configuração**:
   
   O arquivo de configuração geralmente é o `appsettings.json` ou o arquivo equivalente dependendo da estrutura do seu projeto.

2. **Localize a seção de conexões**:

   Encontre a seção `"ConnectionStrings"`, onde você verá uma chave chamada `DefaultConnection` ou algo semelhante.

3. **Edite a string de conexão**:

   Substitua os valores de `Host`, `Database`, `Username` e `Password` com as informações do seu banco de dados. Aqui está um exemplo de como a string de conexão pode ficar:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Database=seubancodedados;Username=seuusuario;Password=suasenha"
   }
   
## Como Executar o Projeto

Após configurar o projeto e a string de conexão, você pode executar o projeto no **Visual Studio** ou **Visual Studio Code**.

### No Visual Studio

1. **Abra o projeto no Visual Studio**:
   - Clique duas vezes no arquivo `.sln` para abrir o projeto.
   
2. **Inicie a execução**:
   - Clique no botão **"Iniciar"** ou pressione `F5` no teclado.
   - O Visual Studio irá compilar e executar o projeto.

3. **Acesse a API**:
   - Após o projeto ser executado, a API estará disponível na URL configurada no arquivo `Properties/launchSettings.json`.
   - Você pode verificar a URL e a porta lá e acessar a API usando o navegador ou ferramentas como o **Postman**.

### No Visual Studio Code

1. **Abra o projeto no VS Code**:
   - Abra a pasta do projeto no VS Code utilizando o menu **File > Open Folder** ou o comando no terminal:

     ```bash
     code .
     ```

2. **Abra o terminal integrado**:
   - No VS Code, abra o terminal integrado através de **View > Terminal** ou utilizando o atalho `Ctrl + ~`.

3. **Execute o projeto**:
   - No terminal integrado, execute o comando:

     ```bash
     dotnet run
     ```

4. **Acesse a API**:
   - Após a execução, a API estará disponível na URL configurada no arquivo `Properties/launchSettings.json`.
   - Utilize o **Postman**, **curl** ou o navegador para fazer as requisições à API.
