using System;
using System.IO;

namespace Practica4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Programa ob = new Programa();
			string ruta;

			Console.WriteLine("Ingrese la ruta del archivo: ");
			ruta=Console.ReadLine();

			ob.leerArchivo(Path.GetFullPath(ruta));
		}
	}
}
