<h2 align="center">💻 Mini Projetos em C# | Estudos de Programação Orientada a Objetos 💻</h2>

## 📌 Sobre o projeto

Este repositório reúne uma coleção de **mini projetos desenvolvidos em C#**, cada um representando um "nível" de aprendizado com foco em diferentes recursos da linguagem.  

O objetivo foi praticar desde os fundamentos de orientação a objetos até recursos mais avançados, como **polimorfismo, interfaces, coleções genéricas, LINQ e consumo de APIs com serialização e desserialização**.  

---

## 🚀 Tecnologias utilizadas

- ✅ **C#** - Linguagem principal  
- ✅ **.NET Console** - Ambiente de execução  
- ✅ **System.Collections.Generic** - Listas e dicionários  
- ✅ **LINQ** - Consultas em coleções  
- ✅ **System.IO** - Manipulação de arquivos  
- ✅ **System.Text.Json** - Serialização e desserialização de objetos  

---

## 🎯 Mini Projetos

✔️ **Cadastro de Usuários**  
- Estruturação com **classes e métodos básicos**.  
- Uso de **construtores**, **encapsulamento** (getters/setters).  
- Manipulação de dados em memória e gravação em **arquivos de texto**.  

✔️ **Catálogo de Produtos**  
- Uso de **List\<T>** para armazenamento de objetos.  
- CRUD em memória com **foreach**, **Add**, **Remove**.  
- Aplicação de **propriedades automáticas** e **construtores parametrizados**.  

✔️ **Formas Geométricas**  
- Criação de **classe abstrata** (`FormaGeometrica`) com métodos abstratos.  
- Implementação de **herança** (Retângulo, Círculo, Triângulo).  
- Aplicação de **polimorfismo** para sobrescrever cálculos de área/perímetro.  
- Criação de uma **interface** (`IEntradaDados`) para padronizar entrada de dados.  
- Uso de **Dictionary\<string, List<FormaGeometrica>>** para associar usuários às formas.  

✔️ **CRUD com LINQ**  
- Consultas com **LINQ** (`Where`, `Select`, `OrderBy`).  
- Uso de **expressões lambda** para filtragem e ordenação.  
- Comparação entre consultas manuais e consultas LINQ.  

✔️ **ByteBank (Simulação Bancária)**  
- Modelagem com **classes** (`Conta`, `Cliente`).  
- Aplicação de **métodos de negócio** (Depósito, Saque, Transferência).  
- Uso de **validações com exceções** (`throw`, `try/catch`).  
- Implementação de **sobrecarga de construtores**.  

✔️ **Consumo de API**  
- Utilização de **HttpClient** para requisições externas.  
- Uso de **async/await** para chamadas assíncronas.  
- **Desserialização de JSON** em objetos C# com `JsonSerializer.Deserialize<T>()`.  
- **Serialização de objetos** para JSON com `JsonSerializer.Serialize()`.   

---

## 📩 Contato

📧 **Email:** [vitorassis997@gmail.com](mailto:vitorassis997@gmail.com)  
👨‍💻 **GitHub:** [github.com/vitorhassis](https://github.com/vitorhassis)

---

## 📂 Como compilar e executar

1. Certifique-se de ter o **.NET SDK** instalado ([Download .NET](https://dotnet.microsoft.com/download)).  
2. Clone este repositório e acesse a pasta de um mini projeto específico:  
   ```bash
   git clone https://github.com/vitorhassis/mini-projetos-csharp.git
   cd mini-projetos-csharp/NomeDoProjeto
   dotnet run


<p align="center">⚡ <em>Desenvolvido por Vitor Assis</em> ⚡</p>
