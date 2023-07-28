CREATE TABLE Socio(
codigo INT IDENTITY (1,1),
nomeCompleto VARCHAR(200) NOT NULL,
email VARCHAR(200) NOT NULL,
cpf CHAR(11) NOT NULL,
senha VARCHAR(32) NOT NULL,
ehAtivo BIT NOT NULL,
telefone1 CHAR (12) NOT NULL,
telefone2 CHAR (12), 
dataNascimento DATE NOT NULL,
PRIMARY KEY (codigo),
	CONSTRAINT UK_cpf
UNIQUE (cpf)
)



CREATE TABLE Ano(
codigo INT IDENTITY(1,1),
numero SMALLINT NOT NULL,
PRIMARY KEY (codigo)
)

CREATE TABLE Mes(
codigo INT IDENTITY (1,1),
codigoAno INT NOT NULL,
numero TINYINT NOT NULL,
PRIMARY KEY (codigo),
	CONSTRAINT FK_Ano_Mes
FOREIGN KEY (codigoAno)
	REFERENCES Ano(codigo)
)

CREATE TABLE Modalidade(
codigo INT IDENTITY (1,1),
nome VARCHAR (50) NOT NULL,
PRIMARY KEY (codigo)
)




CREATE TABLE Dependente(
codigo INT IDENTITY (1,1),
codigoSocio INT NOT NULL,
nomeCompleto VARCHAR (150) NOT NULL,
email VARCHAR (150) NOT NULL,
cpf CHAR (11) NOT NULL,
senha VARCHAR (32) NOT NULL,
dataNascimento DATE NOT NULL,
telefone1 CHAR (12) NOT NULL,
telefone2 CHAR (12),
parentesco varchar (30) NOT NULL,
PRIMARY KEY (codigo),
	CONSTRAINT FK_codigoSocio_Dependente_Dependente 
FOREIGN KEY (codigoSocio) 
	REFERENCES Socio(codigo),

	
)
	-- Data vencimento e data pagamento --- se data estiver com vencimento sem sair impressao 
CREATE TABLE Fatura(
codigo INT IDENTITY (1,1),
dataVencimento DATETIME NOT NULL,
dataPagamento DATETIME, 
estahPago BIT NOT NULL,
codigoMes INT NOT NULL,
codigoSocio INT NOT NULL,
valor MONEY NOT NULL,
PRIMARY KEY (codigo),
	CONSTRAINT FK_codigoSocio_Fatura 
FOREIGN KEY (codigoSocio) 
REFERENCES Socio(codigo),
	CONSTRAINT FK_codigoMes_Fatura
FOREIGN KEY (codigoMes)
	REFERENCES Mes(codigo)
)


CREATE TABLE Evento(
codigo INT IDENTITY (1,1),
dataHoraInicio DATETIME NOT NULL,
dataHoraTermino DATETIME NOT NULL,
nome VARCHAR (50) NOT NULL, 
descricao TEXT NOT NULL,
codigoModalidade INT NOT NULL,
PRIMARY KEY (codigo),
	CONSTRAINT FK_codigoModalidade_Evento
FOREIGN KEY (codigoModalidade)
	REFERENCES Modalidade (codigo)
)


CREATE TABLE ModalidadeEvento(
codigoEvento INT NOT NULL,
codigoModalidade INT NOT NULL,
PRIMARY KEY (codigoEvento,codigoModalidade),
	CONSTRAINT FK_codigoEvento_ModalidadeEvento
	FOREIGN KEY (codigoEvento)
	REFERENCES Evento (codigo),
CONSTRAINT FK_codigoMolidade_ModalidadeEvento
	FOREIGN KEY (codigoModalidade)
	REFERENCES Modalidade (codigo)
)



CREATE TABLE PresencaEvento(
codigo INT IDENTITY (1,1),
codigoEvento INT NOT NULL,
codigoSocio INT NOT NULL,
confirmou BIT NOT NULL,
PRIMARY KEY (codigo),
    CONSTRAINT FK_CodigoEvento_PresencaEvento
FOREIGN KEY (codigoEvento)
    REFERENCES Evento(codigo),
    CONSTRAINT FK_CodigoSocio_PresencaEvento
FOREIGN KEY (codigoSocio)
    REFERENCES Socio (codigo)
)


CREATE TABLE Exame(
codigo INT IDENTITY (1,1),
codigoSocio INT NOT NULL,
dataExame DATE NOT NULL,
jaFez BIT NOT NULL,
PRIMARY KEY (codigo),
    CONSTRAINT FK_codigoSocio_Exame
FOREIGN KEY (codigoSocio)
	REFERENCES Socio(codigo),
)

---Dependente 
---Socio


insert into Socio(nomeCompleto, email, cpf, senha, ehAtivo, telefone1, dataNascimento)
            values('italo', 'italosilva@gmail.com', '11122233344', 'palmeira', 1, '4799262869', '2001-09-03')

			INSERT INTO Dependente (nomeCompleto, email, cpf, dataNascimento, telefone1, telefone2, senha, codigoSocio, Parentesco)
VALUES ('Maria Carolina', 'mariacarolina@gmail.com', '09876543210','1995-05-28','47984546372','47996523452','maria123', 1, 'Mãe' )

INSERT INTO Dependente (nomeCompleto, email, cpf, dataNascimento, telefone1, telefone2, senha, codigoSocio, Parentesco)
    VALUES('Pedro Hoffmann', 'pedrohoffmann@gmail.com', '09678493456','2015-11-27','47984765430','47998761232','pedrinho32', 1, 'Filho')

INSERT INTO Dependente (nomeCompleto, email, cpf, dataNascimento, telefone1, telefone2, senha, codigoSocio, Parentesco)
  VALUES('Antônio Hoffmann', 'antoniohoffmann@gmail.com', '08895641238','1995-08-05','47987435672','47985432098','123123', 1, 'Pai')


  select* from Dependente
  select* from Socio

  SELECT* FROM Evento
  SELECT* FROM Modalidade


  INSERT INTO Modalidade (nome) VALUES ('social'),('esportiva')

  INSERT INTO Evento(dataHoraInicio, dataHoraTermino,nome, descricao,codigoModalidade) 
			VALUES('2023-09-09 08:00:00', '2023-09-09 17:00:00','Campeonato Juvenil de Vôlei','Campeonato de basquete para adolescentes com idades entre 12 e 18 anos',2)
INSERT INTO Evento(dataHoraInicio, dataHoraTermino,nome, descricao,codigoModalidade) 
			VALUES('2023-08-12 08:00:00', '2023-08-12','Campeonato Infantil de Futsal','Campeonato de futsal para crianças com idades entre 5 e 12 anos',2)



