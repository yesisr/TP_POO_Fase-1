# Sistema de Gestão de Obra de Construção Civil

## 📝 Sobre o Projeto

Este projeto, desenvolvido no âmbito da disciplina de Programação Orientada a Objetos (POO), é um sistema de gestão para obras de construção civil. O seu objetivo principal é aplicar os conceitos de POO para modelar e gerir os custos e recursos associados a uma obra.

A **Fase 1** focou-se na identificação de classes, criação de interfaces e na lógica base de encapsulamento para o cálculo de custos.

## 🚀 Funcionalidades Principais

O sistema permite gerir as seguintes entidades através da classe agregadora `ConstructionWork`:

- **Materiais e Armazéns (`Storage`, `StorageItem`, `Material`):**

  - Gestão de múltiplos armazéns.
  - Associação de materiais a quantidades de stock.
  - Identificação de materiais por código único.

- **Mão de Obra (`Labor`):**

  - Registo de trabalhadores e serviços.
  - Distinção entre mão de obra própria e **subcontratada**.
  - Cálculo de custos baseado em valores definidos.

- **Veículos e Equipamentos (`Vehicle`, `VehicleUsage`):**

  - Registo de frota com matrícula e modelo.
  - Controlo de utilização por horas (com arredondamento automático para cima).
  - Cálculo de custos operacionais (Custo/Hora).

- **Orçamentos (`Budget`):**
  - Criação de rubricas orçamentais com data e valor estimado.

## 🛠️ Arquitetura e Destaques Técnicos

O projeto demonstra uma forte aplicação dos pilares da POO (Encapsulamento, Abstração, Polimorfismo) e utiliza uma estrutura robusta:

### Interfaces

O desacoplamento é garantido através do uso de contratos claros:

- **`ICostable`**: Implementado por todas as classes que geram despesa, permitindo o cálculo polimórfico do custo total da obra.
- **`IDescribable`**: Garante que as entidades possuem descrição.
- **`IIdentifiable`**: Assegura identificação única (ex: Materiais).
- **`IStorable`**: Define itens passíveis de armazenamento com quantidade.
- **`IDateable`**: Define entidades com registo temporal.

### Tratamento de Erros (Exceções Customizadas)

Foram implementadas exceções específicas para garantir a integridade dos dados:

- `InvalidQuantityException`: Previne stocks negativos.
- `MaterialNotFoundException` / `StorageNotFoundException`: Valida a existência de recursos.
- `VehicleExistsException` / `VehicleNotFoundException`: Gere conflitos na frota.
- `ConstructionWorkNotFoundException`: Valida o contexto da obra.

## 📋 Estrutura de Ficheiros

- **ConstructionWork.cs**: Classe central que agrega todas as listas de recursos.
- **Business.cs**: Classe de topo (Empresa) que gere as obras.
- **Interfaces/**: Definições de contratos (`ICostable.cs`, etc.).
- **Exceptions/**: Lógica de erros (`custom_exceptions.cs`).

## 🧑‍💻 Autor

- **Bruno Paiva** - a31496@alunos.ipca.pt
