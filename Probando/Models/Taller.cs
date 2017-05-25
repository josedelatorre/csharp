using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando.Models
{
	class Taller
	{
		public List<Vehiculo> Vehiculos { get; set; }

		public Taller() {
			Vehiculos = new List<Vehiculo>();
		}
	}
}
