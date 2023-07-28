# To-dos

- [ ] Fazer sistema de login com diferentes permissoes
  - [ ] Admin
  - [ ] User

- [ ] Criar as Classes
  - [ ] Empresa
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Inserir novo aviao
    - [ ] Alterar estado aviao
    
  - [ ] Aviao
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ] 
  - [ ] Avioneta
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ] Calcular valor do frete
  - [ ] Aeronave Comercial
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ] 
  - [ ] Aeronave Particular
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ] Calcular valor do frete
  - [ ] Aeronave Mercadorias
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ] Calcular valor do frete
  - [ ] Aeroporto
    - [ ] Criar Construtores
    - [ ] Getters e Setters
    - [ ] Methods
        - [ ]

- [ ] Criar as Interfaces

- [ ] Criar as Exceptions

- [ ] Consultar avioes disponiveis
  - [ ] Filtros
    - [ ] Tipo de aviao
    - [ ] Aeroporto
    - [ ] Disponibilidade
    - [ ] Data
- [ ]  Calcular valor do frete
- [ ]  Calcular valor entre 2 datas (mediante disponibilidades)

- [ ] [Data Base Implementation](/Instructions/databaseImplementation.md)



### SCHEMA OF THE FOLDERS

    AeroMilsFleetManagementSystem/
    |-- Models/
    |   |-- Aviao.cs
    |   |-- Empresa.cs
    |   |-- Reserva.cs
    |   |-- ... (other model classes)
    |
    |-- Views/
    |   |-- FormMain.cs (Main form with user interface)
    |   |-- FormInsertAviao.cs
    |   |-- FormAlterarEstado.cs
    |   |-- FormAvioesDisponiveis.cs
    |   |-- FormEmManutencao.cs
    |   |-- FormCalcularFrete.cs
    |   |-- FormExportar.cs
    |   |-- ... (other form classes)
    |
    |-- Controllers/
    |   |-- AviaoController.cs
    |   |-- EmpresaController.cs
    |   |-- ReservaController.cs
    |   |-- ... (other controller classes)
    |
    |-- Data/
    |   |-- SQLiteDBContext.cs (for SQLite database connection and queries)
    |   |-- ... (other data-related classes, if needed)
    |
    |-- Utils/
    |   |-- DateSimulator.cs (if implementing the date simulator feature)
    |   |-- CSVExporter.cs (if exporting data to a CSV file)
    |   |-- ... (other utility classes, if needed)
    |
    |-- AeroMilsFleetManagementSystem.csproj
    |-- README.md
    |-- Program.cs (entry point of the application)