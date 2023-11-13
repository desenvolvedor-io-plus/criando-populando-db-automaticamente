# Criando e Populando Automaticamente Qualquer Banco de Dados

## Introdução
Este repositório oferece um guia prático sobre como criar e popular automaticamente qualquer banco de dados em um projeto ASP.NET. Utilizando um exemplo com tabelas variadas (fornecedor, endereço, produto, usuário, etc.), demonstramos uma implementação que verifica e configura automaticamente o banco de dados no início da aplicação.

## Desafio
Configurar bancos de dados e suas tabelas para novos projetos pode ser um processo demorado e propenso a erros. Além disso, o desenvolvimento local frequentemente requer configurações diferentes das de produção, aumentando a complexidade.

## Solução Proposta
Nossa solução automatiza a criação e a população do banco de dados. Durante o início da aplicação, o sistema verifica se os contextos definidos apontam para um banco de dados existente e se as tabelas correspondentes estão presentes. Se necessário, ele executa migrations para criar as tabelas e, em seguida, roda um script para popular o banco com dados de exemplo.

## Funcionalidades
- **Detecção Automática de Banco de Dados:** Verifica a existência do banco de dados e cria se não existir.
- **Criação de Tabelas via Migrations:** Utiliza migrations para criar as tabelas conforme definido nos contextos.
- **População Automática de Dados:** Executa um script para inserir dados iniciais nas tabelas.
- **Flexibilidade de Ambiente:** Em ambiente de desenvolvimento, utiliza SQL Lite para facilitar o setup, enquanto em produção, conecta-se ao SQL Server.

## Vantagens
- **Eficiência no Setup:** Reduz significativamente o tempo e esforço para configurar o banco de dados.
- **Flexibilidade:** Permite fácil alternância entre ambientes de desenvolvimento e produção.
- **Consistência de Dados:** Garante que todos os ambientes tenham um conjunto inicial consistente de dados para testes e desenvolvimento.

## Como Utilizar Este Repositório
1. **Configuração do Ambiente:** Certifique-se de ter o .NET Core SDK instalado.
2. **Clonar o Repositório:** Clone este repositório para sua máquina local.
3. **Explorar o Código:** Abra o projeto no seu IDE favorito e explore a estrutura e implementação.
4. **Executar o Projeto:** Execute o Build e observe o comportamento do projeto conforme o vídeo do conteúdo PLUS.
