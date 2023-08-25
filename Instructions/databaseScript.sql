CREATE TABLE Avioes (
    id_aviao INTEGER PRIMARY KEY AUTOINCREMENT,
    modelo VARCHAR(45) NOT NULL,
    capacidade_passageiros INTEGER NOT NULL,
    autonomia INTEGER NOT NULL,
    data_ult_manutencao DATE NOT NULL,
    tipo_aviao VARCHAR(45) NOT NULL
);

CREATE TABLE Avionetas(
    id_aviao INTEGER,
    area_minima_descolagem INTEGER NOT NULL,
    valor_frete DECIMAL NOT NULL,
    CONSTRAINT fk_avionetas_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

CREATE TABLE AeronavesMercadorias(
    id_aviao INTEGER,
    capacidade_carga INTEGER NOT NULL,
    valor_frete DECIMAL NOT NULL,
    CONSTRAINT fk_aeronaves_mercadorias_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

CREATE TABLE AeronavesComerciais(
    id_aviao INTEGER,
    num_voos_diarios INTEGER NOT NULL,
    companhia_area DECIMAL NOT NULL,
    CONSTRAINT fk_aeronaves_comerciais_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

CREATE TABLE AeronavesParticulares(
    id_aviao INTEGER,
    num_proprietarios INTEGER NOT NULL,
    valor_frete DECIMAL NOT NULL,
    CONSTRAINT fk_aeronaves_particulares_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

CREATE TABLE Manutencoes(
    id_manutencao INTEGER PRIMARY KEY AUTOINCREMENT,
    id_aviao INTEGER NOT NULL,
    data_inicio DATE NOT NULL,
    data_fim DATE,
    CONSTRAINT fk_manutencoes_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

CREATE TABLE Reservas(
    id_reserva INTEGER PRIMARY KEY AUTOINCREMENT,
    id_aviao INTEGER NOT NULL,
    nome_cliente VARCHAR(45) NOT NULL,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    CONSTRAINT fk_reservas_avioes FOREIGN KEY (id_aviao) REFERENCES Avioes(id_aviao)
);

-- Insert data into Avioes table
INSERT INTO Avioes (modelo, capacidade_passageiros, autonomia, data_ult_manutencao, tipo_aviao)
VALUES
    ('Boeing 777', 300, 12000, '2023-08-01', 'Comercial'),
    ('Airbus A320', 150, 8000, '2023-07-15', 'Comercial'),
    ('Embraer E190', 100, 4000, '2023-08-10', 'Comercial'),
    ('Cessna 172', 4, 800, '2023-08-05', 'Particular'),
    ('Beechcraft King Air', 8, 1200, '2023-07-20', 'Particular'),
    ('Antonov An-225', 800, 16000, '2023-07-30', 'Cargo'),
    ('Piper PA-28 Cherokee', 4, 600, '2023-07-25', 'Particular'),
    ('Gulfstream G650', 18, 7000, '2023-08-15', 'Particular'),
    ('Embraer Legacy 650', 13, 5000, '2023-08-20', 'Particular'),
    ('Airbus A380', 853, 14000, '2023-08-10', 'Comercial'),
    ('Boeing 737', 180, 6000, '2023-09-01', 'Comercial'),
    ('Cessna Citation X', 12, 3500, '2023-09-05', 'Particular'),
    ('Dassault Falcon 7X', 16, 6000, '2023-09-10', 'Particular'),
    ('Embraer Phenom 300', 8, 2200, '2023-09-15', 'Particular'),
    ('Bombardier Global 7500', 19, 8000, '2023-09-20', 'Particular'),
    ('Boeing 787 Dreamliner', 296, 15000, '2023-09-25', 'Comercial'),
    ('Cirrus SR22', 4, 1000, '2023-10-01', 'Particular'),
    ('Pilatus PC-12', 9, 1600, '2023-10-05', 'Particular'),
    ('Airbus A350', 440, 16000, '2023-10-10', 'Comercial'),
    ('Embraer Legacy 500', 12, 3500, '2023-10-15', 'Particular'),
    ('Cessna Caravan 208', 14, 1100, '2023-10-20', 'Particular'),
    ('Antonov An-124', 500, 4200, '2023-10-25', 'Cargo'),
    ('Beechcraft Bonanza', 6, 800, '2023-10-30', 'Particular'),
    ('Boeing 747', 524, 7500, '2023-11-01', 'Comercial'),
    ('Embraer E175', 88, 3200, '2023-11-05', 'Comercial'),
    ('Daher TBM 930', 6, 1600, '2023-11-10', 'Particular'),
    ('Cessna 208 Caravan', 10, 1000, '2023-11-15', 'Particular'),
    ('Airbus A330', 440, 12500, '2023-11-20', 'Comercial'),
    ('Cirrus Vision Jet', 5, 1300, '2023-11-25', 'Particular'),
    ('Embraer E195-E2', 146, 2800, '2023-11-30', 'Comercial');


-- Insert data into Avionetas table
INSERT INTO Avionetas (id_aviao, area_minima_descolagem, valor_frete)
VALUES
    (1, 30, 200.50),
    (2, 20, 100.75),
    (3, 25, 120.25),
    (4, 15, 80.90),
    (5, 35, 180.00),
    (6, 18, 90.50),
    (7, 25, 110.25),
    (8, 12, 70.75),
    (9, 22, 130.00),
    (10, 10, 60.25),
    (11, 30, 180.50),
    (12, 15, 75.75),
    (13, 25, 140.25),
    (14, 10, 55.00),
    (15, 35, 200.50),
    (16, 18, 100.75),
    (17, 23, 125.25),
    (18, 13, 75.90),
    (19, 30, 170.00),
    (20, 16, 80.25),
    (21, 28, 150.50),
    (22, 14, 70.75),
    (23, 32, 180.25),
    (24, 18, 90.00),
    (25, 24, 120.50),
    (26, 12, 60.75),
    (27, 30, 190.25),
    (28, 20, 100.50),
    (29, 26, 140.75),
    (30, 14, 70.25);


-- Insert data into AeronavesMercadorias table
INSERT INTO AeronavesMercadorias (id_aviao, capacidade_carga, valor_frete)
VALUES
    (1, 15000, 5000.75),
    (2, 8000, 3500.50),
    (3, 12000, 7000.25),
    (4, 2000, 1500.00),
    (5, 30000, 12000.75),
    (6, 10000, 4000.50),
    (7, 18000, 8000.25),
    (8, 7000, 3000.00),
    (9, 13000, 6000.75),
    (10, 5000, 2500.50),
    (11, 17000, 7500.25),
    (12, 9000, 4000.00),
    (13, 11000, 5000.75),
    (14, 6000, 2500.50),
    (15, 14000, 6000.25),
    (16, 8000, 3500.00),
    (17, 12000, 5000.75),
    (18, 4000, 1500.50),
    (19, 25000, 10000.25),
    (20, 10000, 4000.00),
    (21, 16000, 7000.75),
    (22, 9000, 3500.50),
    (23, 18000, 8000.25),
    (24, 7000, 3000.00),
    (25, 11000, 5000.75),
    (26, 5000, 2500.50),
    (27, 14000, 6000.25),
    (28, 8000, 3500.00),
    (29, 12000, 5000.75),
    (30, 4000, 1500.50);


-- Insert data into AeronavesComerciais table
INSERT INTO AeronavesComerciais (id_aviao, num_voos_diarios, companhia_area)
VALUES
    (1, 10, 'Airline A'),
    (2, 8, 'Airline B'),
    (3, 6, 'Airline C'),
    (4, 4, 'Airline D'),
    (5, 12, 'Airline E'),
    (6, 5, 'Airline F'),
    (7, 7, 'Airline G'),
    (8, 9, 'Airline H'),
    (9, 11, 'Airline I'),
    (10, 7, 'Airline J'),
    (11, 13, 'Airline K'),
    (12, 6, 'Airline L'),
    (13, 8, 'Airline M'),
    (14, 10, 'Airline N'),
    (15, 12, 'Airline O'),
    (16, 4, 'Airline P'),
    (17, 6, 'Airline Q'),
    (18, 9, 'Airline R'),
    (19, 11, 'Airline S'),
    (20, 14, 'Airline T'),
    (21, 7, 'Airline U'),
    (22, 10, 'Airline V'),
    (23, 12, 'Airline W'),
    (24, 6, 'Airline X'),
    (25, 8, 'Airline Y'),
    (26, 5, 'Airline Z'),
    (27, 9, 'Airline A1'),
    (28, 11, 'Airline B1'),
    (29, 7, 'Airline C1'),
    (30, 13, 'Airline D1');


-- Insert data into AeronavesParticulares table
INSERT INTO AeronavesParticulares (id_aviao, num_proprietarios, valor_frete)
VALUES
    (1, 1, 2500.50),
    (2, 2, 1800.75),
    (3, 1, 2200.25),
    (4, 1, 1500.00),
    (5, 2, 2000.75),
    (6, 1, 1700.50),
    (7, 1, 2100.25),
    (8, 3, 2300.00),
    (9, 1, 2500.50),
    (10, 2, 1800.75),
    (11, 1, 2200.25),
    (12, 3, 2500.00),
    (13, 1, 2300.75),
    (14, 2, 1700.50),
    (15, 1, 2100.25),
    (16, 1, 2500.00),
    (17, 1, 1800.75),
    (18, 2, 2200.25),
    (19, 1, 1500.00),
    (20, 2, 2000.75),
    (21, 1, 1700.50),
    (22, 1, 2100.25),
    (23, 3, 2300.00),
    (24, 1, 2500.50),
    (25, 2, 1800.75),
    (26, 1, 2200.25),
    (27, 1, 1500.00),
    (28, 2, 2000.75),
    (29, 1, 1700.50),
    (30, 1, 2100.25);

-- Insert data into Manutencoes table
INSERT INTO Manutencoes (id_aviao, data_inicio, data_fim)
VALUES
    (1, '2023-08-10', '2023-08-12'),
    (2, '2023-07-25', '2023-07-28'),
    (3, '2023-08-15', '2023-08-17'),
    (4, '2023-08-05', '2023-08-07'),
    (5, '2023-08-18', '2023-08-20'),
    (6, '2023-07-20', '2023-07-22'),
    (7, '2023-08-08', '2023-08-10'),
    (8, '2023-07-12', '2023-07-15'),
    (9, '2023-08-02', '2023-08-05'),
    (10, '2023-09-05', '2023-09-08'),
    (11, '2023-09-12', '2023-09-15'),
    (12, '2023-09-20', '2023-09-23'),
    (13, '2023-09-25', '2023-09-28'),
    (14, '2023-10-05', '2023-10-08'),
    (15, '2023-10-10', '2023-10-13'),
    (16, '2023-10-18', '2023-10-21'),
    (17, '2023-10-25', '2023-10-28'),
    (18, '2023-11-02', '2023-11-05'),
    (19, '2023-11-08', '2023-11-11'),
    (20, '2023-11-15', '2023-11-18'),
    (21, '2023-11-22', '2023-11-25'),
    (22, '2023-11-28', '2023-12-01'),
    (23, '2023-12-05', '2023-12-08'),
    (24, '2023-12-12', '2023-12-15'),
    (25, '2023-12-18', '2023-12-21'),
    (26, '2023-12-25', '2023-12-28'),
    (27, '2024-01-02', '2024-01-05'),
    (28, '2024-01-08', '2024-01-11'),
    (29, '2024-01-15', '2024-01-18'),
    (30, '2024-01-22', '2024-01-25');

-- Insert data into Reservas table
INSERT INTO Reservas (id_aviao, nome_cliente, data_inicio, data_fim)
VALUES
    (1, 'John Doe', '2023-09-01', '2023-09-05'),
    (2, 'Jane Smith', '2023-08-20', '2023-08-25'),
    (3, 'Michael Johnson', '2023-09-10', '2023-09-15'),
    (4, 'Emily Davis', '2023-08-12', '2023-08-15'),
    (5, 'Robert Williams', '2023-09-05', '2023-09-10'),
    (6, 'Sophia Brown', '2023-08-25', '2023-08-30'),
    (7, 'William Miller', '2023-09-15', '2023-09-20'),
    (8, 'Olivia Garcia', '2023-08-18', '2023-08-22'),
    (9, 'Noah Martinez', '2023-08-28', '2023-09-01'),
    (10, 'Emma Davis', '2023-09-10', '2023-09-14'),
    (11, 'Liam Wilson', '2023-09-20', '2023-09-25'),
    (12, 'Ava Johnson', '2023-10-02', '2023-10-06'),
    (13, 'Oliver Thomas', '2023-10-12', '2023-10-17'),
    (14, 'Isabella Smith', '2023-10-24', '2023-10-29'),
    (15, 'Sophia Martinez', '2023-11-05', '2023-11-10'),
    (16, 'Mia Brown', '2023-11-15', '2023-11-20'),
    (17, 'James Johnson', '2023-11-25', '2023-11-30'),
    (18, 'Alexander Garcia', '2023-12-05', '2023-12-10'),
    (19, 'Ethan Davis', '2023-12-15', '2023-12-20'),
    (20, 'Charlotte Wilson', '2023-12-25', '2023-12-30'),
    (21, 'Amelia Thomas', '2024-01-05', '2024-01-10'),
    (22, 'Harper Smith', '2024-01-15', '2024-01-20'),
    (23, 'Evelyn Martinez', '2024-01-25', '2024-01-30'),
    (24, 'Jackson Davis', '2024-02-05', '2024-02-10'),
    (25, 'Liam Wilson', '2024-02-15', '2024-02-20'),
    (26, 'Aiden Brown', '2024-02-25', '2024-03-01'),
    (27, 'Ella Garcia', '2024-03-05', '2024-03-10'),
    (28, 'Emma Thomas', '2024-03-15', '2024-03-20'),
    (29, 'Oliver Smith', '2024-03-25', '2024-03-30'),
    (30, 'Sophia Martinez', '2024-04-05', '2024-04-10');
