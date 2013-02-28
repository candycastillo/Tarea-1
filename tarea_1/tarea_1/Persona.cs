using System;

namespace tarea_1
{
	public class Persona
	{
		public Persona ()
		{
		}
	
	    public string nombre;
		public string telefono;
		public string direccion;
		public string e_mail; 
		
            public static void Main(string[] args){

			Persona datos = new Persona (); 

			Console.WriteLine ("Ingresa tu nombre");
			datos.nombre = Console.ReadLine (); 

			Console.WriteLine ("Ingresa tu telefono");
			datos.telefono = Console.ReadLine (); 

			Console.WriteLine ("Ingresa tu direccion");
			datos.direccion = Console.ReadLine (); 

			Console.WriteLine ("Ingresa tu correo electronico");
			datos.e_mail = Console.ReadLine (); 
			Console.Clear (); 
			Console.WriteLine("Nombre: "+ datos.nombre);
			Console.WriteLine("Telefono: "+ datos.telefono);
			Console.WriteLine("Direccion: "+ datos.direccion);
			Console.WriteLine("Correo electronico: "+ datos.e_mail);
			}
	
         }
     }

