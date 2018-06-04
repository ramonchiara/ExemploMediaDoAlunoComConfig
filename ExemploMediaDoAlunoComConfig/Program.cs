using System;

namespace ExemploMediaDoAlunoComConfig
{
	class Program
	{
		public static void Main(string[] args)
		{
			Aluno aluno1 = new Aluno("Alice", 7, 7);
			Aluno aluno2 = new Aluno("Bruno", 6, 6);
			Aluno aluno3 = new Aluno("Clara", 5, 5);

			aluno1.SetMediaMinima(5);

			Console.WriteLine("{0} {1}", aluno1.GetNome(), aluno1.Passou ? "passou" : "não passou");
			Console.WriteLine("{0} {1}", aluno2.GetNome(), aluno2.Passou ? "passou" : "não passou");
			Console.WriteLine("{0} {1}", aluno3.GetNome(), aluno3.Passou ? "passou" : "não passou");
		}
	}
}
