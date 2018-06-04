using System;

namespace ExemploMediaDoAlunoComConfig
{
	public class Aluno
	{
		private string nome;
		private double p1, p2;
		private double mediaMinima = 6;

		public Aluno(string nome, double p1, double p2)
		{
			this.nome = nome;
			this.p1 = p1;
			this.p2 = p2;
		}

		public string GetNome()
		{
			return nome;
		}

		public void SetMediaMinima(double mediaMinima)
		{
			this.mediaMinima = mediaMinima;
		}

		public double GetMedia()
		{
			return (p1 + p2) / 2;
		}

		public bool Passou {
			get {
				return GetMedia() >= mediaMinima;
			}
		}
	}
}
