
using System;

namespace Practica4
{

	public class Principal
	{
		static void Main (string [] args){
		
		string URL = "";
			Archivo file = new Archivo();
			file.setPath(URL);
			
			file.leer();
			Console.ReadKey();
		
		}
	}
}
