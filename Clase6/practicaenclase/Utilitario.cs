using System;

namespace practicaenclase
{
	public class Utilitario : Auto
	{
		private int capacidad;
		
		public Utilitario(string marca, string modelo, int capacidad) : base(marca,modelo)  // El comando base(marca,modelo) utiliza los datos marca y modelo de la clase Auto
		{
			this.capacidad=capacidad;
		}
		
		override public void imprimir()
	{
		Console.WriteLine("El vehículo utilitario es de la marca {0}, modelo {1} y tiene una capacidad de carga de {2} Kg.",marca,modelo,capacidad);
	}
		override public void acelerar(double vel)
		{
			Console.WriteLine("El utilitario aceleró a {0}.",vel);
		}
	}
}
