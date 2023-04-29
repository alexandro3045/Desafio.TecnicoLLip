# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

Contatos FIRJAN
Abaixo relação dos responsáveis FIRJAN pelo desenvolvimento da API DYNAMICS.

 Nome: FELIPE MENTEL AUGUSTO: ARQUITETO DE SISTEMA Fones: (21) 2587-5572 Email: fpaugusto@firjan.com.br

Nome: ALEXANDRO RAMOS ALVES: Desenvolvedor Fone: (21) 2587-5542 Email: alralves@firjan.com.br

Introdução
Devido a migração dos sistemas legados para a nova plataforma dynamics, foi determinadoa criação de API de Integraçao no sistema legado.

Diante disso a integragração foi criada, com a responsabilidade de alimentar o sistema legado Corporativo com informações para o sistema Gestor de serviços e consultas de informações financeiras.
Começando, construindo e testando
Como qualquer sistema existe uma recomendação para consumir a API via Postman. Seguindo as devidas recomendações

Antes de tudo devemos baixar o Postman ou utilizar online através de plugins.

Link para Download: https://www.getpostman.com/downloads/ 

Após efetuar o download ou instalar algum plugin siga as recomendações sugeridas.

Preencher os campos com as seguintes informações:

username: TFirjan12ab

password: DISISRules

grant_type: password

URL de geração: https://svchmgext.firjan.com.br/ 

Seguindo o exemplo em anexo...

Firjan.Integracao.Dynamics\docs\img\1557324185789.png

Após a geração do token o mesmo deve ser inserido no Headers de quando for utilizar algum recurso da API:

Authorization: bearer TOKENGERADO

como exemplificado na imagem abaixo

Firjan.Integracao.Dynamics\docs\img\3557324885887.png

Documentação dos ambientes está disponível no diretório Firjan.Integracao.Dynamics\docs

Ambiente Homologação