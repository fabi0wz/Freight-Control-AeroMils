CREATE TABLE Avioes (
    id_aviao INTEGER PRIMARY KEY AUTOINCREMENT,
    modelo VARCHAR(45) NOT NULL,
    capacidade_passageiros INTEGER NOT NULL,
    autonomia INTEGER NOT NULL,
    data_ult_manutencao DATE NOT NULL,
    tipo_aviao VARCHAR(45) NOT NULL,
    estado BOOLEAN NOT NULL,
    marca VARCHAR(45) NOT NULL,
    ano_fabrico DATE NOT NULL,
    qtd_motores INTEGER NOT NULL
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
    companhia_aerea TEXT NOT NULL,
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

INSERT INTO Avioes (modelo, capacidade_passageiros, autonomia, data_ult_manutencao, tipo_aviao, estado, marca, ano_fabrico, qtd_motores)
VALUES
    ('Boeing 747', 416, 7240, '2023-08-01', 'AeronaveComercial', 1, 'Boeing', '2018-01-01', 4),
    ('Airbus A320', 180, 3450, '2023-07-15', 'AeronaveComercial', 0, 'Airbus', '2020-03-01', 2),
    ('Cessna Citation X', 8, 3400, '2023-06-10', 'AeronaveParticular', 1, 'Cessna', '2019-05-01', 2),
    ('Piper PA-28 Cherokee', 4, 450, '2023-05-01', 'Avioneta', 0, 'Piper', '2022-10-01', 1),
    ('Embraer E190', 106, 2500, '2023-04-20', 'AeronaveComercial', 1, 'Embraer', '2021-11-01', 2),
    ('Beechcraft King Air 350', 9, 1730, '2023-03-15', 'AeronaveParticular', 1, 'Beechcraft', '2018-07-01', 2),
    ('Cessna 208 Caravan', 13, 850, '2023-02-10', 'AeronaveMercadorias', 0, 'Cessna', '2020-09-01', 1),
    ('Cirrus SR22', 4, 1000, '2023-01-05', 'AeronaveParticular', 1, 'Cirrus', '2019-04-01', 1),
    ('Gulfstream G650', 19, 7000, '2022-12-01', 'AeronaveParticular', 1, 'Gulfstream', '2017-02-01', 2),
    ('Diamond DA40', 4, 600, '2022-11-01', 'Avioneta', 0, 'Diamond Aircraft', '2021-03-01', 1),
    ('Airbus A380', 853, 8100, '2022-08-05', 'AeronaveComercial', 1, 'Airbus', '2015-06-01', 4),
    ('Embraer Phenom 300', 11, 1970, '2022-07-20', 'AeronaveParticular', 0, 'Embraer', '2020-12-01', 2),
    ('Pilatus PC-12', 9, 1600, '2022-06-15', 'AeronaveMercadorias', 1, 'Pilatus', '2019-09-01', 1),
    ('Bombardier Learjet 75', 9, 2300, '2022-05-10', 'AeronaveParticular', 1, 'Bombardier', '2018-04-01', 2),
    ('Cessna 152', 2, 380, '2022-04-05', 'Avioneta', 0, 'Cessna', '2021-08-01', 1),
    ('Boeing 737', 189, 3500, '2023-08-15', 'AeronaveComercial', 1, 'Boeing', '2020-01-01', 2),
    ('Airbus A330', 440, 5900, '2023-07-20', 'AeronaveComercial', 0, 'Airbus', '2019-03-01', 2),
    ('Pilatus PC-24', 11, 2120, '2023-06-25', 'AeronaveParticular', 1, 'Pilatus', '2021-05-01', 2),
    ('Cirrus Vision Jet SF50', 5, 1200, '2023-05-30', 'AeronaveParticular', 1, 'Cirrus', '2022-02-01', 1),
    ('Beechcraft Baron G58', 6, 2000, '2023-05-01', 'AeronaveParticular', 1, 'Beechcraft', '2021-10-01', 2),
    ('Cessna Citation M2', 6, 1550, '2023-04-15', 'AeronaveParticular', 1, 'Cessna', '2020-08-01', 2),
    ('Piper M350', 6, 1325, '2023-04-01', 'AeronaveParticular', 0, 'Piper', '2019-12-01', 1),
    ('Embraer Legacy 500', 12, 3330, '2023-03-15', 'AeronaveParticular', 1, 'Embraer', '2018-06-01', 2),
    ('Cessna 421 Golden Eagle', 8, 1700, '2023-03-01', 'AeronaveParticular', 0, 'Cessna', '2017-01-01', 2),
    ('Beechcraft King Air 260', 9, 1700, '2023-02-15', 'AeronaveParticular', 1, 'Beechcraft', '2020-03-01', 2),
    ('Dassault Falcon 2000', 19, 3500, '2022-08-20', 'AeronaveParticular', 1, 'Dassault', '2019-07-01', 2),
    ('Cessna 208B Grand Caravan EX', 14, 1180, '2022-08-05', 'AeronaveMercadorias', 0, 'Cessna', '2018-02-01', 1),
    ('Embraer E195-E2', 146, 2600, '2022-07-20', 'AeronaveComercial', 1, 'Embraer', '2021-04-01', 2),
    ('Cessna T206H Stationair', 6, 800, '2022-07-05', 'AeronaveParticular', 1, 'Cessna', '2020-10-01', 1),
    ('Gulfstream G550', 18, 6750, '2022-06-20', 'AeronaveParticular', 1, 'Gulfstream', '2019-09-01', 2);

-- Insert data into Avionetas table
INSERT INTO Avionetas (id_aviao, area_minima_descolagem, valor_frete)
VALUES
    (4, 150, 2000.00),
    (10, 100, 800.00),
    (15, 80, 600.00);


-- Insert data into AeronavesMercadorias table
INSERT INTO AeronavesMercadorias (id_aviao, capacidade_carga, valor_frete)
VALUES
    (7, 5000, 1200.00),
    (13, 2500, 800.00),
    (27, 3500, 1500.00);


-- Insert data into AeronavesComerciais table
INSERT INTO AeronavesComerciais (id_aviao, num_voos_diarios, companhia_aerea)
VALUES
    (1, 10, 'Delta Airlines'),
    (2, 8, 'American Airlines'),
    (5, 12, 'Lufthansa'),
    (11, 9, 'British Airways'),
    (16, 7, 'Air France'),
    (17, 11, 'Qatar Airways'),
    (28, 5, 'Singapore Airlines');


-- Insert data into AeronavesParticulares table
INSERT INTO AeronavesParticulares (id_aviao, num_proprietarios, valor_frete)
VALUES
    (3, 2, 2500.00),
    (6, 1, 1800.00),
    (8, 3, 3000.00),
    (9, 2, 2200.00),
    (12, 1, 2800.00),
    (14, 2, 3200.00),
    (18, 1, 2000.00),
    (19, 3, 2700.00),
    (20, 2, 2300.00),
    (21, 1, 2900.00),
    (22, 2, 2600.00),
    (23, 1, 2100.00),
    (24, 3, 3100.00),
    (25, 2, 2400.00),
    (26, 1, 2700.00),
    (29, 2, 2200.00),
    (30, 1, 2500.00);


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
