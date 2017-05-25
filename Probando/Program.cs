using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probando.Models;

namespace Probando
{
	class Program
	{
		static void Main(string[] args)
		{
			var v = new Coche("Pepe", "123", "Rojo", "Peugeot", 1);
			var t = new Taller();

			t.Vehiculos.Add(v);
			t.Vehiculos.Add(new Coche("Pepe", "456", "Verde", "Citroen", 0));
			t.Vehiculos.Add(new Coche("Pepe", "689", "Rojo", "BMW", 0));
			t.Vehiculos.Add(new Coche("Pepe", "4543", "Rojo", "Toyotita", 0));
			t.Vehiculos.Add(new Coche("Pepe", "6756", "Azul", "Hyundai", 0));

			//LINQ ROCKS
			var consultaLinq = from veh in t.Vehiculos
							   where veh.Marca == "Peugeot"
							   select veh;

			foreach (var veh in consultaLinq)
			{
				Console.WriteLine(veh.Matricula);
			}

			var vehi = t.Vehiculos.FirstOrDefault(pepe => pepe.Color == "Azul");

			//LAMBDA ROCKS
			var consultaLambda = t.Vehiculos.FindAll(x => x.Marca == "Peugeot");

			foreach (var veh in consultaLambda) {
				Console.WriteLine(veh.Matricula);
			}

			Console.ReadLine();
		}
	}
}
