using System;

namespace practicaenclase
{
	public class Convencional : Auto
	{
		private string nombre;
		
		public Convencional(string marca, string modelo, string nombre) : base(marca,modelo)
		{
			this.nombre=nombre;
		}
		
		override public void imprimir()
	{
		Console.WriteLine("El vehículo es de la marca {0}, modelo {1} y su nombre es {2}",marca,modelo,nombre);
	}
		override public void acelerar(double vel)
		{
			Console.WriteLine("El auto convencional aceleró a {0}.",vel);
		}
	}
}
