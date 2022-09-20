using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_curso.Models
{
    public class Curso
    {
        public string? Nome { get; set; }
        
        public List<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunos(){
            return Alunos.Count;
        }
        
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos inscritos no curso de {Nome}:");
            for(int i =0; i < Alunos.Count(); i ++){
                string texto = $"Nº {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);

            }
        }
    }
}