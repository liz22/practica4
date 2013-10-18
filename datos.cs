using System;

namespace Practica4
{
	public class datos
	{
		public string id;
		public string nombre;
		public string domicilio;
		public string telefono;

		public datos ()
		{
		}

		public void imprimir(){
			Console.Write("Id: ");
			Console.WriteLine(this.id);
			Console.Write("Nombre: ");
			Console.WriteLine(this.nombre);
			Console.Write("Domicilio: ");
			Console.WriteLine(this.domicilio);
			Console.Write("Telefono: ");
			Console.WriteLine(this.telefono);
		}
	}
}

