using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando.Models
{
	class Coche : Vehiculo
	{
		public Coche(string modelo, string matricula, string color, string marca, double velocidad) : base(modelo, matricula, color, marca, velocidad)
		{
		}

		public override double Acelerar(double velocidadAumentada)
		{
			Velocidad += velocidadAumentada*2;
			return Velocidad;
		}

		public override void Arrancar()
		{
			Console.WriteLine("Rum rum...");
		}

		public override void Pitar()
		{
			Console.WriteLine("Pi Pi!");
		}
	}
}
