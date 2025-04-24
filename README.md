
---

## 🚀 Funcionalidades

1. **Cadastro de Funcionários**  
   - Tipos: Desenvolvedor e Gerente  
   - Nome e cargo armazenados em memória.

2. **Cadastro de Projetos**  
   - Nome do projeto  
   - Armazenamento em lista interna.

3. **Alocação de Funcionários**  
   - Vincula um funcionário a um projeto com quantidade de horas.  
   - Validação: horas devem ser maior que zero.

4. **Listagem de Projetos**  
   - Exibe detalhes de cada projeto:  
     - Nome do projeto  
     - Lista de alocações (cargo, nome e horas)  
     - Custo total calculado (horas × custo/hora).

---

## 🛠 Tecnologias

- .NET SDK (versão 6.0 ou superior recomendada)
- Linguagem C#  
- Console Application (sem banco de dados — persistência em memória)

---

## 📥 Como Compilar e Executar

1. **Pré-requisitos**  
   - [.NET SDK 6.0+ instalado](https://dotnet.microsoft.com/download)  

2. **Compilar**  
   ```bash
   cd ProjetoPOO
   dotnet build
