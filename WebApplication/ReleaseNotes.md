## 0.0.2 - Criando repositorio no GitHub
2024-06-23: Criei o repositório no GitHub e subi o projeto para lá. Vamos registar essa historia organizadamente.
Nunca tinha reparado o quão chato é apontar tudo certo no .gitignore
Criei os repositorios, serviços e suas interfaces. Por enquanto não estou ligando muito para a arquitetura, mas acho que vou precisar organizar melhor depois
Instalei o Bogus para gerar dados pro DB. Casou certinho com a ideia de popular o banco de dados.
Criei os DTOs e instalei o AutoMapper para mapear as entidades para os DTOs.
Agora os scripts criam as tabelas e populam apenas a tabela de usuario por enquanto.
	*Erros E dificuldades*
		* Tive um pouco de dificuldade de configurar o AutoMapper no Program.cs do Frankenstein.DB, 
			pois sempre estava null no momento de converter o DTO em entidade para salvar o objeto no banco de dados.

## 0.0.1 - Frankenstein, a primeira perna.
2024-06-19: Estou começando pelos registros do banco de dados:
A ideia é criar um script que eu possa resetar o banco de dados e popular com dados de teste, para que eu possa testar a aplicação sem precisar ficar criando registros manualmente.
	* Tive bastante dificuldade para iniciar o projeto, pois teve alguns erros de arquitetura:
		** A estrutura das pastas estava errada e com isso estava dando erros de referencia.
	* Estou tendo certa dificuldade para criar o serviço que vai ler os script para criar tabelas no banco de dados, pois não sei como fazer.
Criei o AppDbContext e criei as entidades. 

** Depois vou criar os Services, Repositories e Controllers
E ai vou colocar o loop por quantidade para alimentar os dados de teste.

-- Quero testar concorrencia e etc, vou usar K6