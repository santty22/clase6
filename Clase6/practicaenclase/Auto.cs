using System;

namespace practicaenclase
{
	abstract public class Auto
	{
		protected string marca;
		protected string modelo;
	public Auto(string marca, string modelo)
		{	
			this.marca = marca;
			this.modelo = modelo;
		}
	public string Marca
	{
		set{
			this.marca=value;
		}
		get{
			return marca;
		}
	}
	abstract public void imprimir();
	//{
	//	Console.WriteLine("El vehículo es de la marca {0}, modelo {1}.",marca,modelo);
	//}
	abstract public void acelerar(double vel);
	}
}
