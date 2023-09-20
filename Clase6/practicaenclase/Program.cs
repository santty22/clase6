using System;

namespace practicaenclase
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Auto a1= new Auto("Ford","2005");   // Ahora que la clase Auto es abstracta, no se permite crear una instancia dentro de esta clase
			MovilPolicial pol1= new MovilPolicial("Chevrolet","2010",47);
			
			// a1.imprimir();
			pol1.imprimir();
			pol1.encenderSirena();
			
			Convencional a1= new Convencional("Ford","2005","Ecosport");
			a1.imprimir();
			a1.acelerar(62.5);
			
			Console.ReadKey(true);
		}
	}
}