# Database Implementation

Instalamos DB Browser for SQLite para podermos criar a base de dados e adicionar/editar as tabelas

→ New Database

→Gravar o ficheiro na pasta Database do projeto

→Create Table

→Criar a tabela e defenir os campos pretendidos

→Insert Record

→Inserir dados nas tabelas

```csharp
//Right click na solution -> Manage NuGet Packages -> System.data.SQLite -> Install
//Na toolbox do designer vai passar a ter a tab Data

//no ficheiro form.cs importamos a library
using System.Data.Sqlite

//depois podemos ter por exemplo um evento de um button click para dar show dos campos da DB

Private void button_click(Object sender, EventArgs e)
{
	//Connection Object
	SQLiteConnection ligacaoDB = new SQLiteConnection(@"path\paraFicheiro\database.db");
	
	//(not sure if needed mas vi no stackoverflow a fazerem, abrir a connection à DB
	ligacaoDB.Open();
	
	//Command Object
	string query = "SELECT * FROM AVIOES";
	//criamos o objeto de comando onde enviamos como parametros o comando e o objeto de ligacao a base de dados
	SQLiteCommand nomedoComando = new SQLiteCommand(query, con);

	//Adapter
	//DataTable
	DataTable dt = new DataTable();
	SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
	adapter.Fill(dt);

	//datagrid view é um elemento do forms adicionado na tab data ao instalar o SQLite
	dataGridView1.DataSource = dt;
}

//se nao quisermos usar a DataGridView podemos iterar sobre o objeto DataTable 
//e ir buscar cada um dos campos da coluna

List<string> dataList = new List<string>();
foreach(DataRow row in dt.Rows)
{
	//aceder a colunas especificas
	string value = row["ColumnName"].ToString();
	
	//depois adicionamos o valor à lista
	dataList.Add(value);
}

//ou se quisermos ir buscar toda a informacao em cada linha em vez de irmos coluna a coluna

List<object[]> dataList = new List<object[]>();
foreach(DataRow row in dt.Rows)
{
	object[] rowValues = row.ItemArray; // item array é um metodo do DataRow
	dataList.Add(rowValues);
}

foreach(object[] row in dataList)
{
	Console.WriteLine(string.Join(",",row));
}

//também podiamos aceder individualmente aos dados
dataList[1][2] //vai ao objeto no index 1 (seria a 2 linha da tabela) e acede a 3 row

//ou se estivessemos a iterar num for

foreach(object[] row in dataList)
{
	Console.WriteLine(row[1]);
}
para mostrar campos especificos de cada linha
```


### Tables

O model de cada uma das classes é que lida com os inserts que sao para ser inseridos
EX a SQLiteDBContext.cs é onde tem as funcoes de insert, mas recebe parametros tipo as tabelas e isso que sao enviados a partir do model

- Table: Avioes
	- aviao_id (Primary Key)	modelo	capacidade_passageiros	autonomia_voo	data_ultima_manutencao	ativo	quantidade_motores	marca	ano_fabrico

- Table: Avionetas
	- aviao_id (Foreign Key, references Avioes)	area_minima_descolagem_pouso	valor_frete

- Table: AeronavesComerciais
	- aviao_id (Foreign Key, references Avioes)	numero_voos_diarios	companhia_aerea

- Table: AeronavesParticulares
	- aviao_id (Foreign Key, references Avioes)	numero_proprietarios	valor_frete

- Table: AeronavesMercadorias
	- aviao_id (Foreign Key, references Avioes)	capacidade_carga	valor_frete

- Table: Aeroportos
	- aeroporto_id (Primary Key)	localizacao	numero_pistas	capacidade_atendimento