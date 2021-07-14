USE czbooks;
GO

INSERT INTO TiposUsuario (Tipo)
VALUES ('Administrador'),
	   ('Autor'),
	   ('Cliente');

INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES (1, 'adm@adm.com', 'adm123'),
	   (2, 'edgar@gmail.com', 'edgar123'),
	   (2, 'adouls@gmail.com', 'adouls123'),
	   (2, 'machado@gmail.com', 'machado123'),
	   (3, 'lucas@gmail.com', 'lucas123'),
	   (3, 'vitor@gmail.com', 'vitor123'),
	   (3, 'maria@gmail.com', 'maria123');

INSERT INTO Autor(Nome)
VALUES ('Edgar Allan Poe'),
	   ('Aldous Huxley'),
	   ('Machado de Assis');

INSERT INTO Categoria(Nome)
VALUES ('Terror'),
	   ('Fic��o cient�fica'),
	   ('N�o fic��o'),
	   ('Romance');

INSERT INTO Livro (IdAutor, IdCategoria, Titulo, Sinopse, dataPubli, Preco)
VALUES (1, 1,  'O Gato Preto', 'Poe conta a hist�ria de um homem que, movido pelo abuso de �lcool e transtornado pelo amor 
incondicional que um bicho pode dedicar a seu dono, acaba por enforcar seu pr�prio gato de estima��o. ...
Edgar Allan Poe nasceu em 19 de janeiro de 1809 em Boston, Massachusetts.', '1843', 44.20),

	   (1, 1, 'O Cora��o Revelador', 'Sinopse. " The Tell- Tale Heart " ou "O Cora��o Revelador" � um conto de Edgar Allan
	   Poe publicado pela primeira vez em 1843. Ele � contado por um narrador sem nome que se esfor�a para convencer o leitor
	   de sua sanidade mental , ao descrever um assassinato que ele cometeu .', '1953', 37.00),

	   (2, 2, 'Admir�vel Mundo Novo', 'Admir�vel Mundo Novo � um romance escrito por Aldous Huxley e publicado em 1932. A hist�ria
	   se passa em Londres no ano 2540, o romance antecipa desenvolvimentos em tecnologia reprodutiva, hipnopedia, manipula��o
	   psicol�gica e condicionamento cl�ssico, que se combinam para mudar profundamente a sociedade.', '1932', 21.69),

	   (2, 3, 'As Portas da Percep��o', 'Aldous Huxley em seu livro As portas da percep��o relata a sua experi�ncia sob a influ�ncia
	   de uma droga muito comum nas d�cadas de 1940 e 1960, a mescalina. ... Em uma narrativa fluida, Huxley descreve a sua vis�o
		de mundo ap�s interferir nessa seletividade a qual o c�rebro em seu estado basal est� acostumado a funcionar.', '1954', 32.29),

	   (3, 4, 'Dom Casmurro', 'Dom Casmurro conta a hist�ria de Bento Santiago (Bentinho), apelidado de Dom Casmurro por ser calado e
	   introvertido. Na adolesc�ncia, apaixona-se por Cap�tu, abandonando o semin�rio e, com ele, os des�gnios tra�ados por sua m�e,
	   Dona Gl�ria, para que se tornasse padre.', '1899', 50.20),

	   (3, 4, 'Mem�rias P�stumas de Br�s Cubas', 'Ap�s ter morrido, em pleno ano de 1869, Br�s Cubas decide por narrar sua hist�ria e
	   revisitar os fatos mais importantes de sua vida, a fim de se distrair na eternidade. A partir de ent�o ele relembra de amigos
	   como Quincas Borba, de sua displicente forma��o acad�mica em Portugal.', '1869', 47.20);

INSERT INTO Instituicao(Nome, Endereco)
VALUES ('Biblioteca de S�o Paulo', ' Av. Cruzeiro do Sul, 2630 - Santana, S�o Paulo - SP');


