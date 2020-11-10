CREATE TABLE Pessoas (
    [Id]             INT        NOT NULL	PRIMARY KEY IDENTITY (1,1),
    [nome]           TEXT       NOT NULL,
    [telefone]       INT        NULL,
    [celular]        INT        NULL,
    [endereco]       TEXT       NOT NULL,
    [divida]         FLOAT (53) NOT NULL,
    [parcelas]       INT        NULL,
    [parcelas_pagas] INT        NULL,
    [observacao]     TEXT       NOT NULL,
)