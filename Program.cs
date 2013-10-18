using System;
using System.IO;

namespace Practica4
{
	public class Programa
	{

		public Programa ()
		{
		}

		public void leerArchivo (string ruta)
		{
			string entrar;
			Console.Clear ();

			if (Path.GetExtension (ruta) == ".txt") {

				try {
					StreamReader archivo = new StreamReader (ruta);

					entrar = archivo.ReadToEnd ();
						
					String [] array = entrar.Split ('\n');

					for (int i=0; i<array.Length; i++) {
						string[] metodo = array [i].Split (',');
						datos obcion = new datos ();
                                              Console.WriteLine ("----------------");
						obcion.id = metodo [0];
						obcion.nombre = metodo [1];
						obcion.domicilio = metodo [2];
						obcion.telefono = metodo [3];

						obcion.imprimir ();
						Console.WriteLine ("----------------");
					}

					archivo.Close ();

				} catch (FileNotFoundException ){
						Console.WriteLine(" No existe el archivo error");
				}
				catch (Exception ){};
			
			} else 
				Console.WriteLine("La extension del archivo no es:");
			Console.ReadKey(true);

		}
			
		
	}
}

