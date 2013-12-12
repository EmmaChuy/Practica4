using System.IO;
using System;

namespace Practica4
{

	public class Archivo
	{
		public Archivo(){}//constructor
	private string path;
	
	public Archivo(String path)
	{
	this.path = path;
	
	}
	public void setPath(String path)
	{
	
		Console.Write("Dame la URL del Archivo");
		path = Console.ReadLine();
		
		this.path = path;
	}
	public void leer()
	{
	
	String linea;

	try{

	//Se indica el archivo a leer
	StreamReader lector = new StreamReader(this.path);
	
	//lee la primera linea del archivo
	linea = lector.ReadLine();
	//continua leyendo hasta que se termina el archivo
	while (linea != null){
	
	//Escribe la linea en la consola
	Console.WriteLine(linea);
	//lee la siguiente linea 
	linea  = lector.ReadLine();
	
	}
	//cierra el lector 
	lector.Close();
	Console.ReadLine();
		}


catch(FileNotFoundException )
{

	Console.WriteLine("El Archivo no existe!!");	

}

	finally
	{
		Console.WriteLine("Cerrando la  lectura");
	}
	}
	public void escribir (String [] contenido){
	
		try{
		
		//se indica el archivo a leer
		StreamWriter escritor = new StreamWriter(this.path);
		
		foreach(String linea in contenido){
			
			//Escriba una linea
			escritor.WriteLine(linea);
		
		}
		//Cierra el escritor
		escritor.Close();
		
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: "+e.Message);
		
		}
		finally
		{
			Console.WriteLine("Cerrando la Escritura");
		}
	  }
	}
}
