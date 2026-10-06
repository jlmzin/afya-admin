# Dashboard Admin - Afya Pedagogico

## Identificacao

**Aluno:** Juan Lima Machado
**Disciplina:** Ciencia da Computaçao
**Projeto:** Dashboard Admin com Blazor WebAssembly e MudBlazor

## Objetivo

Desenvolver um dashboard administrativo responsivo utilizando Blazor WebAssembly e MudBlazor, aplicando conceitos de componentes reutilizaveis, organizacao de projeto, visualizacao de dados e construcao de interfaces modernas.

## Tecnologias utilizadas

- C#
- .NET
- Blazor WebAssembly
- MudBlazor
- HTML
- Git e GitHub

## Como executar

### Pre-requisitos

- .NET SDK instalado
- Git instalado

### Execucao

Clone o repositorio:

    git clone https://github.com/jlmzin/afya-admin.git

Entre na pasta:

    cd afya-admin

Execute a aplicacao:

    dotnet run

Depois, acesse no navegador a URL local exibida pelo terminal.

## Funcionalidades

- Dashboard administrativo responsivo
- Tema escuro
- Menu lateral de navegacao
- Alternancia entre tema claro e escuro
- Cards com indicadores principais
- Seletor de periodo
- Grafico de receita mensal
- Distribuicao de clientes por segmento
- Performance dos projetos
- Lista de atividades recentes
- Tabela de projetos recentes

## Estrutura do projeto

    afya-admin/
    ├── Components/
    ├── Data/
    ├── Layout/
    ├── Pages/
    ├── wwwroot/
    ├── Program.cs
    └── README.md

## Componentes reutilizaveis

O dashboard foi dividido em componentes independentes para facilitar a organizacao e a reutilizacao do codigo.

| Componente | Responsabilidade |
|---|---|
| CabecalhoPagina | Cabecalho principal e seletor de periodo |
| KpiCard | Exibicao dos indicadores principais |
| GraficoReceita | Grafico de receita mensal |
| GraficoDistribuicaoClientes | Distribuicao dos clientes por segmento |
| PerformanceProjetos | Indicadores de performance dos projetos |
| AtividadesRecentes | Lista de atividades recentes |
| ProjetosRecentes | Tabela com projetos recentes |

## Dados

Os dados apresentados no dashboard sao dados ficticios definidos em:

    Data/DashboardData.cs

A classe concentra os dados utilizados pelos componentes, mantendo a pagina Dashboard.razor responsavel principalmente pela composicao da interface.

## Responsividade

A interface utiliza o sistema de grid e componentes responsivos do MudBlazor para adaptar o dashboard a diferentes tamanhos de tela.

## Inspecao com DevTools

Durante o desenvolvimento, o navegador foi utilizado para inspecionar os elementos da interface.

Entre os elementos observados estao componentes do MudBlazor que geram classes como:

- mud-paper
- mud-elevation-1
- pa-4
- d-flex

## Aprendizados

O desenvolvimento deste projeto permitiu praticar:

- Criacao de interfaces com Blazor WebAssembly
- Utilizacao do MudBlazor
- Criacao de componentes reutilizaveis
- Organizacao de dados em uma classe separada
- Composicao de paginas com componentes
- Criacao de layouts responsivos
- Utilizacao de temas claro e escuro
- Uso de Git e GitHub

## Dificuldades e solucoes

### Organizacao da pagina

O dashboard foi dividido em componentes menores, deixando o Dashboard.razor responsavel pela composicao da pagina.

### Responsividade

Foram utilizados recursos responsivos do MudBlazor para reorganizar os elementos em telas menores.

### Versionamento

O projeto foi desenvolvido utilizando Git, com commits realizados durante as etapas de implementacao e enviados para o repositorio GitHub.

## Possiveis melhorias

- Conectar o dashboard a uma API real
- Adicionar autenticacao de usuarios
- Implementar filtros reais de dados
- Adicionar paginacao e ordenacao na tabela
- Persistir configuracoes do usuario
- Criar mais indicadores e visualizacoes
