# Dotnet-API
### API feita utilizando banco de dados Mysql Server.

#### Instalação
1. Faça o clone do projeto.
2. Instale o <b>Mysql Server<b> e altere os dados da conexão conexão no arquivo `appsettings.json`.
3. Instale as migrations no banco utilizando o comando: `dotnet ef database update`
4. Instale o certificado `dotnet ef database update`
5. Rode o servidor `dotnet run`

#### Utilizando a API

<b>Get All:</b> `https://localhost:5001/api/contratos/`

<b>Get:</b> `https://localhost:5001/api/contratos/{id}`

<b>Post:</b> `https://localhost:5001/api/contratos`
 `{
	"DataContrato" : "2021-02-27 13:28:58",  
	"Parcelas" : 5,
	"ValorFinanciado" : 10000.00,
}`
![alt text](https://ibb.co/3C5pzfr)

<b>Put:</b> `https://localhost:5001/api/contratos/{id}`

<b>Delete:</b> `https://localhost:5001/api/contratos/{id}`
