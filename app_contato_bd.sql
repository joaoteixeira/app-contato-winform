DROP DATABASE app_contato_bd;
CREATE DATABASE app_contato_bd;
USE app_contato_bd;

CREATE TABLE contato_con (
	id_con INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome_con VARCHAR(100) NOT NULL,
    data_nasc_con DATE NULL,
    sexo_con VARCHAR(30)  NULL,
    email_con VARCHAR(100)  NULL,
    telefone_con VARCHAR(20) NULL
);

insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (1, 'Susanne Hatto', '2017-05-13', 'Female', 'shatto0@epa.gov', '(318) 9614863');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (2, 'Lonnie Narducci', '2010-02-12', 'Male', 'lnarducci1@com.com', '(782) 5734563');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (3, 'Farlee Seally', '2014-09-15', 'Male', 'fseally2@umich.edu', '(699) 1027979');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (4, 'Tobe Doggett', '2014-04-17', 'Genderfluid', 'tdoggett3@printfriendly.com', '(265) 4196543');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (5, 'Lars La Padula', '2011-04-07', 'Male', 'lla4@foxnews.com', '(278) 6076691');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (6, 'Katherina Quixley', '2016-07-18', 'Female', 'kquixley5@yellowbook.com', '(382) 9971783');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (7, 'Sutherlan London', '2011-12-02', 'Male', 'slondon6@creativecommons.org', '(833) 9026718');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (8, 'Bernadina Frankel', '2018-07-25', 'Female', 'bfrankel7@globo.com', '(392) 8467386');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (9, 'Colette McGreay', '2012-01-01', 'Female', 'cmcgreay8@opensource.org', '(704) 8957080');
insert into contato_con (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (10, 'Riley Baraja', '2011-10-30', 'Male', 'rbaraja9@businessinsider.com', '(115) 1449137');

SELECT * FROM contato_con;