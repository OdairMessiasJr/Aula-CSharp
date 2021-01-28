using System;

namespace Revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            //todo: adicionar aluno
            Console.WriteLine("Informe o Nome do Aluno:");

            var aluno = new Aluno();

            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do Aluno:");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("Valor da nota deve ser decimal:");
            }
            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;

          case "2":
            //todo: listar alunos
            foreach (var a in alunos)
            {
              Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
            }
            break;

          case "3":
            //todo: calcular media geral

            break;
          default:
            throw new ArgumentOutOfRangeException();
        }


        opcaoUsuario = ObterOpcaoUsuario();

      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine("Informe a opção desejada");
      Console.WriteLine("1- Inserir novo Aluno");
      Console.WriteLine("2- Listar Alunos");
      Console.WriteLine("3- Calcular média Geral");
      Console.WriteLine("X- Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}
