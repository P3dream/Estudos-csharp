using Projeto_curso.Models;

Pessoa p1 = new Pessoa(nome:"Pedro",sobrenome:"Pizzi");
Pessoa p2 = new Pessoa(nome:"Lucas",sobrenome:"Silva");

Curso curso = new Curso();
curso.Nome = "Francês";
curso.Alunos = new List<Pessoa>();
curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.ListarAlunos();