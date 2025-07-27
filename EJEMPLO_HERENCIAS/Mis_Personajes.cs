using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EJEMPLO_HERENCIAS
{
    class PERSONAJE
    {
        //[+] ATRIBUTOS
        private string nombre;
        private int vida;
        private int inteligencia;
        private string skins;

        //Recuerde que esto se debe dejar como privado para evitar que
        //los atributos sean modificados sin ninguna seguridad

        //[+] CONSTRUCTOR
        public PERSONAJE(string nombre, int vida, int inteligencia, string skins)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.inteligencia = inteligencia;
            this.skins = skins;
        }

        //Recuerden que el constructor es como la instruciones de la receta
        //allí definimos los datos necesarios para crear el objeto

        public string Obtener_Nombre
        {
            get { return nombre; }
        }
        public string Modificar_Nombre
        {
            set { nombre = value; }
        }
        public int Obtener_Vida
        {
            get { return vida; }
        }

        public int Modificar_Vida
        {
            set { vida = value; }
        }

        public int Obtener_inteligencia
        {
            get { return inteligencia; }
        }

        public int Modificar_inteligencia
        {
            set { inteligencia = value; }
        }

        public string Obtener_skins
        {
            get { return skins; }
        }

        public string Modificar_skins
        {
            set { skins = value; }
        }

        public virtual void Atacar()
        {
            Console.WriteLine($" {nombre} hace un ataque generico");
        }

        public virtual void Hacer_sonido()
        {

        }

        //[virtual] Permite que un método en la clase base pueda ser modificado por las clases mago y guerrero.
    }

    class MAGO : PERSONAJE
    {
        private int magia;
        private string pociones;
        public MAGO(string nombre, int vida, int inteligencia, string skins, int magia, string pociones) : base (nombre, vida, inteligencia, skins)
        {
            this.magia = magia;
            this.pociones = pociones;
        }

        public int Obtener_Magia
        {
            get { return magia; }
        }

        public int Modificar_Magia
        {
            set { magia = value; }
        }

        public string Obtener_Pociones
        {
            get { return pociones; }
        }

        public string Modificar_Pociones
        {
            set { pociones = value; }
        }

        public override void Atacar()
        {
            Console.WriteLine($" {Obtener_Nombre} realiza un hechizo");
        }

        public override void Hacer_sonido()
        {
            Console.WriteLine("Miau");
        }

        //[override] Se usa en las clases hijas para personalizar el comportamiento del método heredado.
    }

    class GUERRERO : PERSONAJE
    {
        private int fuerza;
        private string arma;

        public GUERRERO(string nombre, int vida, int inteligencia, string skins, int fuerza, string arma) :
            base (nombre, vida, inteligencia, skins)
        {
            this.fuerza = fuerza;
            this.arma = arma;
        }

        public int Obtener_Fuerza
        {
            get { return fuerza; }
        }

        public int Modificar_Fuerza
        {
            set 
            {
                if(value < 100)
                {
                    fuerza = value;

                }
                else
                {
                    fuerza = 100;
                }
            }
        }

        public string Obtener_Arma
        {
            get { return arma; }
        }

        public string Modificar_Arma
        {
            set { arma = value; }
        }

        public override void Atacar()
        {
            Console.WriteLine($" {Obtener_Nombre} realiza un golpe con {arma}");
        }

        public void Encendido()
        {

        }

        public override void Hacer_sonido()
        {
            Console.WriteLine("Gaua");
        }
    }
}
