-- Cria o banco de dados LibraryUMC
CREATE DATABASE LibraryUMC;

-- Usa o banco de dados LibraryUMC
USE LibraryUMC;

-- Tabela Pessoa: representa uma pessoa física
CREATE TABLE pessoa (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT ((UUID())),
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(11) NOT NULL
);



-- Tabela Autor: representa um autor de livros
CREATE TABLE autor (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    biografia VARCHAR(500),
    genero_literario VARCHAR(100),
    is_active BOOLEAN NOT NULL,
    pessoa_id CHAR(36) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
);

-- Tabela Genero: representa um gênero literário de livros
CREATE TABLE genero (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    nome VARCHAR(100) NOT NULL,
    sigla VARCHAR(10) NOT NULL,
    is_active BOOLEAN NOT NULL
);

-- Tabela Livro: representa um livro
CREATE TABLE livro (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    isbn VARCHAR(13) NOT NULL,
    data_publicacao DATE NOT NULL,
    quantidade INT NOT NULL,
    genero_id CHAR(36) NOT NULL,
    FOREIGN KEY (genero_id) REFERENCES genero(id)
);

-- Tabela Estado: representa um estado da federação do Brasil
CREATE TABLE estado (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    CodigoUf INT          NOT NULL,
    Nome     VARCHAR (50) NOT NULL,
    Uf       CHAR     (2)  NOT NULL,
    Regiao   INT          NOT NULL,
    INDEX idx_estado_uf (Uf)
);

-- Tabela Municipio: representa um município do Brasil
CREATE TABLE municipio (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    Codigo INT          NOT NULL,
    Nome     VARCHAR(255) NOT NULL,
    uf_id    CHAR(2)      NOT NULL,
    FOREIGN KEY (uf_id) REFERENCES estado(Uf)
);


-- Tabela Endereco: representa um endereço postal
CREATE TABLE endereco (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    complemento VARCHAR(100),
    cep VARCHAR(10) NOT NULL,
    estado_id CHAR(36) NOT NULL,
    municipio_id CHAR(36) NOT NULL,
    FOREIGN KEY (estado_id) REFERENCES estado(id),
    FOREIGN KEY (municipio_id) REFERENCES municipio(id)
);

-- Tabela Perfil: representa um perfil de usuário
CREATE TABLE perfil (
    id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    nome VARCHAR(100) NOT NULL,
    sigla VARCHAR(10) NOT NULL,
    is_active BOOLEAN NOT NULL
);

-- Tabela Usuario: representa um usuário do sistema
CREATE TABLE usuario (
id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
email VARCHAR(100) NOT NULL,
telefone_fixo VARCHAR(20),
telefone_celular VARCHAR(20) NOT NULL,
ativo BOOLEAN NOT NULL,
endereco_id CHAR(36) NOT NULL,
pessoa_id CHAR(36) NOT NULL,
FOREIGN KEY (endereco_id) REFERENCES endereco(id),
FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
);
