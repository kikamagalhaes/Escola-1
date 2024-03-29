﻿class Program
{
  
    static void Main(string[] args)
    {
        var alunos = new List<Aluno>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Por favor digite uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar aluno");
            Console.WriteLine("3 - Sair");
            int opcao = 0;
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    cadastrarAluno(alunos);
                    break;
                case 2:
                    listarAlunos(alunos);
                    break ;
                case 3:
                    return;
                default:
                    Console.Clear() ;
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(2000);
                    break;
            }
        }

        

        
    }

    private static void listarAlunos(List<Aluno> alunos)
    {

        Console.Clear();

        foreach (var aluno in alunos)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Matrícula: " + aluno.Matricula);
            Console.WriteLine("Notas: " + aluno.NotasFormatada());
            Console.WriteLine("Média: " + aluno.Media().ToString("#.##"));
            Console.WriteLine("Situação: " + aluno.Situacao());
            Console.WriteLine("---------------------------------------------------");
        }

        Thread.Sleep(5000);
    }

    private static void cadastrarAluno(List<Aluno> alunos)
    {
        var aluno = new Aluno();
        Console.Clear();
        Console.WriteLine("Digite o nome do aluno");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Digite a matrícula do aluno");
        aluno.Matricula = Console.ReadLine();

        Console.WriteLine("Digite as notas do aluno, separadas por vírgola");
        var sNotas = Console.ReadLine();

        var sArrayNotas = sNotas.Split(',');
        var listaNotas = new List<double>();
        foreach(var sNota in sArrayNotas)
        {
            double nota = 0;
            double.TryParse(sNota, out nota);
            listaNotas.Add(nota);
        }

        aluno.Notas = listaNotas;
        alunos.Add(aluno);

        Console.Clear();
        Console.WriteLine("Aluno cadastrado com sucesso!");
        Thread.Sleep(2000);
    }

}