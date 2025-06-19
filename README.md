# 🎸 ScreenSound 2.0

Uma aplicação de console desenvolvida em **C#** que simula um sistema de gerenciamento musical. É possível registrar bandas, adicionar álbuns, avaliar bandas e álbuns, e consultar detalhes como discografia e média de avaliações — tudo via menus interativos.

---

## 📌 Objetivo

Este projeto tem como foco a prática de:
- Programação orientada a objetos (POO) em C#
- Uso de listas, dicionários e controle de fluxo
- Estruturação de menus e interfaces para aplicações de console
- Boas práticas com `internal`, `interface`, herança e encapsulamento

---

## 📺 Funcionalidades

- ✅ Registrar bandas
- ✅ Registrar álbuns para uma banda
- ✅ Avaliar bandas
- ✅ Avaliar álbuns
- ✅ Exibir todas as bandas registradas
- ✅ Exibir detalhes de uma banda (álbuns + média de avaliação)
- ✅ Mostrar discografia e músicas de álbuns
- ✅ Interface interativa no console com menu principal

---

## 🧱 Estrutura de Pastas
ScreenSound/
│
├── Models/
│ ├── Banda.cs
│ ├── Album.cs
│ ├── Musica.cs
│ ├── Avaliacao.cs
│ └── IRate.cs
│
├── Menus/
│ ├── Menu.cs
│ ├── RegisterBand.cs
│ ├── RegisterAlbum.cs
│ ├── MenuRateBand.cs
│ ├── RateAlbum.cs
│ ├── BandRegister.cs
│ ├── MenuDetails.cs

│ └── MenuExit.cs
│
└── Program.cs


---

## 🧠 Conceitos Aplicados

- **Herança**: Os menus herdam da classe base `Menu`, aproveitando métodos comuns.
- **Interfaces**: `IRate` garante que `Banda` e `Album` tenham o método `AdicionarNota` e a propriedade `Media`.
- **Encapsulamento**: Uso de `internal` e propriedades `get` para proteger acesso direto.
- **Coleções**: Manipulação de `List<T>` e `Dictionary<TKey, TValue>` para organizar os dados.
- **LINQ básico**: Para somar, filtrar e calcular médias.

---

## 🧪 Exemplo de Uso

Registrar uma banda:
Digite 1 para registrar uma banda
> Queen

Registrar um álbum:
Digite 2 para registrar o álbum de uma banda
> Queen
> A Night at the Opera

Avaliar uma banda:
Digite 4 para avaliar uma banda
> Queen
> 10

Exibir detalhes:
Digite 5 para exibir os detalhes de uma banda
> Queen
Média: 10
Álbuns:
- A Night at the Opera

## 🙋‍♂️ Autor
Desenvolvido por João Domingues 🎵

## 💡 Extras
Você pode expandir esse sistema com:
Salvamento em arquivo JSON ou banco de dados
Interface gráfica com WinForms ou WPF
Filtro de músicas por duração ou disponibilidade
Exportação da discografia para PDF
