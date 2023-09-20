using System;

namespace practicaenclase
{
	public class MovilPolicial : Auto  // La subclase MovilPolicial hereda los atributos y métodos de la superclase Auto
	{
		private int numeromovil;  // La declaro como privado ya que es subclase
		
		public MovilPolicial(string marca, string modelo, int numeromovil) : base(marca,modelo)  // El comando base(marca,modelo) utiliza los datos marca y modelo de la clase Auto
		{
			this.numeromovil=numeromovil;
		}
		
		public void encenderSirena()
		{
			Console.WriteLine("El móvil {0} encendió las sirenas.",numeromovil);
		}
		public void apagarSirena()
		{
			Console.WriteLine("El móvil {0} apagó las sirenas.",numeromovil);
		}
		
		override public void imprimir()
	{
		Console.WriteLine("El vehículo policial es de la marca {0}, modelo {1}, número de móvil {2}",marca,modelo,numeromovil);
	}
		override public void acelerar(double vel)
		{
			Console.WriteLine("El móvil aceleró a {0}.",vel);
		}
	}
}
