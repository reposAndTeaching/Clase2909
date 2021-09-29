//Dependencias
//import
using System;


//nombre de la solución
namespace Clase2909
{
    //clase principal Program
    class Program
    {
        //Main: llave de contacto
        static void Main(string[] args)
        {
            //INSTANCIAR UNA CLASE
            //Creando un objeto del tipo (clase)
            //Persona
            //Instanciar la clase persona o crear un objeto del tipo persona

            //DECLARO mi variable inicial
            //tipo de dato - nombre
            Persona nuevaPersona;
            //Inicializo a persona
            //nombre = new(palabra reservada)
            nuevaPersona = new Persona();

            //mostramos los atributos de persona, vacíos.
            //Console.WriteLine(nuevaPersona.nombre);
            //Console.WriteLine(nuevaPersona.edad);
            Console.WriteLine(nuevaPersona.obtenerNombre());
            Console.WriteLine(nuevaPersona.obtenerEdad());

            //.
            //nuevaPersona.nombre = "Diego";
            //nuevaPersona.edad = 23;
            nuevaPersona.cambiarNombre("Diego");
            nuevaPersona.Edad = 12;

            //mostramos con valores dados
            //System.out.println - System.out.print
            //print
            //put
            //echo
            //Console.WriteLine(nuevaPersona.nombre);
            //Console.WriteLine(nuevaPersona.edad);
            Console.WriteLine(nuevaPersona.obtenerNombre());
            Console.WriteLine(nuevaPersona.Nombre);
            Console.WriteLine(nuevaPersona.obtenerEdad());
            Console.WriteLine(nuevaPersona.Edad);

            //int = Int32
            //short = Int16
            //long = Int64
            Console.WriteLine("*******************************************");

            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);


            Console.WriteLine("*********************************************");

            //llamo a la función x que he creado
            Console.WriteLine(nuevaPersona.entregarInformacionCompleta());
            nuevaPersona.mostrarInformacionCompleta();

            //probando función booleana
            if (nuevaPersona.esMayorDeEdad())
            {
                Console.WriteLine("Ésta persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Ésta persona no es mayor de edad.");
            }

            Console.WriteLine("********************************************");

            //Declarar e inicializar en una misma línea
            Persona segundaPersona = new Persona("Juan Pablo", 20);
            Console.WriteLine(segundaPersona.Nombre);
            Console.WriteLine(segundaPersona.Edad);

            Persona terceraPersona = new Persona("Fulanito");
            Console.WriteLine(terceraPersona.Nombre);
            Console.WriteLine(terceraPersona.Edad);

            
        }
    }

    //nueva clase persona
    //identidad
    //estado
    //comportamiento
    //Clase comienza con mayúscula y siempre declaradas en singular
    class Persona
    {
        //estado
        //predeterminado, (private)
        private string nombre;
        private int edad;

        public string Nombre //Propiedad
        { 
            get => nombre;
            set => nombre = value; 
        }
        public int Edad //Propiedad
        { 
            get => edad;
            set
            {
                edad = value;
                if(edad < 0)
                {
                    edad = 0;
                }
            }
        }

        //mutador de acceso(private) - tipo de retorno - nombre de la función - argumento de la función()
        //Obtener el nombre (gettters) getNombre()
        public string obtenerNombre()
        {
            return nombre;
        }

        //setter setNombre()
        public void cambiarNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public int obtenerEdad()
        {
            return edad;
        }

        public void cambiarEdad(int edad)
        {
            this.edad = edad;

            if(this.edad < 0)
            {
                this.edad = 0;
            }
        }



        //COMPORTAMIENTO
        public string entregarInformacionCompleta()
        {
            return "Soy una persona llamada "+nombre+" y tengo la edad de "+edad+" años.";
        }

        public void mostrarInformacionCompleta()
        {
            Console.WriteLine("Soy una persona llamada " + nombre + " y tengo la edad de " + edad + " años.");
        }

        public bool esMayorDeEdad()
        {
            if(edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Persona()
        {
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
            this.edad = 18;
        }

        public Persona(string edad, string nombre)
        {
            int edadConvertida = Convert.ToInt32(edad);
            this.edad = edadConvertida;
            this.nombre = nombre;
        }
    }
}
