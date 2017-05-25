using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando.Models
{
	abstract class Vehiculo : Arrancable
	{
		public string Modelo { get; set; }
		public string Matricula { get; set; }
		public string Color { get; set; }
		public string Marca { get; set; }
		public double Velocidad { get; set;  }

		public Vehiculo(string modelo, string matricula, string color, string marca, double velocidad)
		{
			Modelo = modelo;
			Matricula = matricula;
			Color = color;
			Marca = marca;
			Velocidad = velocidad;
		}

		public virtual double Acelerar(double velocidadAumentada) {
			Velocidad += velocidadAumentada;
			return Velocidad;
		}

		abstract public void Pitar();
		public abstract void Arrancar();
	}
}
