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
	   ('Ficção científica'),
	   ('Não ficção'),
	   ('Romance');

INSERT INTO Livro (IdAutor, IdCategoria, Titulo, Sinopse, dataPubli, Preco)
VALUES (1, 1,  'O Gato Preto', 'Poe conta a história de um homem que, movido pelo abuso de álcool e transtornado pelo amor 
incondicional que um bicho pode dedicar a seu dono, acaba por enforcar seu próprio gato de estimação. ...
Edgar Allan Poe nasceu em 19 de janeiro de 1809 em Boston, Massachusetts.', '1843', 44.20),

	   (1, 1, 'O Coração Revelador', 'Sinopse. " The Tell- Tale Heart " ou "O Coração Revelador" é um conto de Edgar Allan
	   Poe publicado pela primeira vez em 1843. Ele é contado por um narrador sem nome que se esforça para convencer o leitor
	   de sua sanidade mental , ao descrever um assassinato que ele cometeu .', '1953', 37.00),

	   (2, 2, 'Admirável Mundo Novo', 'Admirável Mundo Novo é um romance escrito por Aldous Huxley e publicado em 1932. A história
	   se passa em Londres no ano 2540, o romance antecipa desenvolvimentos em tecnologia reprodutiva, hipnopedia, manipulação
	   psicológica e condicionamento clássico, que se combinam para mudar profundamente a sociedade.', '1932', 21.69),

	   (2, 3, 'As Portas da Percepção', 'Aldous Huxley em seu livro As portas da percepção relata a sua experiência sob a influência
	   de uma droga muito comum nas décadas de 1940 e 1960, a mescalina. ... Em uma narrativa fluida, Huxley descreve a sua visão
		de mundo após interferir nessa seletividade a qual o cérebro em seu estado basal está acostumado a funcionar.', '1954', 32.29),

	   (3, 4, 'Dom Casmurro', 'Dom Casmurro conta a história de Bento Santiago (Bentinho), apelidado de Dom Casmurro por ser calado e
	   introvertido. Na adolescência, apaixona-se por Capítu, abandonando o seminário e, com ele, os desígnios traçados por sua mãe,
	   Dona Glória, para que se tornasse padre.', '1899', 50.20),

	   (3, 4, 'Memórias Póstumas de Brás Cubas', 'Após ter morrido, em pleno ano de 1869, Brás Cubas decide por narrar sua história e
	   revisitar os fatos mais importantes de sua vida, a fim de se distrair na eternidade. A partir de então ele relembra de amigos
	   como Quincas Borba, de sua displicente formação acadêmica em Portugal.', '1869', 47.20);

INSERT INTO Instituicao(Nome, Endereco)
VALUES ('Biblioteca de São Paulo', ' Av. Cruzeiro do Sul, 2630 - Santana, São Paulo - SP');


