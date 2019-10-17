# Saga-Boole
Saga Boole é um jogo onde você está ajudando George Boole a encontrar a melhor forma de descrever a álgebra de Boole.

- Unity 2018.4.11f1
- Visual Sutudio Code extensions: Debugger for Unity, Unity Tools.

# Fluxo-Git

Arquitetura Git (adaptado de Jordan Oliveira)

A cada nova implementação é criada uma nova branch com um padrão de nomenclatura, com o desenvolvimento da atividade.

Após o término da implementação ou término parcial, será feito um Pull request na branch master com uma descrição geral sobre a implementação.

● Dicas (Comandos)

Todo arquivo/pasta que será criado ou importado para o projeto, deve ser feito utilizando a própria interface do Unity(Ex: Arquivo 'Personagem.png', arrastar para pasta desejada dentro do Unity).

Criar branch
> git checkout -b [Nome da Branch]

Excluir branch
> git branch -d [Nome da Branch]

● Configuração Inicial

Clonar repositório
> git clone https://github.com/MatheusLope/Saga-Boole.git

Entrar na pasta do repositório
> cd <nome_da_pasta>

Cadastrar credenciais
> git config --global user.email "email@email.com"

> git config --global user.name "nome"

● Criar uma nova branch
(Nomenclatura Feature[ Dev/Doc ]/[ Oque está implementando ]-[ Nome ])
> git checkout -b FeatureDev/Plataforma-Jordan (Exemplo)
> git checkout -b FeatureDoc/GDDStoryboard-Jordan (Exemplo)
> git checkout -b FeatureArte/ConceptPersonagem-Jordan (Exemplo)

Após fazer alterações no projeto
> git add .

Verificar se os arquivos modificados estão no 'git status', caso fiquem verde estão prontos
para o commit. Os arquivos em vermelho não irão.
> git status

Caso não deseje fazer o commit em um arquivo específico utilizar o comando
> git checkout -- assets/script/player/skills.cs
> git checkout -- . (Tira todos os arquivos do Commit - Todos ficarão vermelho)

Logo após commitar as alterações
> git commit -m "[Breve descrição]" -m "[Descrição Detalhada]"

Subir para o repositório
> git push origin FeatureDev/Plataforma-Jordan

Após **finalizado** a implementação, ir no site do github, e criar um Pull request.
