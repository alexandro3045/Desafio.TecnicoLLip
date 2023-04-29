# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

Contatos FIRJAN
Abaixo rela��o dos respons�veis FIRJAN pelo desenvolvimento da API DYNAMICS.

 Nome: FELIPE MENTEL AUGUSTO: ARQUITETO DE SISTEMA Fones: (21) 2587-5572 Email: fpaugusto@firjan.com.br

Nome: ALEXANDRO RAMOS ALVES: Desenvolvedor Fone: (21) 2587-5542 Email: alralves@firjan.com.br

Introdu��o
Devido a migra��o dos sistemas legados para a nova plataforma dynamics, foi determinadoa cria��o de API de Integra�ao no sistema legado.

Diante disso a integragra��o foi criada, com a responsabilidade de alimentar o sistema legado Corporativo com informa��es para o sistema Gestor de servi�os e consultas de informa��es financeiras.
Come�ando, construindo e testando
Como qualquer sistema existe uma recomenda��o para consumir a API via Postman. Seguindo as devidas recomenda��es

Antes de tudo devemos baixar o Postman ou utilizar online atrav�s de plugins.

Link para Download: https://www.getpostman.com/downloads/ 

Ap�s efetuar o download ou instalar algum plugin siga as recomenda��es sugeridas.

Preencher os campos com as seguintes informa��es:

username: TFirjan12ab

password: DISISRules

grant_type: password

URL de gera��o: https://svchmgext.firjan.com.br/ 

Seguindo o exemplo em anexo...

Firjan.Integracao.Dynamics\docs\img\1557324185789.png

Ap�s a gera��o do token o mesmo deve ser inserido no Headers de quando for utilizar algum recurso da API:

Authorization: bearer TOKENGERADO

como exemplificado na imagem abaixo

Firjan.Integracao.Dynamics\docs\img\3557324885887.png

Documenta��o dos ambientes est� dispon�vel no diret�rio Firjan.Integracao.Dynamics\docs

Ambiente Homologa��o